namespace aula_1;

class Program
{
    static void Main(string[] args)
    {
        
        float n1 = PedirNota("Informe a primeira nota: ");
        float n2 = PedirNota("Informe a segunda nota: ");
        float n3 = PedirNota("Informe a terceira nota: ");

        float media = CalcularMedia(n1, n2, n3);

        string sit = Situacao(media);
       
        Escrever($"Sua média é {media,0:N1}");
        Escrever($"Situação: {sit}");

    }

    public static void Escrever(string msg)
    {
        Console.WriteLine(msg);
    }

    public static float PedirNota(string msg) 
    {
       Console.WriteLine(msg);
       float n = Convert.ToSingle(Console.ReadLine());

       return n;
    }


    public static float CalcularMedia(float n1, float n2, float n3)
    {
        float m = (n1 + n2 + n3) / 3;

        return m;
    }


    public static string Situacao(float media)
    {
        string sit = "";
        if (media >= 6)
        {
            sit = "Aprovado!"; 
        }
        else
        {
            sit = "Reprovado";
        }

        return sit;
    }
    
}
       


