namespace Triangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.imgIsosceles = new System.Windows.Forms.PictureBox();
            this.imgEscaleno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsosceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscaleno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado3";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(347, 92);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 3;
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(347, 164);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 4;
            this.txtLado3.TextChanged += new System.EventHandler(this.txtLado3_TextChanged);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(347, 129);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 5;
            this.txtLado2.TextChanged += new System.EventHandler(this.txtLado2_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(276, 215);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(171, 23);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar Tipo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(578, 136);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(0, 13);
            this.txtTipo.TabIndex = 7;
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(498, 65);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(270, 251);
            this.img.TabIndex = 8;
            this.img.TabStop = false;
            this.img.Visible = false;
            // 
            // imgIsosceles
            // 
            this.imgIsosceles.Image = ((System.Drawing.Image)(resources.GetObject("imgIsosceles.Image")));
            this.imgIsosceles.Location = new System.Drawing.Point(539, 61);
            this.imgIsosceles.Name = "imgIsosceles";
            this.imgIsosceles.Size = new System.Drawing.Size(177, 240);
            this.imgIsosceles.TabIndex = 9;
            this.imgIsosceles.TabStop = false;
            this.imgIsosceles.Visible = false;
            // 
            // imgEscaleno
            // 
            this.imgEscaleno.Image = ((System.Drawing.Image)(resources.GetObject("imgEscaleno.Image")));
            this.imgEscaleno.Location = new System.Drawing.Point(581, 83);
            this.imgEscaleno.Name = "imgEscaleno";
            this.imgEscaleno.Size = new System.Drawing.Size(207, 203);
            this.imgEscaleno.TabIndex = 10;
            this.imgEscaleno.TabStop = false;
            this.imgEscaleno.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgEscaleno);
            this.Controls.Add(this.imgIsosceles);
            this.Controls.Add(this.img);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsosceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscaleno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox imgIsosceles;
        private System.Windows.Forms.PictureBox imgEscaleno;
    }
}

