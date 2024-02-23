namespace alg_II_func_II;

class Program
{
    static void Main(string[] args)
    {
        Somar(5,3);
        
    }

    static void Somar(int n1, int n2){
        int s = n1 + n2; 
        Console.WriteLine($" A soma de {n1} e {n2} é {s}");
    }
}
