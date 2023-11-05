using System;
class Program
{
  public static void Main(string[] args)
  {
    //aqui colocamos nosso algoritmo
    Console.Write("Informe seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Olá, {0}!", nome);
    Console.ReadLine();
  }

}