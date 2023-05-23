using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso
{
    public class Peso
    {
        public double CalculaPeso(int planeta,int peso)
        {
            double resultado= 0.0;
            if (planeta == 1)
            {
                resultado = peso * 0.37;
            }
            else if (planeta == 2)
            {
                resultado = peso * 0.38;
            }
            else if (planeta == 3)
            {
                resultado = peso * 1.15;
            }
            else if (planeta == 4)
            {
                resultado = (peso / 10) * 0.88;
            }
            else if (planeta == 5)
            {
                resultado = peso * 2.64;
            }
            else if (planeta == 6)
            {
                resultado = peso * 1.17;
            }
            else { resultado = peso; }
            return resultado;
        }
    }
}
