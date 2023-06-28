using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estevão_Bresolin
{
    public class Fracao
    {
        private int numerador1;
        private int numerador2;
        private int denominador1;
        private int denominador2;
        private Operacao operacao;

        public int Numerador1
        {
            get { return numerador1; }
            set { numerador1 = value; }
        }

        public int Numerador2
        {
            get { return numerador2; }
            set { numerador2 = value; }
        }

        public int Denominador1
        {
            get { return denominador1; }
            set { denominador1 = value; }
        }

        public int Denominador2
        {
            get { return denominador2; }
            set { denominador2 = value; }
        }

        public enum Operacao
        {
            soma = 1,
            subtrair = 2,
            divisao = 4,
            multiplicacao = 3
        }
    }
}
