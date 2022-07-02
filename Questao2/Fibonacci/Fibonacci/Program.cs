using System;

public class exercicios
{
    public static void Main()
    {

        int valor = 0, n1 = 1, soma = 0, n2 = 0;
        bool verdade = false;

        Console.WriteLine("Digite o valor a ser testado: ");
        valor = int.Parse(Console.ReadLine());

        for (int i=1; i<=valor; i++)
        {

            soma = n1 + n2;
            n2 = n1;
            n1 = soma ;

            if(valor == soma)
            {
                verdade = true;
                i = valor + 1;
                Console.WriteLine("Pertence a sequencia de fibonacci");

            }
        }

        if (!verdade)
        {
            Console.WriteLine("Não pertence a sequencia de fibonacci");
        }

        Console.ReadKey();
    }

}