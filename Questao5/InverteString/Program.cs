using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverteString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string frase1=null;

            Console.WriteLine("Digite uma frase: ");
            frase1 = Console.ReadLine();

            Console.WriteLine("Frase invertida: ");

            for (int i = frase1.Length-1; i >= 0 ; i--)
            {
                Console.Write(frase1[i]);

            }
            Console.WriteLine("");
        }
    }
}
