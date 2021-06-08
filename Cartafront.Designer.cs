
namespace Asambleistas
{
    partial class Cartafront
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartafront1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pccandidato = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pboton = new System.Windows.Forms.Panel();
            this.btninformacion = new System.Windows.Forms.Button();
            this.cartafront1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccandidato)).BeginInit();
            this.pboton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartafront1
            // 
            this.cartafront1.Controls.Add(this.pboton);
            this.cartafront1.Controls.Add(this.textBox1);
            this.cartafront1.Controls.Add(this.flowLayoutPanel1);
            this.cartafront1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartafront1.Location = new System.Drawing.Point(0, 0);
            this.cartafront1.Name = "cartafront1";
            this.cartafront1.Size = new System.Drawing.Size(182, 199);
            this.cartafront1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.Controls.Add(this.pccandidato);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 136);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pccandidato
            // 
            this.pccandidato.Location = new System.Drawing.Point(3, 3);
            this.pccandidato.Name = "pccandidato";
            this.pccandidato.Size = new System.Drawing.Size(176, 125);
            this.pccandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pccandidato.TabIndex = 0;
            this.pccandidato.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pboton
            // 
            this.pboton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pboton.Controls.Add(this.btninformacion);
            this.pboton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboton.Location = new System.Drawing.Point(0, 157);
            this.pboton.Name = "pboton";
            this.pboton.Size = new System.Drawing.Size(182, 42);
            this.pboton.TabIndex = 2;
            // 
            // btninformacion
            // 
            this.btninformacion.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformacion.ForeColor = System.Drawing.Color.White;
            this.btninformacion.Location = new System.Drawing.Point(38, 9);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(103, 25);
            this.btninformacion.TabIndex = 0;
            this.btninformacion.Text = "Info";
            this.btninformacion.UseVisualStyleBackColor = true;
            // 
            // Cartafront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 199);
            this.Controls.Add(this.cartafront1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cartafront";
            this.Text = "Cartafront";
            this.cartafront1.ResumeLayout(false);
            this.cartafront1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pccandidato)).EndInit();
            this.pboton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartafront1;
        private System.Windows.Forms.Panel pboton;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pccandidato;
    }
}