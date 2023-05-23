namespace PedraPapelTsoura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPedra = new System.Windows.Forms.RadioButton();
            this.rbnPapel = new System.Windows.Forms.RadioButton();
            this.rbnTesoura = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVencedor = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTesoura);
            this.groupBox1.Controls.Add(this.rbnPapel);
            this.groupBox1.Controls.Add(this.rbnPedra);
            this.groupBox1.Location = new System.Drawing.Point(334, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbnPedra
            // 
            this.rbnPedra.AutoSize = true;
            this.rbnPedra.Location = new System.Drawing.Point(15, 26);
            this.rbnPedra.Name = "rbnPedra";
            this.rbnPedra.Size = new System.Drawing.Size(53, 17);
            this.rbnPedra.TabIndex = 0;
            this.rbnPedra.TabStop = true;
            this.rbnPedra.Text = "Pedra";
            this.rbnPedra.UseVisualStyleBackColor = true;
            // 
            // rbnPapel
            // 
            this.rbnPapel.AutoSize = true;
            this.rbnPapel.Location = new System.Drawing.Point(15, 48);
            this.rbnPapel.Name = "rbnPapel";
            this.rbnPapel.Size = new System.Drawing.Size(52, 17);
            this.rbnPapel.TabIndex = 1;
            this.rbnPapel.TabStop = true;
            this.rbnPapel.Text = "Papel";
            this.rbnPapel.UseVisualStyleBackColor = true;
            // 
            // rbnTesoura
            // 
            this.rbnTesoura.AutoSize = true;
            this.rbnTesoura.Location = new System.Drawing.Point(15, 71);
            this.rbnTesoura.Name = "rbnTesoura";
            this.rbnTesoura.Size = new System.Drawing.Size(64, 17);
            this.rbnTesoura.TabIndex = 2;
            this.rbnTesoura.TabStop = true;
            this.rbnTesoura.Text = "Tesoura";
            this.rbnTesoura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "O Vencedor foi:";
            // 
            // txtVencedor
            // 
            this.txtVencedor.AutoSize = true;
            this.txtVencedor.Location = new System.Drawing.Point(445, 160);
            this.txtVencedor.Name = "txtVencedor";
            this.txtVencedor.Size = new System.Drawing.Size(124, 13);
            this.txtVencedor.TabIndex = 2;
            this.txtVencedor.Text = "                                       ";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(448, 91);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(94, 39);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 262);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtVencedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnTesoura;
        private System.Windows.Forms.RadioButton rbnPapel;
        private System.Windows.Forms.RadioButton rbnPedra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtVencedor;
        private System.Windows.Forms.Button btnJogar;
    }
}

