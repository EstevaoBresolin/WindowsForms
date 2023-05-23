using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTsoura
{
    public class Jogo
    {
        public string Jogar(int jogada)
        {
            // 1 = Pedra
            // 2 = Papel
            // 3 = Tesoura
            Random random = new Random();
            int jogadaComputador = random.Next(1,4);
            if (jogada == jogadaComputador)
                return "empate";
            else if ((jogada == 1 && jogadaComputador == 3) ||
                     (jogada == 2 && jogadaComputador == 1) ||
                     (jogada == 3 && jogadaComputador == 2))
                return "Você venceu";
            else { return "Computador Venceu";}


        }
    }
}
