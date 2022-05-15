using System;
using System.Globalization;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] Produto1 = Console.ReadLine().Split(' ');
            string codigo1 = Produto1[0];
            int peca1 = Int32.Parse(Produto1[1]);
            double valor1 = double.Parse(Produto1[2], CultureInfo.InvariantCulture);
            String [] Produto2 = Console.ReadLine().Split(' ');
            string codigo2 = Produto1[0];
            int peca2 = Int32.Parse(Produto2[1]);
            double valor2 = double.Parse(Produto2[2], CultureInfo.InvariantCulture);

            double total=(valor1*peca1)+(valor2*peca2);

            
            Console.WriteLine("VALOR A PAGAR: R$ "+total.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
