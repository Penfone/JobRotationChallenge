using System;
using System.Collections.Generic;
using System.Text;

namespace JobRotationChallenge
{
    class Fibonacchi
    {
        public void Sequencia()
        {
            int a = 0; 
            int b = 1;
            int c = 0;
            int Entrada = 0;

            Console.WriteLine("Informe um número: ");
            Entrada = Convert.ToInt32(Console.ReadLine());

            while (c < Entrada)
            {
                c = a + b;

                if (c > Entrada)
                {
                    Console.WriteLine("Seu numero não está na sequencia de Fibonacci");

                    break;
                }
                else if (c == Entrada)
                {
                    Console.WriteLine("Seu numero está na sequencia de Fibonacci");

                    break;

                }

                a = b;
                b = c;
            }
        }
    }
}
