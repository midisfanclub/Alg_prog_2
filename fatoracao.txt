namespace aula_1;

class Program
{
    static void Main(string[] args)
    {
        //fatorial de 5 = 5 * 4 * 3 * 2 * 1

        int fat = Fatorial(5);
        Console.WriteLine(fat);
    }

    public static int Fatorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Fatorial(n-1);
    }
    
}
