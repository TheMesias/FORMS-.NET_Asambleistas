
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
            this.pboton = new System.Windows.Forms.Panel();
            this.btninformacion = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pccandidato = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cartafront1.SuspendLayout();
            this.pboton.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // cartafront1
            // 
            this.cartafront1.Controls.Add(this.pboton);
            this.cartafront1.Controls.Add(this.txtnombre);
            this.cartafront1.Controls.Add(this.flowLayoutPanel1);
            this.cartafront1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartafront1.Location = new System.Drawing.Point(0, 0);
            this.cartafront1.Margin = new System.Windows.Forms.Padding(4);
            this.cartafront1.Name = "cartafront1";
            this.cartafront1.Size = new System.Drawing.Size(243, 242);
            this.cartafront1.TabIndex = 0;
            // 
            // pboton
            // 
            this.pboton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pboton.Controls.Add(this.btninformacion);
            this.pboton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboton.Location = new System.Drawing.Point(0, 191);
            this.pboton.Margin = new System.Windows.Forms.Padding(4);
            this.pboton.Name = "pboton";
            this.pboton.Size = new System.Drawing.Size(243, 51);
            this.pboton.TabIndex = 2;
            // 
            // btninformacion
            // 
            this.btninformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btninformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninformacion.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformacion.ForeColor = System.Drawing.Color.White;
            this.btninformacion.Location = new System.Drawing.Point(55, 8);
            this.btninformacion.Margin = new System.Windows.Forms.Padding(4);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(137, 32);
            this.btninformacion.TabIndex = 0;
            this.btninformacion.Text = "Info";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.Controls.Add(this.pccandidato);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 167);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pccandidato
            // 
            this.pccandidato.Location = new System.Drawing.Point(6, 6);
            this.pccandidato.Margin = new System.Windows.Forms.Padding(0);
            this.pccandidato.Name = "pccandidato";
            this.pccandidato.Size = new System.Drawing.Size(232, 154);
            this.pccandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pccandidato.TabIndex = 0;
            this.pccandidato.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(0, 167);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(243, 24);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cartafront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 242);
            this.Controls.Add(this.cartafront1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cartafront";
            this.Text = "Cartafront";
            this.cartafront1.ResumeLayout(false);
            this.cartafront1.PerformLayout();
            this.pboton.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pccandidato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartafront1;
        private System.Windows.Forms.Panel pboton;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pccandidato;
        private System.Windows.Forms.TextBox txtnombre;
    }
}