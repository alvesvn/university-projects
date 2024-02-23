namespace alg_II_media;

class Program
{
    static void Main(string[] args)
    {
        double n1 = pedirNota("Informe a nota 1: ");
        double n2 = pedirNota("Informe a nota 2: ");
        double n3 = pedirNota("Informe a nota 3: ");

        double media = CalcularMedia(n1,n2,n3);

        string sit = Situacao(media);

        Escrever("A média final é: " + media);
        Escrever("Situação: " + sit);
    }

    public static void Escrever(string msg){
        Console.WriteLine(msg);
    }
    
    public static double pedirNota(string msg)
    {
        Console.WriteLine(msg);
        double n = Convert.ToDouble(Console.ReadLine());
        return n;
    }

    public static double CalcularMedia(double n1, double n2, double n3){
        double m = (n1 + n2 + n3) / 3;
        return m;
    }

    public static string Situacao(double media){

        string sit =""; 
        if (media >=6){
            sit = "Aprovado";
        }
        else{
            sit = "Reprovado";
        }
        return sit; 
    }

}
