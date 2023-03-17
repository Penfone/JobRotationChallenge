using System;
using System.Collections.Generic;
using System.Text;

namespace JobRotationChallenge
{
    class Percentual
    {
        public void CalculaPercentual()
        {
            float SP, RJ, MG, ES, Outros, Total;

            SP = 67836.43f;
            RJ = 36678.66f;
            MG = 29229.88f;
            ES = 27165.48f;
            Outros = 19849.53f;
            Total = SP + RJ + MG + ES + Outros;

            SP = (SP / Total)*100;
            RJ = (RJ / Total)*100;
            MG = (MG / Total)*100;
            ES = (ES / Total)*100;
            Outros = (Outros / Total)*100;

            Console.WriteLine("Percentual por estado:\nSP: "+SP+ "%\nRJ: " + RJ + "%\nMG: " + MG + "%\nES: " + ES + "%\nOutros:"+Outros);
        }
    }
}
