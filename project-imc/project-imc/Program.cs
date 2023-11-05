﻿using System;
class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Informe o seu peso: ");
    double peso = double.Parse(Console.ReadLine());
    Console.Write("Informe a sua altura: ");
    double altura = double.Parse(Console.ReadLine());
    double imc = peso / (altura * altura);
    Console.WriteLine("IMC = {0:N1}", imc);
    if (imc < 20)
    {
      Console.WriteLine("Abaixo do peso.");
    }
    else if (imc < 25)
    {
      Console.WriteLine("Peso ideal.");
    }
    else
    {
      Console.WriteLine("Acima do peso");
    }
    Console.ReadLine();
  }

}