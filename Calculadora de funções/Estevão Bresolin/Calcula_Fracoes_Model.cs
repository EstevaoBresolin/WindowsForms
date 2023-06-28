using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estevão_Bresolin
{
    public class Calcula_Fracoes_Model
    {
        private int resultadoNumerador;
        private int resultadoDenominador;

        public int CalcularNumerador(int numerador1, int numerador2, int denominador1, int denominador2, int operacao)
        {
            if (operacao == 1)
            {
                int fracao1 = ((denominador1 * denominador2) / denominador1) * numerador1;
                int fracao2 = ((denominador1 * denominador2) / denominador2) * numerador2;
                resultadoNumerador = fracao1 + fracao2;
            }
            else if (operacao == 2)
            {
                int fracao1 = ((denominador1 * denominador2) / denominador1) * numerador1;
                int fracao2 = ((denominador1 * denominador2) / denominador2) * numerador2;
                resultadoNumerador = fracao2 - fracao1;

            }
            else if (operacao == 3)
            {
                resultadoNumerador = numerador1 * numerador2;

            }
            else if (operacao == 4)
            {
                int numeradorInvertido = denominador2;
                int denominadorInvertido = numerador2;
                resultadoNumerador = numerador1 * numeradorInvertido;

            }
            return resultadoNumerador;
        }

            public int CalcularDenominador(int numera1, int numera2, int denomina1, int denomina2, int opera)
            {
                if (opera == 1)
                {
                    resultadoDenominador = denomina1 * denomina2;

                }
                else if (opera == 2)
                {
                    resultadoDenominador = denomina2 * denomina1;

                }
                else if (opera == 3)
                {
                    resultadoDenominador = denomina1 * denomina2;

                }
                else if (opera == 4)
                {
                int numeradorInvertido = denomina2;
                int denominadorInvertido = numera2;
                resultadoDenominador = denomina1 * denominadorInvertido;
            }
                return resultadoDenominador;

            }
        
    }
}
