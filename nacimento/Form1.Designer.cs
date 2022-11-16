namespace nacimento
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
            this.lbllabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbtverificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllabel
            // 
            this.lbllabel.AutoSize = true;
            this.lbllabel.Location = new System.Drawing.Point(12, 109);
            this.lbllabel.Name = "lbllabel";
            this.lbllabel.Size = new System.Drawing.Size(82, 13);
            this.lbllabel.TabIndex = 0;
            this.lbllabel.Text = "ano que naceu:";
            this.lbllabel.Click += new System.EventHandler(this.lbllabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cbtverificar
            // 
            this.cbtverificar.Location = new System.Drawing.Point(13, 152);
            this.cbtverificar.Name = "cbtverificar";
            this.cbtverificar.Size = new System.Drawing.Size(75, 23);
            this.cbtverificar.TabIndex = 2;
            this.cbtverificar.Text = "verificar";
            this.cbtverificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 188);
            this.Controls.Add(this.cbtverificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbllabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cbtverificar;
    }
}

