using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.TxtFileReader;
using System.IO;

namespace CA.StatementReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StatementFileReader fr;
            string resp = string.Empty;
            string CarpetaTemporal = @"C:\Users\52553\OneDrive\Escritorio\D\Trabajo\Proyectos\LayOutsTXT\STATEMENT\Statement\Archivos Prosa\";
            //foreach(string s in Directory.GetFiles(CarpetaTemporal, "STATEMENT*").ToList<string>())
            //List<string> lstArchivos = Directory.GetFiles(CarpetaTemporal, "STATEMENT_0039_28_C_*").ToList<string>();
            List<string> lstArchivos = Directory.GetFiles(CarpetaTemporal, "STATEMENT*").OrderBy(f=>new FileInfo(f).CreationTime).ToList<string>();
            foreach (string s in lstArchivos)
            {
                fr = new StatementFileReader(s);
                resp = fr.ReadStatement();
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.Write(resp);
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("Proceso finalizado.");
            Console.WriteLine("Numero de archivos procesados: " + lstArchivos.Count.ToString());
            Console.ReadKey(true);
        }
    }
}
