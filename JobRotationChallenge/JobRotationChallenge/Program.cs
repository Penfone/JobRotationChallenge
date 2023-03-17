using System;

namespace JobRotationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            string continua;

            while (escolha == 0)
            {
                Console.WriteLine("Escolha um dos desafios para executar:\n\n");
                Console.WriteLine("1-Sequencia de Fibonacchi.\n2-Distribuidora.\n3-Pencentual por estado.\n4-Inverte String.\n");
                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Fibonacchi Fibo = new Fibonacchi();

                    Fibo.Sequencia();

                }
                else if (escolha == 2)
                {
                    DistribuidoraJson Json = new DistribuidoraJson();

                    Json.Faturamento();
                }
                else if (escolha == 3)
                {
                    Percentual Perc = new Percentual();

                    Perc.CalculaPercentual();
                }
                else if (escolha == 4)
                {
                    InverteString InvS = new InverteString();

                    InvS.Inversor();
                }

                Console.WriteLine("\nGostaria de continuar? [S/N]");
                continua = Console.ReadLine();

                escolha = continua == "S" || continua == "s" ? escolha = 0 : escolha  = 5;

                Console.Clear();
            }

            Console.ReadKey();

        }
    }
}
