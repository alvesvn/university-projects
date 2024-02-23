namespace alg_II_func_III;

class Program
{
    static void Main(string[] args)
    {
        int a = Somar (5, 3);
        int b = Somar (15, 5);

        Console.WriteLine($"A soma de 5 e 3 é {a}");
        Console.WriteLine($"A soma de 15 e 5 é {b}");    }


    public static int Somar(int n1, int n2){
        int s = n1 + n2;
        return s;
    }
}
