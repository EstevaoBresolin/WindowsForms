using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UnitConverter
    {
        private double valor;
        private UnidadeMedida medida;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public enum UnidadeMedida
        {
            Temperatura = 1,
            Comprimento = 2,
            Peso = 3
            
        }
    }
}
