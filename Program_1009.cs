using System;
using System.Globalization;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Bonus vendedor1 = new Bonus(nome, salario, totalDeVendas);
            vendedor1.SalarioBruto();
            Console.ReadKey();
        }

    }
}
public class Bonus
  {
    string Nome { get; set; }
    double Salario { get; set; }
    double Total { get; set; }
    double Comissao;
    public Bonus(string nome, double salario, double totalmes)
    {
      Nome = nome;
      Salario = salario;
      Total = totalmes;
      Comissao = Salario + (Total * 0.15);
    }
    public void SalarioBruto()
    {
      Console.WriteLine("TOTAL = R$ "+Comissao.ToString("F2", CultureInfo.InvariantCulture));

    }
   
  }
