using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DronLunch.Helper
{
    public class FileReading
    {
        public string[] ReadFile(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath);
            return lines;
        }
    }
}
