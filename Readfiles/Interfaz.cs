using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace readfile
{
    ///<summary>
    ///Clase principal para leer un archivo de texto.
    ///</summary>
    ///<remarks>
    ///Lee archivo de texto con una ruta específica.
    ///</remarks>
    ///Using <see cref="using statement (C# Reference)"/>
    ///StreamReader <see cref="Streamreader Class"/>
    class Program
    {
        static void Main(string[] args)
        {
            // Contiene la ruta de archivo puede ser diferente.
            string path = @"C:\Users\francisco\source\repos\ReadFiles\Readfiles\VentasDiarias\13136951201062019.txt";
            // Inicializar variable vacia.
            string f = "";
            
            if (File.Exists(path))
            {
                // Using nos permite utilizar un objeto en este bloque de código, una vez utilizado se destruirá.
                using (StreamReader sr = new StreamReader(path))
                // Se utilizamos la instancia de StreamReader para leer el texto de un archivo.
                {
                    while ((f = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(f);
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Archivo no encontrado..");
                Console.ReadKey();
            }
        }
    }
}
