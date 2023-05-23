using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Peso peso = new Peso();
            pbMercurio.Visible = false;
            pbMarte.Visible = false;
            pbSaturno.Visible = false;
            pbVenus.Visible = false;
            pbJupiter.Visible = false;
            pbUrano.Visible = false;
            int planeta = 0;
            int pesoTerra = int.Parse(txtPeso.Text);
            if (rbnMercurio.Checked) { planeta = 1; pbMercurio.Visible = true; }
            if (rbnMarte.Checked) { planeta = 2; pbMarte.Visible = true; }
            if(rbnSaturno.Checked) {planeta = 3; pbSaturno.Visible = true; }
            if(rbnVenus.Checked) { planeta = 4; pbVenus.Visible = true; }
            if(rbnJupiter.Checked) { planeta = 5; pbJupiter.Visible = true; }
            if(rbnUrano.Checked) { planeta = 6; pbUrano.Visible = true; }

            txtResultado.Text =("O Peso é: "+peso.CalculaPeso(planeta,pesoTerra));
        }

      
    }
}
