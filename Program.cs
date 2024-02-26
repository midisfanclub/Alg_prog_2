namespace aula_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("##CALCULADORA##\n\n");

        Calculadora calc = new Calculadora();
        
        int opcao = 0;

        do
        {
            opcao = Calculadora.Menu();
            
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
                    resultado = calc.Somar(n1, n2);
                    break;

                case 2:
                    resultado = calc.Subtrair(n1, n2);
                    break;

                case 3:
                    resultado = calc.Multiplicar(n1, n2);
                    break;

                case 4:
                    resultado = calc.Dividir(n1, n2);
                    break;
            }

            Console.WriteLine("\nresultado: " + resultado);
        
        } while (opcao != 0);
    }


}
