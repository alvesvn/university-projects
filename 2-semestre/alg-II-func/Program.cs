namespace alg_II_func;

class Program
{
    static void Main(string[] args)
    {
        Escrever("Vinicius");
        Escrever("Fernando");
        Escrever("João");
        Escrever("Maria");
        Escrever("Fernanda");
        Escrever("Amanda");
        Escrever("Jessica");
   }

   public static void Escrever(string nome){
    Console.WriteLine($"Oi, {nome}. Tudo bem?");

   }
}
