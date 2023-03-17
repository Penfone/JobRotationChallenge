using System;
using System.Collections.Generic;
using System.Text;

namespace JobRotationChallenge
{
    class InverteString
    {
        public void Inversor()
        {
            string palavra;

            Console.WriteLine("Escreva a palavra que deseja inverter:");
            palavra = Console.ReadLine();

            string arvalap = palavra;

            if (palavra.Length > 1)
            {
                arvalap = String.Empty;

                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    arvalap += palavra[i];
                }
            }

            Console.WriteLine(arvalap);
        }
    }
}
