using System;
using System.Globalization;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            // O progrma tá a 5% de de ser aceirto na plataforma não consegui indentificar o erro!
            
            double Vtotal=Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            int Ctotal= Convert.ToInt32(Vtotal);
            //int Nnota=0;
            int [] papel={100,50,20,10,5,2};
            double [] moeda={1.00,0.50,0.25,0.10,0.05,0.01};
            int i =0;
            Console.WriteLine("NOTAS:");
            while (i<=5)
            {
                
                if(Ctotal<=papel[i])
                {
                    Ctotal/=papel[i];
                    Console.WriteLine(0+" nota(s) de R$ "+papel[i].ToString("F2", CultureInfo.InvariantCulture));
                   
                }
                if(Ctotal>=papel[i])
                {
                    Ctotal/=papel[i];
                    Console.WriteLine(Ctotal+" nota(s) de R$ "+papel[i].ToString("F2", CultureInfo.InvariantCulture));
                    
                }
                Vtotal%=Convert.ToDouble(papel[i]);
                Ctotal= Convert.ToInt32(Vtotal);
                i++;
                
                
                
            }
            Console.WriteLine("MOEDAS:");
            i=0;
            int [] papel2={100,50,25,10,5,2};
            Vtotal*=100.0;
            Ctotal= Convert.ToInt32(Vtotal);
            while (i<=5)
            {
                if(Ctotal<=papel2[i])
                {
                    Ctotal/=papel2[i];
                    Console.WriteLine(0+" moeda(s) de R$ "+moeda[i].ToString("F2", CultureInfo.InvariantCulture));
                }
                if(Ctotal>=papel2[i])
                {
                    Ctotal/=papel2[i];
                    Console.WriteLine(Ctotal+" moeda(s) de R$ "+moeda[i].ToString("F2", CultureInfo.InvariantCulture));
                }
                
                Vtotal%=Convert.ToDouble(papel2[i]);
                Ctotal= Convert.ToInt32(Vtotal);
                i++;
            }
            
        }
    }
}
