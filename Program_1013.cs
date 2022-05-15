using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] valor = Console.ReadLine().Split(' ');
            int a = Int32.Parse(valor[0]);
            int b = Int32.Parse(valor[1]);
            int c = Int32.Parse(valor[2]);
            long maiorAB =(a+b+Math.Abs(a-b))/2;
            long maiorC = (maiorAB+c+Math.Abs(maiorAB-c))/2;
            Console.WriteLine(maiorC+" eh o maior");

        }
    }
}
