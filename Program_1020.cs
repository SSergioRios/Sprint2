using System;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            long Total = Convert.ToInt64(Console.ReadLine());
            long Anos=0;
            long Meses=0;
            long Dias=0;
            //int Resto=0;
            if (Total>=365)
            {
                Anos=Total/365;
                //Resto=(Total%365);

                Meses=(Total%365)/30;
                Dias=(Total%365)%30;
            }else{
                Meses=(Total%365)/30;
                Dias=(Total%365)%30;
            }
            Console.WriteLine(Anos+" ano(s)");
            Console.WriteLine(Meses+" mes(es)");
            Console.WriteLine(Dias+" dia(s)");
        }
    }
}
