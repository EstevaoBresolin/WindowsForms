using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        Triangulo triangulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            triangulo = new Triangulo();

            int Lado1 = Convert.ToInt32(txtLado1.Text);

            int Lado2 = Convert.ToInt32(txtLado2.Text);

            int Lado3 = Convert.ToInt32(txtLado3.Text);

           if(triangulo.VerificaTipo(Lado1, Lado2, Lado3) == 1)
           {
                img.Visible= true;
                imgIsosceles.Visible = false;
                imgEscaleno.Visible = false;

            }
           else if (triangulo.VerificaTipo(Lado1, Lado2, Lado3) == 2)
           {
                img.Visible= false;
               imgIsosceles.Visible= true;
                imgEscaleno.Visible = false;

           }
           else if (triangulo.VerificaTipo(Lado1, Lado2, Lado3) == 3)
            {
                imgEscaleno.Visible = true;
                img.Visible = false;
                imgIsosceles.Visible = false;
            }


        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
