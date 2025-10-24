using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il path");
            string path = Console.ReadLine();

            Write w = new Write(path);

            w.ScriviFile();

            Console.WriteLine("Operazione completata");
        }
    }
}
