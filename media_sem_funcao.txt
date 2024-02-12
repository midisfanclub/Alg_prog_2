namespace aula_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Infome a primeira nota: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Segunda nota: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Terceira nota: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        string sit = "";
        if (media >= 6) 
        {
            sit = "Aprovado!";
        } 
        else 
        {
            sit = "Reprovado";
        }

        Console.WriteLine($"Sua média é {media}");
        Console.WriteLine($"Situação: {sit}");

    }


    
}
