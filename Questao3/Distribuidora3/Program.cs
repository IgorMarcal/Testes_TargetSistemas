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

        }
    }

}
