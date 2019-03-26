using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services
{
    public interface IFileReader
    {
        void ReadFile(string path);
    }
}
