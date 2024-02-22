using System; 

class Program {
    public static void Main (string[] args){
// Chamando a função Soma
    int soma = Soma(3,4);
    Console.WriteLine("Soma = {0}", soma);

    }  

// Definindo a função soma de dois números inteiros
    public static int Soma(int n1, int n2) {
        int s = n1 + n2;
        return s;

    }
}