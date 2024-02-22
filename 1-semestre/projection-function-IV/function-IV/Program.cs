using System; 

class Program{

    public static void Main (string[] args){
    Console.WriteLine("Número: "); 
    int numero = int.Parse(Console.ReadLine());
    int soma = Soma1aN(numero);
    Console.WriteLine("Soma de 1 a {0} = {1}", numero, soma);

    }


// Criando uma função com estrutura de repetição laço for
    public static int Soma1aN (int n){
        int soma = 0;
        for (int cont = 1; cont <= n; cont ++){
            soma = soma + cont;
        }
        return soma; 
    }

}