namespace alg_II;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o primeiro número");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int soma = n1 + n2; 

        Console.WriteLine($"A soma de {n1} com {n2} é {soma}"); 
    }
}


