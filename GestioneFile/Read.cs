using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Read
    {
        private string filePath;

        public Read(string path)
        {
            filePath = path;
        }
            public void LeggiFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Errore nella lettura del file" + e.Message);
            }
         }
    }
}
