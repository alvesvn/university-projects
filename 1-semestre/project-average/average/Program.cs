using System; 

class Program{
    public static void Main (string[] args){
        int cont = 0;
        int soma = 0;
        
        Console.Write("Informe um número: ");
        
        int n = int.Parse(Console.ReadLine());
        while (n >=0){
            soma = soma +n;
            cont = cont +1;
            Console.Write("Informe um número: ");

            n = int.Parse(Console.ReadLine());
        } 

        if (cont != 0){
            double media = (double) soma / cont;
            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Média = {0:N2}", media);
        }

        else {
            Console.WriteLine("Nnehum valor positivo informado");
        }
    
    }
}