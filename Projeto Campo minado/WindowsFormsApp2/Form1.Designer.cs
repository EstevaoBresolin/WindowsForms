namespace WindowsFormsApp2
{
    partial class btnReiniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnReiniciar));
            this.btmReiniciar = new System.Windows.Forms.Button();
            this.imgBomba = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBomba)).BeginInit();
            this.SuspendLayout();
            // 
            // btmReiniciar
            // 
            this.btmReiniciar.Location = new System.Drawing.Point(464, 101);
            this.btmReiniciar.Name = "btmReiniciar";
            this.btmReiniciar.Size = new System.Drawing.Size(205, 38);
            this.btmReiniciar.TabIndex = 0;
            this.btmReiniciar.Text = "Reiniciar Jogo";
            this.btmReiniciar.UseVisualStyleBackColor = true;
            this.btmReiniciar.Click += new System.EventHandler(this.btmReiniciar_Click);
            // 
            // imgBomba
            // 
            this.imgBomba.Image = ((System.Drawing.Image)(resources.GetObject("imgBomba.Image")));
            this.imgBomba.Location = new System.Drawing.Point(464, 159);
            this.imgBomba.Name = "imgBomba";
            this.imgBomba.Size = new System.Drawing.Size(205, 218);
            this.imgBomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBomba.TabIndex = 2;
            this.imgBomba.TabStop = false;
            this.imgBomba.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Campo Minado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estevão Bresolin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "28291671";
            // 
            // btnReiniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBomba);
            this.Controls.Add(this.btmReiniciar);
            this.Name = "btnReiniciar";
            this.Text = "Reiniciar";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.imgBomba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmReiniciar;
        private System.Windows.Forms.PictureBox imgBomba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

