namespace aula_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("##CALCULADORA##\n\n");

        int opcao = 0;

        do
        {
            Console.WriteLine("\nQual operação deseja realizar");
            Console.WriteLine("[1] Adição");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão\n");
            Console.WriteLine("[0] Sair\n");

            opcao = Convert.ToInt32(Console.ReadLine());
            
            if (opcao == 0)
            {
                break;
            }

            Console.Write("\n>> ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            
            switch (opcao)
            {
                case 1:
                    resultado = n1 + n2;
                    break;

                case 2:
                    resultado = n1 - n2;
                    break;

                case 3:
                    resultado = n1 * n2;
                    break;

                case 4:
                    resultado = n1 / n2;
                    break;
            }

            Console.WriteLine("\nresultado: " + resultado);
        
        } while (opcao != 0);
    }
}
