using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MedidasModel
    {
        private double resultado;

        public double Converter(double valor, int medida)
        {
            if (medida == 1) // 1 = Fahrenheit
            {
                resultado = valor * 1.8 + 32; 
            }
            else if(medida == 2) // 2 = polegadas
            {
                resultado = valor * 39.37;
            }
            else if (medida == 3) // 3 = libras
            {
                resultado = valor * 2.205;
                
            }
            return resultado;
        }

       
    }
}
