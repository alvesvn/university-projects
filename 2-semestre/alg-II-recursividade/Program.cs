 namespace alg_II_recursividade;

class Program
{
    static void Main(string[] args)
    {
        Contar(0,10);
    }

    public static void Contar(int inicio, int fim)
    {

        if (inicio > fim)
        return;
        Console.WriteLine(inicio);
        Contar(inicio + 1, fim);

    }
    
    }

