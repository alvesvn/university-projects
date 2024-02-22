using System; 

class Program{ public static void Main (string[] args){ 
    Console.Write("Informe um número e visualize a tabuada:");
    int n = int.Parse(Console.ReadLine());
    for (int cont = 1; cont <= 10; cont++){
        int r = n * cont;
        Console.WriteLine("{0} x {1} = {2}", n, cont, r);

    }
  } 
}