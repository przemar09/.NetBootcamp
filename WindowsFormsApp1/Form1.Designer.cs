namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.startInfoLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minMaxOkBtn = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clientIdTxtBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanel.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Controls.Add(this.buttonK);
            this.sidePanel.Controls.Add(this.buttonJ);
            this.sidePanel.Controls.Add(this.buttonI);
            this.sidePanel.Controls.Add(this.buttonH);
            this.sidePanel.Controls.Add(this.buttonG);
            this.sidePanel.Controls.Add(this.buttonD);
            this.sidePanel.Controls.Add(this.buttonC);
            this.sidePanel.Controls.Add(this.buttonB);
            this.sidePanel.Controls.Add(this.buttonF);
            this.sidePanel.Controls.Add(this.buttonE);
            this.sidePanel.Controls.Add(this.buttonA);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 582);
            this.sidePanel.TabIndex = 0;
            // 
            // buttonK
            // 
            this.buttonK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonK.Location = new System.Drawing.Point(12, 477);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(224, 44);
            this.buttonK.TabIndex = 11;
            this.buttonK.Text = "Zamówienia w przedziale cenowym";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJ.Location = new System.Drawing.Point(12, 428);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(224, 43);
            this.buttonJ.TabIndex = 10;
            this.buttonJ.Text = "Ilość zamówień pogrupowanych po nazwie dla klienta";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonI
            // 
            this.buttonI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonI.Location = new System.Drawing.Point(12, 379);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(224, 43);
            this.buttonI.TabIndex = 9;
            this.buttonI.Text = "Ilość zamówień pogrupowanych po nazwie";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonH
            // 
            this.buttonH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonH.Location = new System.Drawing.Point(12, 331);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(224, 42);
            this.buttonH.TabIndex = 8;
            this.buttonH.Text = "Średnia wartość zamówienia dla klienta";
            this.buttonH.UseVisualStyleBackColor = true;
            // 
            // buttonG
            // 
            this.buttonG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonG.Location = new System.Drawing.Point(12, 293);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(224, 32);
            this.buttonG.TabIndex = 7;
            this.buttonG.Text = "Średnia wartość zamówienia";
            this.buttonG.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonD.Location = new System.Drawing.Point(12, 168);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(224, 43);
            this.buttonD.TabIndex = 6;
            this.buttonD.Text = "Łączna kwota zamówień dla klienta";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.Location = new System.Drawing.Point(12, 130);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(224, 32);
            this.buttonC.TabIndex = 5;
            this.buttonC.Text = "Łączna kwota zamówień";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB.Location = new System.Drawing.Point(12, 92);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(224, 32);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "Ilość zamówień dla klienta";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonF
            // 
            this.buttonF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF.Location = new System.Drawing.Point(12, 255);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(224, 32);
            this.buttonF.TabIndex = 3;
            this.buttonF.Text = "Lista zamówień dla klienta";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonE
            // 
            this.buttonE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonE.Location = new System.Drawing.Point(12, 217);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(224, 32);
            this.buttonE.TabIndex = 2;
            this.buttonE.Text = "Lista wszystkich zamówień";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonA
            // 
            this.buttonA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA.Location = new System.Drawing.Point(12, 54);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(224, 32);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "Ilość zamówień";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.saveBtn);
            this.content.Controls.Add(this.resultLabel);
            this.content.Controls.Add(this.startInfoLabel);
            this.content.Controls.Add(this.dataGridView);
            this.content.Controls.Add(this.addFileBtn);
            this.content.Controls.Add(this.panel1);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(250, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(884, 582);
            this.content.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(602, 500);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 47);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Zapisz do pliku";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(106, 168);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 5;
            // 
            // startInfoLabel
            // 
            this.startInfoLabel.AutoSize = true;
            this.startInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startInfoLabel.Location = new System.Drawing.Point(102, 229);
            this.startInfoLabel.Name = "startInfoLabel";
            this.startInfoLabel.Size = new System.Drawing.Size(670, 20);
            this.startInfoLabel.TabIndex = 2;
            this.startInfoLabel.Text = "Aby rozpocząć naciśnij przycisk \"Dodaj plik\". Obsługiwane pliki z rozszerzeniem ." +
    "csv, .xml, .json";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 144);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(837, 350);
            this.dataGridView.TabIndex = 4;
            // 
            // addFileBtn
            // 
            this.addFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFileBtn.Location = new System.Drawing.Point(720, 500);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(112, 47);
            this.addFileBtn.TabIndex = 3;
            this.addFileBtn.Text = "Dodaj plik";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.minMaxOkBtn);
            this.panel1.Controls.Add(this.maxLabel);
            this.panel1.Controls.Add(this.maxTextBox);
            this.panel1.Controls.Add(this.minLabel);
            this.panel1.Controls.Add(this.minTextBox);
            this.panel1.Controls.Add(this.clientIdLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.clientIdTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 125);
            this.panel1.TabIndex = 0;
            // 
            // minMaxOkBtn
            // 
            this.minMaxOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minMaxOkBtn.Location = new System.Drawing.Point(808, 70);
            this.minMaxOkBtn.Name = "minMaxOkBtn";
            this.minMaxOkBtn.Size = new System.Drawing.Size(45, 30);
            this.minMaxOkBtn.TabIndex = 10;
            this.minMaxOkBtn.Text = "OK";
            this.minMaxOkBtn.UseVisualStyleBackColor = true;
            this.minMaxOkBtn.Click += new System.EventHandler(this.minMaxOkBtn_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLabel.Location = new System.Drawing.Point(657, 75);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(69, 20);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "Cena do";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTextBox.Location = new System.Drawing.Point(732, 73);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(70, 26);
            this.maxTextBox.TabIndex = 8;
            // 
            // minLabel
            // 
            this.minLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLabel.Location = new System.Drawing.Point(508, 75);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(69, 20);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Cena od";
            // 
            // minTextBox
            // 
            this.minTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTextBox.Location = new System.Drawing.Point(581, 72);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(70, 26);
            this.minTextBox.TabIndex = 6;
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientIdLabel.Location = new System.Drawing.Point(52, 78);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(67, 20);
            this.clientIdLabel.TabIndex = 5;
            this.clientIdLabel.Text = "ClientId:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.ApplicationNameLabel);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 54);
            this.panel2.TabIndex = 1;
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplicationNameLabel.ForeColor = System.Drawing.Color.White;
            this.ApplicationNameLabel.Location = new System.Drawing.Point(242, 9);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(311, 29);
            this.ApplicationNameLabel.TabIndex = 1;
            this.ApplicationNameLabel.Text = "Order managment system";
            this.ApplicationNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(837, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // clientIdTxtBox
            // 
            this.clientIdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientIdTxtBox.Location = new System.Drawing.Point(125, 75);
            this.clientIdTxtBox.Name = "clientIdTxtBox";
            this.clientIdTxtBox.Size = new System.Drawing.Size(70, 26);
            this.clientIdTxtBox.TabIndex = 4;
            this.clientIdTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientIdTxtBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1134, 582);
            this.Controls.Add(this.content);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.TextBox clientIdTxtBox;
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Label startInfoLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button minMaxOkBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

