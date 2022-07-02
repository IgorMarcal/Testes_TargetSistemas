using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEmpresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SP = 67_836.43, porcentagemSP=0;
            double RJ = 36_678.66, porcentagemRJ=0;
            double MG = 29_229.88, porcentagemMG=0;
            double ES = 27_165.48, porcentagemES=0;
            double Outros = 19_849.53, porcentagemOutros=0;
            double somaFaturamento = 0;

            somaFaturamento = SP + RJ + MG + ES + Outros;
            porcentagemSP = (SP * 100) / somaFaturamento;
            porcentagemRJ = (RJ * 100) / somaFaturamento;
            porcentagemMG = (MG * 100) / somaFaturamento;
            porcentagemES = (ES * 100) / somaFaturamento;
            porcentagemOutros = (Outros * 100) / somaFaturamento;

    
          
            Console.WriteLine("Faturamento total: "+somaFaturamento);
            Console.WriteLine("Porcentagem de faturamento em SP: " + Math.Round(porcentagemSP, 2).ToString());
            Console.WriteLine("Porcentagem de faturamento em RJ: " + Math.Round(porcentagemRJ, 2).ToString());
            Console.WriteLine("Porcentagem de faturamento em MG: " + Math.Round(porcentagemMG, 2).ToString());
            Console.WriteLine("Porcentagem de faturamento em ES: " + Math.Round(porcentagemES, 2).ToString());
            Console.WriteLine("Porcentagem de faturamento nas demais regiões: " + Math.Round(porcentagemOutros,2).ToString());     
        }
    }
}
