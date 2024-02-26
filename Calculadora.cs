class Calculadora
{

public static int Menu()
    {
        Console.WriteLine("\nQual operação deseja realizar");
        Console.WriteLine("[1] Adição");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão\n");
        Console.WriteLine("[0] Sair\n");

        int opcao = Convert.ToInt32(Console.ReadLine());
        return opcao;
    }
 public double Somar(double a, double b)
    {
        return a + b;
    }

     public double Subtrair(double a, double b)
    {
        return a - b;
    }
    
     public double Multiplicar(double a, double b)
    {
        return a * b;
    }

     public double Dividir(double a, double b)
    {
        return a / b;
    }
}