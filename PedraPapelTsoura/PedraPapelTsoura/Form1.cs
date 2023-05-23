using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTsoura
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            int jogada = 0;
            
            if (rbnPapel.Checked )
            {
                jogada = 2;  
            }
            else if(rbnTesoura.Checked ) 
            {
                jogada = 3;
            }
            else if (rbnPedra.Checked )
            {
                jogada = 1;
            }

            txtVencedor.Text = jogo.Jogar(jogada);
          
        }
    }
}
