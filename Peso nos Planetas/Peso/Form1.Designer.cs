namespace Peso
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbnMercurio = new System.Windows.Forms.RadioButton();
            this.rbnMarte = new System.Windows.Forms.RadioButton();
            this.rbnSaturno = new System.Windows.Forms.RadioButton();
            this.rbnVenus = new System.Windows.Forms.RadioButton();
            this.rbnJupiter = new System.Windows.Forms.RadioButton();
            this.rbnUrano = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.pbMercurio = new System.Windows.Forms.PictureBox();
            this.pbMarte = new System.Windows.Forms.PictureBox();
            this.pbSaturno = new System.Windows.Forms.PictureBox();
            this.pbVenus = new System.Windows.Forms.PictureBox();
            this.pbJupiter = new System.Windows.Forms.PictureBox();
            this.pbUrano = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMercurio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJupiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrano)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(236, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 22);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Peso";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbnMercurio
            // 
            this.rbnMercurio.AutoSize = true;
            this.rbnMercurio.Location = new System.Drawing.Point(130, 147);
            this.rbnMercurio.Name = "rbnMercurio";
            this.rbnMercurio.Size = new System.Drawing.Size(66, 17);
            this.rbnMercurio.TabIndex = 1;
            this.rbnMercurio.TabStop = true;
            this.rbnMercurio.Text = "Mercúrio";
            this.rbnMercurio.UseVisualStyleBackColor = true;
            // 
            // rbnMarte
            // 
            this.rbnMarte.AutoSize = true;
            this.rbnMarte.Location = new System.Drawing.Point(202, 147);
            this.rbnMarte.Name = "rbnMarte";
            this.rbnMarte.Size = new System.Drawing.Size(52, 17);
            this.rbnMarte.TabIndex = 2;
            this.rbnMarte.TabStop = true;
            this.rbnMarte.Text = "Marte";
            this.rbnMarte.UseVisualStyleBackColor = true;
            // 
            // rbnSaturno
            // 
            this.rbnSaturno.AutoSize = true;
            this.rbnSaturno.Location = new System.Drawing.Point(260, 147);
            this.rbnSaturno.Name = "rbnSaturno";
            this.rbnSaturno.Size = new System.Drawing.Size(62, 17);
            this.rbnSaturno.TabIndex = 3;
            this.rbnSaturno.TabStop = true;
            this.rbnSaturno.Text = "Saturno";
            this.rbnSaturno.UseVisualStyleBackColor = true;
            // 
            // rbnVenus
            // 
            this.rbnVenus.AutoSize = true;
            this.rbnVenus.Location = new System.Drawing.Point(130, 180);
            this.rbnVenus.Name = "rbnVenus";
            this.rbnVenus.Size = new System.Drawing.Size(55, 17);
            this.rbnVenus.TabIndex = 4;
            this.rbnVenus.TabStop = true;
            this.rbnVenus.Text = "Vênus";
            this.rbnVenus.UseVisualStyleBackColor = true;
            // 
            // rbnJupiter
            // 
            this.rbnJupiter.AutoSize = true;
            this.rbnJupiter.Location = new System.Drawing.Point(202, 180);
            this.rbnJupiter.Name = "rbnJupiter";
            this.rbnJupiter.Size = new System.Drawing.Size(56, 17);
            this.rbnJupiter.TabIndex = 5;
            this.rbnJupiter.TabStop = true;
            this.rbnJupiter.Text = "Júpiter";
            this.rbnJupiter.UseVisualStyleBackColor = true;
            // 
            // rbnUrano
            // 
            this.rbnUrano.AutoSize = true;
            this.rbnUrano.Location = new System.Drawing.Point(260, 180);
            this.rbnUrano.Name = "rbnUrano";
            this.rbnUrano.Size = new System.Drawing.Size(54, 17);
            this.rbnUrano.TabIndex = 6;
            this.rbnUrano.TabStop = true;
            this.rbnUrano.Text = "Urano";
            this.rbnUrano.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Peso na Terra(Kg):";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(130, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(465, 65);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 13);
            this.txtResultado.TabIndex = 9;
            // 
            // pbMercurio
            // 
            this.pbMercurio.Image = ((System.Drawing.Image)(resources.GetObject("pbMercurio.Image")));
            this.pbMercurio.Location = new System.Drawing.Point(402, 92);
            this.pbMercurio.Name = "pbMercurio";
            this.pbMercurio.Size = new System.Drawing.Size(259, 159);
            this.pbMercurio.TabIndex = 10;
            this.pbMercurio.TabStop = false;
            this.pbMercurio.Visible = false;
            // 
            // pbMarte
            // 
            this.pbMarte.Image = ((System.Drawing.Image)(resources.GetObject("pbMarte.Image")));
            this.pbMarte.Location = new System.Drawing.Point(402, 92);
            this.pbMarte.Name = "pbMarte";
            this.pbMarte.Size = new System.Drawing.Size(246, 145);
            this.pbMarte.TabIndex = 11;
            this.pbMarte.TabStop = false;
            this.pbMarte.Visible = false;
            // 
            // pbSaturno
            // 
            this.pbSaturno.Image = ((System.Drawing.Image)(resources.GetObject("pbSaturno.Image")));
            this.pbSaturno.Location = new System.Drawing.Point(437, 103);
            this.pbSaturno.Name = "pbSaturno";
            this.pbSaturno.Size = new System.Drawing.Size(211, 118);
            this.pbSaturno.TabIndex = 12;
            this.pbSaturno.TabStop = false;
            this.pbSaturno.Visible = false;
            // 
            // pbVenus
            // 
            this.pbVenus.Image = ((System.Drawing.Image)(resources.GetObject("pbVenus.Image")));
            this.pbVenus.Location = new System.Drawing.Point(402, 92);
            this.pbVenus.Name = "pbVenus";
            this.pbVenus.Size = new System.Drawing.Size(246, 170);
            this.pbVenus.TabIndex = 13;
            this.pbVenus.TabStop = false;
            this.pbVenus.Visible = false;
            // 
            // pbJupiter
            // 
            this.pbJupiter.Image = ((System.Drawing.Image)(resources.GetObject("pbJupiter.Image")));
            this.pbJupiter.Location = new System.Drawing.Point(402, 92);
            this.pbJupiter.Name = "pbJupiter";
            this.pbJupiter.Size = new System.Drawing.Size(259, 159);
            this.pbJupiter.TabIndex = 14;
            this.pbJupiter.TabStop = false;
            this.pbJupiter.Visible = false;
            // 
            // pbUrano
            // 
            this.pbUrano.Image = ((System.Drawing.Image)(resources.GetObject("pbUrano.Image")));
            this.pbUrano.Location = new System.Drawing.Point(437, 106);
            this.pbUrano.Name = "pbUrano";
            this.pbUrano.Size = new System.Drawing.Size(189, 145);
            this.pbUrano.TabIndex = 15;
            this.pbUrano.TabStop = false;
            this.pbUrano.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 318);
            this.Controls.Add(this.pbUrano);
            this.Controls.Add(this.pbJupiter);
            this.Controls.Add(this.pbVenus);
            this.Controls.Add(this.pbSaturno);
            this.Controls.Add(this.pbMarte);
            this.Controls.Add(this.pbMercurio);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnUrano);
            this.Controls.Add(this.rbnJupiter);
            this.Controls.Add(this.rbnVenus);
            this.Controls.Add(this.rbnSaturno);
            this.Controls.Add(this.rbnMarte);
            this.Controls.Add(this.rbnMercurio);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMercurio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJupiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbnMercurio;
        private System.Windows.Forms.RadioButton rbnMarte;
        private System.Windows.Forms.RadioButton rbnSaturno;
        private System.Windows.Forms.RadioButton rbnVenus;
        private System.Windows.Forms.RadioButton rbnJupiter;
        private System.Windows.Forms.RadioButton rbnUrano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.PictureBox pbMercurio;
        private System.Windows.Forms.PictureBox pbMarte;
        private System.Windows.Forms.PictureBox pbSaturno;
        private System.Windows.Forms.PictureBox pbVenus;
        private System.Windows.Forms.PictureBox pbJupiter;
        private System.Windows.Forms.PictureBox pbUrano;
    }
}

