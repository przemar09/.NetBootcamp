using Infrastructure.Services;
using OrderManagmentSystem.Repositories;
using OrderManagmentSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public IOrderRepository orderRepository;
        public IFileReader fileReader;
        public OrderRaports orderRaports;
        public FileSaver fileSaver;
        int panelWidth;
        bool hidden;
        char selectedMenu = '0';

        public Form1()
        {
            InitializeComponent();
            panelWidth = sidePanel.Width;
            sidePanel.Width -= panelWidth;
            hidden = true;
            dataGridView.Visible = false;
            resultLabel.Visible = false;
            saveBtn.Visible = false;
            HideClientId();
            HideMinMaxLabel();
            orderRepository = new InMemoryOrderRepository();
            
            orderRaports = new OrderRaports(orderRepository);
            fileSaver = new FileSaver(orderRaports);           
        }

        private void addFileBtn_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files (*.csv)|*.csv|xml files (*.xml)|*.xml|json files (*.json)|*.json";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
                if(path.EndsWith(".csv"))
                {
                    fileReader = new CsvReader(orderRepository);
                    fileReader.ReadFile(path);
                }
                else if(path.EndsWith(".xml"))
                {
                    fileReader = new ReaderXml(orderRepository);
                    fileReader.ReadFile(path);
                }
               
            }

            startInfoLabel.Visible = false;
            saveBtn.Visible = true;
            timer1.Start();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            selectedMenu = 'A';
            HideClientId();
            HideMinMaxLabel();
            dataGridView.Visible = false;
            int result = orderRaports.GetOrderAmount();
            resultLabel.Text = $"Ilość zamówień: {result}";
            resultLabel.Visible = true;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            ShowClientId();
            HideMinMaxLabel();
            resultLabel.Text = "";
            selectedMenu = 'B';
            resultLabel.Visible = true;
            dataGridView.Visible = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            selectedMenu = 'C';
            HideClientId();
            HideMinMaxLabel();
            dataGridView.Visible = false;
            resultLabel.Visible = true;
            string result = orderRaports.GetTotalPriceOfOrders().ToString();
            resultLabel.Text = "Łączna kwota zamówień: " + result;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ShowClientId();
            HideMinMaxLabel();
            dataGridView.Visible = false;
            resultLabel.Visible = true;
            resultLabel.Text = "";
            selectedMenu = 'D';
        }
        
        private void buttonE_Click(object sender, EventArgs e)
        {
            selectedMenu = 'E';
            HideClientId();
            HideMinMaxLabel();
            resultLabel.Visible = false;
            dataGridView.Visible = true;

            var dataTable = PopulateColums();
            
            foreach (var val in orderRaports.GetTotalListOfOrders())
            {
                dataTable.Rows.Add(val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price);
            }

            this.dataGridView.DataSource = dataTable;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            ShowClientId();
            HideMinMaxLabel();
            dataGridView.Visible = true;
            resultLabel.Visible = false;
            selectedMenu = 'F';
            dataGridView.DataSource = null;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            selectedMenu = 'I';
            HideClientId();
            HideMinMaxLabel();
            dataGridView.Visible = true;
            resultLabel.Visible = false;
            dataGridView.DataSource = null;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Quantity");

            foreach(var val in orderRaports.GetAmountOfOrdersGroupedByName())
            {
                dataTable.Rows.Add(val.Key, val.Value);
            }

            dataGridView.DataSource = dataTable;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            ShowClientId();
            HideMinMaxLabel();
            dataGridView.Visible = true;
            resultLabel.Visible = false;
            dataGridView.DataSource = null;
            selectedMenu = 'J';
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            selectedMenu = 'K';
            ShowMinMaxLabel();
            HideClientId();
            dataGridView.Visible = true;
            resultLabel.Visible = false;
            dataGridView.DataSource = null;
        }

        private void minMaxOkBtn_Click(object sender, EventArgs e)
        {
            double minPrice = double.Parse(minTextBox.Text);
            double maxPrice = double.Parse(maxTextBox.Text);
            var dataTable = PopulateColums();
            foreach(var val in orderRaports.GetOrdersInPriceRange(minPrice, maxPrice))
            {
                dataTable.Rows.Add(val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price);
            }

            dataGridView.DataSource = dataTable;
        }

        private void clientIdTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string clientId = this.clientIdTxtBox.Text;
                var dataTable = PopulateColums();

                switch(selectedMenu)
                {
                    case 'B':
                        {
                            try
                            {
                                string result = orderRaports.GetOrderAmountPerClient(clientId).ToString();
                                resultLabel.Text = $"Ilość zamówień dla klienta z id {clientId} wynosi: {result}";
                            }
                            catch (ArgumentNullException exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                            break;
                        }
                    case 'D':
                        {
                            try
                            {
                                string result = orderRaports.GetTotalPriceOfOrdersPerClient(clientId).ToString();
                                resultLabel.Text = $"Łączna kwota zamówień dla klienta z id: {clientId} wynosi: " + result;
                            }
                            catch (ArgumentNullException exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                            break;
                            
                        }
                    case 'F':
                        {
                            try
                            {
                                foreach (var val in orderRaports.GetTotalListOfOrdersPerClient(clientId))
                                {
                                    dataTable.Rows.Add(val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price);
                                }
                            }
                            catch (ArgumentNullException exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                            break;
                        }
                    case 'J':
                        {

                            dataTable = new DataTable();
                            dataTable.Columns.Add("Name");
                            dataTable.Columns.Add("Quantity");
                            try
                            {
                                foreach (var val in orderRaports.GetAmountOfOrdersGroupedByNamePerClient(clientId))
                                {
                                    dataTable.Rows.Add(val.Key, val.Value);
                                }
                            }
                            catch (ArgumentNullException exception)
                            {
                                MessageBox.Show(exception.Message);
                            }
                            break;
                        }
                }
                
                this.dataGridView.DataSource = dataTable;
            }
        }

        private static DataTable PopulateColums()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ClientId");
            dataTable.Columns.Add("ReqeustId");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            return dataTable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 10;
                if (sidePanel.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
        }

        private void HideClientId()
        {
            clientIdTxtBox.Visible = false;
            clientIdLabel.Visible = false;
        }

        private void ShowClientId()
        {
            clientIdTxtBox.Visible = true;
            clientIdLabel.Visible = true;
        }

        private void HideMinMaxLabel()
        {
            minLabel.Visible = false;
            maxLabel.Visible = false;
            minTextBox.Visible = false;
            maxTextBox.Visible = false;
            minMaxOkBtn.Visible = false;
        }

        private void ShowMinMaxLabel()
        {
            minLabel.Visible = true;
            maxLabel.Visible = true;
            minTextBox.Visible = true;
            maxTextBox.Visible = true;
            minMaxOkBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            double min, max;
            if (double.TryParse(minTextBox.Text, out min))
            {
            }
            else min = 0;
            if (double.TryParse(maxTextBox.Text, out max))
            {
            }
            else max = 0;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileSaver.SaveFile(saveFileDialog.FileName, selectedMenu, clientIdTxtBox.Text, min, max);
                }
                catch(ArgumentNullException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch(Exception exception)
                {
                    MessageBox.Show("ClientId nie moze mieć spacji albo być dłuższy niż 6 znaków.");
                }
            }
        }
    }
}
