using System; 

class Program {

    public static void Main (string[] args) {
    double x = 10;
    double y = 8; 
// Chamando a função Maior 
    double m = Maior(x, y);
    Console.WriteLine("Maior = {0}", m);

    }
// Criando desvio condicional dentro de uma função (Maior)
    public static double Maior (double a, double b) {
        double m;
        if ( a >= b){
            m = a;
        }
        else {
            m = b;
        }
        return m;
        }
    }

