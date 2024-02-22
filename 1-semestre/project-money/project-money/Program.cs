using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Informe seu salário: ");
    double salario = double.Parse(Console.ReadLine());
    double salarioReajustado;
    if (salario <= 300)
    {
      salarioReajustado = salario + (salario * 0.15);
    }
    else
    {
      salarioReajustado = salario + (salario * 0.075);
    }

    Console.WriteLine("Salario reajustado para R${0:N2}", salarioReajustado);

    Console.ReadLine();
  }
}