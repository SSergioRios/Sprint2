using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalDeNotas=Convert.ToInt32(Console.ReadLine());
            int nota100,nota50,nota20,nota10,nota5,nota2,nota1;
            Console.WriteLine(TotalDeNotas);
            nota100=TotalDeNotas/100;
            TotalDeNotas%=100;
            Console.WriteLine(nota100+" nota(s) de R$ 100,00");
            nota50=TotalDeNotas/50;
            TotalDeNotas%=50;
            Console.WriteLine(nota50+" nota(s) de R$ 50,00");
            nota20=TotalDeNotas/20;
            TotalDeNotas%=20;
            Console.WriteLine(nota20+" nota(s) de R$ 20,00");
            nota10=TotalDeNotas/10;
            TotalDeNotas%=10;
            Console.WriteLine(nota10+" nota(s) de R$ 10,00");
            nota5=TotalDeNotas/5;
            TotalDeNotas%=5;
            Console.WriteLine(nota5+" nota(s) de R$ 5,00");
            nota2=TotalDeNotas/2;
            TotalDeNotas%=2;
            Console.WriteLine(nota2+" nota(s) de R$ 2,00");
            nota1=TotalDeNotas/1;
            TotalDeNotas%=1;
            Console.WriteLine(nota1+" nota(s) de R$ 1,00");
            Console.ReadKey();

        }
    }
}
