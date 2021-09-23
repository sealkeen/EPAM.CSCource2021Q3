using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextAndNumberDataConverter
{
    public class PhoneNumbersFile
    {
        const string defaultFilePath = "../../../Text.txt";
        StreamReader txtReader;
        public PhoneNumbersFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                txtReader = new System.IO.StreamReader(defaultFilePath);
            }

            txtReader = new System.IO.StreamReader(filePath);
        }
        public string GetAllTextData()
        {
            return txtReader.ReadToEnd();
        }
        public void WriteNumbersInFile(string filePath, IEnumerable<string> data)
        {
            if (!File.Exists(filePath))
                File.Create(filePath);
            if ((txtReader != null))
            {
                txtReader.Close();
            }
            StreamWriter sWriter = new StreamWriter(filePath);
            foreach (var line in data)
            {
                sWriter.WriteLine(line);
            }
            sWriter.Close();
        }
        ~PhoneNumbersFile() 
        {
            if (txtReader != null)
            {
                txtReader.Close();
            }
        }
    }
}
