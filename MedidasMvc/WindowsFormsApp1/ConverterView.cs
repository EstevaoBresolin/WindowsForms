using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConverterView : Form, IConverterView
    {
        UnitConverter converter;
        MedidasController controller;
        public ConverterView()
        {
            InitializeComponent();
            converter = new UnitConverter();
        }

        public void SetController( MedidasController _controller )
        {
            controller = _controller;
        }

        public string Valor 
        {
            get
            {
                return this.txtValor.Text;
            }
            set
            {
                this.txtValor.Text = value;
            }
        }

        public string Resultado
        {
            get
            {
                return this.txtResultado.Text;
            }
            set
            {
                this.txtResultado.Text = value;
            }
        }



        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            int medida = 1;
            this.controller.Converter(medida);
        }

        private void btnPolegadas_Click(object sender, EventArgs e)
        {
            int medida = 2;
            this.controller.Converter(medida);
        }

        private void btnLibras_Click(object sender, EventArgs e)
        {
            int medida = 3;
            this.controller.Converter(medida);
        }
    }
}
