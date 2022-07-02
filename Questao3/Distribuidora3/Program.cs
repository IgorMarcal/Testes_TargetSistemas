using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


using System.IO;
using System.Web.Script.Serialization;
namespace Distribuidora3
{
    class Program
    {
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("dados.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                double max=0,min=0, soma=0, media=0;
                int cont = 0;
                bool primeiraVez = true;
                
                foreach (var elemento in items)
                {
                    //Console.WriteLine($"Dia:{elemento.dia} Valor:{elemento.valor}");

                    if(elemento.valor > 0 && primeiraVez)
                    {
                        min = elemento.valor;
                        max = elemento.valor;
                        primeiraVez = false;
                        
                    }
                    
                    if (elemento.valor < min && elemento.valor != 0)
                    {
                        min = elemento.valor;
                    }

                    if (elemento.valor > max )
                    {
                        max = elemento.valor;
                    }
                    
                    if (elemento.valor != 0)
                    {
                        soma += elemento.valor;
                        cont++;
                    }

                    media = soma/cont;

                }

                Console.WriteLine($"O menor valor é: {min} e o maior valor é: {max} e a média é: {media}");

            }
        }

        public class Item
        {
            public double valor;
            public string dia;
        }

        static void Main(string[] args)
        {

            LoadJson();





            /*
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                using (StreamReader sr = new StreamReader("dados.json"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                    dynamic array = JsonConvert.DeserializeObject(line);
                    foreach (var item in array)
                    {
                        Console.WriteLine("{0} {1}", item.dia, item.valor);
                    }

                }
            }
            catch(Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            */


        }
    }

}
