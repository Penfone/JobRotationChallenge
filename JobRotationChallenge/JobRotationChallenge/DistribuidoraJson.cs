using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace JobRotationChallenge
{
    class DistribuidoraJson
    {

        public class Json
        {
            public int dia { get; set; }
            public decimal valor { get; set; }
        }
        
        public void Faturamento()
        {
            //json
            string arquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Json", "dados.json");
            decimal aux;
            string dadosJson;

            using (StreamReader reader = new StreamReader(arquivo))
            {
                dadosJson = reader.ReadToEnd();
            }

            List<Json> vet = JsonConvert.DeserializeObject<List<Json>>(dadosJson);

            //menor
            for (int i = 0; i < vet.Count; i++)
            {
                for (int j = i + 1; j < vet.Count; j++)
                {
                    if (vet[i].valor > vet[j].valor)
                    {
                        aux = vet[i].valor;
                        vet[i].valor = vet[j].valor;
                        vet[j].valor = aux;
                    }
                }
            }
            Console.WriteLine("O menor valor é:" + vet[0].valor +"\n");

            //maior
            for (int i = 0; i < vet.Count; i++)
            {
                for (int j = i + 1; j < vet.Count; j++)
                {
                    if (vet[i].valor < vet[j].valor)
                    {
                        aux = vet[i].valor;
                        vet[i].valor = vet[j].valor;
                        vet[j].valor = aux;
                    }
                }
            }
            Console.WriteLine("O maior valor é:" + vet[0].valor+"\n");

            //media
            int contador = 0;

            for (int i = 0; i < vet.Count; i++)//contador
            {
                if (vet[i].valor > 0)
                {
                    contador++;
                }
            }

            decimal[] mairZero = new decimal[contador];

            for (int i = 0; i < vet.Count; i++)//atribuir valor
            {
                if (vet[i].valor > 0)
                {
                    mairZero[i] = vet[i].valor;
                }
            }

            decimal total = 0;

            for (int i = 0; i < contador; i++)//somar
            {
                total = total + mairZero[i];
            }

            total = total / contador;

            int contadorAux = 0;

            for (int i = 0; i <contador; i++)//contador de dias acima da média
            {
                if (mairZero[i] > total)
                {
                    contadorAux++;
                }
            }

            Console.WriteLine("A média é: " + total + "\n");

            Console.WriteLine("Um total de " + contadorAux + " dias teve o faturamento acima da média.");

            //decimal[] maiorMedia = new decimal[contadorAux];

            //for (int i = 0; i < contador; i++)//valores acima da média
            //{
            //    if (media[i] > total)
            //    {
            //        maiorMedia[i] = media[i];
            //    }
            //}

            //for (int i = 0; i < contadorAux; i++)
            //{
            //    Console.WriteLine(maiorMedia[i]);
            //}

        }
    }
}
