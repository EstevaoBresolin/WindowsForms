using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estevão_Bresolin
{
    public partial class Form1 : Form, ICalculaFracao
    {

        Fracao fracao;
        Controller controller;

        public Form1()
        {
            InitializeComponent();
            fracao = new Fracao();
        }
        public void SetController(Controller _controller)
        {
            controller = _controller;
        }


        public string Numerador1
        {
            get
            {
                return this.txtNumerador1.Text;
            }
            set
            {
                this.txtNumerador1.Text = value;
            }
        }
        public string Numerador2
        {
            get
            {
                return this.txtNumerador2.Text;
            }
            set
            {
                this.txtNumerador2.Text = value;
            }
        }
        public string Denominador1
        {
            get
            {
                return this.txtDenominador1.Text;
            }
            set
            {
                this.txtDenominador1.Text = value;
            }
        }
        public string Denominador2
        {
            get
            {
                return this.txtDenominador2.Text;
            }
            set
            {
                this.txtDenominador2.Text = value;
            }
        }
        public string ResultadoNumerador
        {
            get
            {
                return this.txtResultadoNumerador.Text;
            }
            set
            {
                this.txtResultadoNumerador.Text = value;
            }
        }
        public string ResultadoDenominador
        {
            get
            {
                return this.txtResultadoDenominador.Text;
            }
            set
            {
                this.txtResultadoDenominador.Text = value;
            }
        }


        private void txtNumerador1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int operacao = 1;
            this.controller.CalcularNumerador(operacao);
            this.controller.CalcularDenominador(operacao);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int operacao = 2;
            this.controller.CalcularNumerador(operacao);
            this.controller.CalcularDenominador(operacao);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int operacao = 4;
            this.controller.CalcularNumerador(operacao);
            this.controller.CalcularDenominador(operacao);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int operacao = 3;
            this.controller.CalcularNumerador(operacao);
            this.controller.CalcularDenominador(operacao);
        }

        private void txtResultadoNumerador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
