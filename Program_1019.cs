using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int Horas=0;
            int Minutos=0;
            int Segundos=0;
            if(N>=3600)
            {
                Horas=N/3600;
                Minutos=(N%3600)/60;
                Segundos=N%60;

            }else{
                Minutos=N/60;
                Segundos=N%60;
            }
            Console.WriteLine(Horas+":"+Minutos+":"+Segundos);
        }
    }
}
