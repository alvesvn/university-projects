using System;
class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine());
    int dobro = num * 2;
    Console.WriteLine("Dobro = {0}", dobro);
    Console.ReadLine();

  }

}