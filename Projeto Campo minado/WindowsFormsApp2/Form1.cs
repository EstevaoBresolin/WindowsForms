using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btnReiniciar : Form
    {
        Button[,] matButton; // matriz do botões interface
        int[,] matJogo; // matriz do jogo
        int tamanhoTabuleiro = 10;
        int bombas = 20;

        public btnReiniciar()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e) // Cria a matriz da interface e do jogo
        {
            matButton = new Button[tamanhoTabuleiro, tamanhoTabuleiro];
            matJogo = new int[tamanhoTabuleiro, tamanhoTabuleiro];

            for (int i = 0; i < tamanhoTabuleiro; i++)
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    matButton[i, j] = new Button();
                    this.Controls.Add(matButton[i, j]);
                    matButton[i, j].Location = new Point(j * 40, i * 40);
                    matButton[i, j].Size = new Size(40, 40);
                    matButton[i, j].Name = "btn" + i.ToString() + "_" + j.ToString();
                    matButton[i, j].Click += new EventHandler(Botao_Clicado);
                    matButton[i, j].MouseUp += new MouseEventHandler(Botao_MouseUp);

                }
            }

            PosicionarBombas();
        }

        private void Botao_Clicado(object sender, EventArgs e) // identifica o botão clicado
        {
            Button btn = (Button)sender;
            string[] indices = btn.Name.Substring(3).Split('_'); // vai no nome do botao para descobrir o indice
            int posx = int.Parse(indices[0]);
            int posy = int.Parse(indices[1]);

            if (matJogo[posx, posy] == -1) // testa se possui uma bomba no botão clicado
            {

                for (int i = 0; i < tamanhoTabuleiro; i++) // testa todas as casas para saber se possui bomba
                {
                    for (int j = 0; j < tamanhoTabuleiro; j++)
                    {
                        if (matJogo[i, j] == -1) // possui uma bomba
                        {
                            matButton[i, j].Text = "B"; // muda o texto pra B de bomba
                            imgBomba.Visible = true; // foto bomba fica visivel

                        }
                        else
                        {
                            int bombasAdjacentes = ContarBombasAdjacentes(i, j); // contas as bombas que tem em volta
                            if (bombasAdjacentes > 0)
                            {
                                matButton[i, j].Text = bombasAdjacentes.ToString(); // Define o numero do bombas em volta
                            }
                        }
                    }
                }


                foreach (Button button in matButton) // Desativa todos os botões porque acabou
                {
                    button.Enabled = false;
                }


            }
            else if (matJogo[posx, posy] == 0) // Não tem bomba em volta
            {
                AbrirCasasVazias(posx, posy);
            }
            else // tem bomba em volta
            {
                matButton[posx, posy].Text = matJogo[posx, posy].ToString();
                matButton[posx, posy].Enabled = false;
            }
        }

        private void Botao_MouseUp(object sender, MouseEventArgs e) // identifica o botão clicado com o botão direito do mouse
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = (Button)sender;
                string[] indices = btn.Name.Substring(3).Split('_'); // vai no nome do botao para descobrir o indice
                int posx = int.Parse(indices[0]);
                int posy = int.Parse(indices[1]);

                if (matButton[posx, posy].Text == "")
                {
                    matButton[posx, posy].Text = "B"; // Marca como bomba
                    matButton[posx, posy].ForeColor = Color.Red;
                }
                else if (matButton[posx, posy].Text == "B")
                {
                    matButton[posx, posy].Text = ""; // Desmarca a bomba
                    matButton[posx, posy].ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void AbrirCasasVazias(int x, int y) // abre as casas vazias até ser vizinha da bomba
        {
            if (x < 0 || x >= tamanhoTabuleiro || y < 0 || y >= tamanhoTabuleiro || !matButton[x, y].Enabled)
                return;

            matButton[x, y].Enabled = false;

            if (matJogo[x, y] != 0)
            {
                matButton[x, y].Text = matJogo[x, y].ToString();
                return;
            }

            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 }; // casas em volta do botão clicado
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < tamanhoTabuleiro && ny >= 0 && ny < tamanhoTabuleiro)
                {
                    AbrirCasasVazias(nx, ny);
                }
            }
        }

        private void PosicionarBombas() // adiciona as bombas em lugares aleatorios
        {
            Random random = new Random();


            for (int i = 0; i < bombas; i++)
            {
                int x = random.Next(0, tamanhoTabuleiro);
                int y = random.Next(0, tamanhoTabuleiro);

                if (matJogo[x, y] == -1)
                {
                    i--;
                }
                else
                {
                    matJogo[x, y] = -1; // defini como -1 onde tem bomba
                }
            }


            for (int i = 0; i < tamanhoTabuleiro; i++) // define os números para as casas vizinhas das bombas
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    if (matJogo[i, j] != -1)
                    {
                        matJogo[i, j] = ContarBombasAdjacentes(i, j);
                    }
                }
            }
        }

        private int ContarBombasAdjacentes(int x, int y) // conta quantas bombas tem em volta
        {
            int count = 0;

            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < tamanhoTabuleiro && ny >= 0 && ny < tamanhoTabuleiro && matJogo[nx, ny] == -1)
                {
                    count++;
                }
            }

            return count;
        }

        private void ReiniciarJogo() // reinicia o jogo
        {

            for (int i = 0; i < tamanhoTabuleiro; i++)
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    this.Controls.Remove(matButton[i, j]); // remove os botões do jogo anterior 
                }
            }


            matButton = new Button[tamanhoTabuleiro, tamanhoTabuleiro]; // recria a matriz interface
            matJogo = new int[tamanhoTabuleiro, tamanhoTabuleiro]; // recria a matriz do jogo


            for (int i = 0; i < tamanhoTabuleiro; i++)
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    matButton[i, j] = new Button(); // Recriar os botões com as mesmos padrões
                    this.Controls.Add(matButton[i, j]);
                    matButton[i, j].Location = new Point(j * 40, i * 40);
                    matButton[i, j].Size = new Size(40, 40);
                    matButton[i, j].Name = "btn" + i.ToString() + "_" + j.ToString();
                    matButton[i, j].Click += new EventHandler(Botao_Clicado);
                    matButton[i, j].MouseUp += new MouseEventHandler(Botao_MouseUp);
                }
            }
            imgBomba.Visible = false; // desativa a imagem da bomba
            PosicionarBombas();
        }

        private void btmReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarJogo(); // botão para reiniciar
        }
    }
}