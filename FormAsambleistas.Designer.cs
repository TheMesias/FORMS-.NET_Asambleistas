
namespace Asambleistas
{
    partial class FormAsambleistas
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
            this.panel_infoPartido = new System.Windows.Forms.Panel();
            this.txt_infoPartido = new System.Windows.Forms.TextBox();
            this.pbx_infoPartido = new System.Windows.Forms.PictureBox();
            this.pasambleistas = new System.Windows.Forms.Panel();
            this.panel_infoPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_infoPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_infoPartido
            // 
            this.panel_infoPartido.Controls.Add(this.txt_infoPartido);
            this.panel_infoPartido.Controls.Add(this.pbx_infoPartido);
            this.panel_infoPartido.Location = new System.Drawing.Point(6, 12);
            this.panel_infoPartido.Name = "panel_infoPartido";
            this.panel_infoPartido.Size = new System.Drawing.Size(782, 215);
            this.panel_infoPartido.TabIndex = 2;
            // 
            // txt_infoPartido
            // 
            this.txt_infoPartido.BackColor = System.Drawing.Color.White;
            this.txt_infoPartido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_infoPartido.Enabled = false;
            this.txt_infoPartido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_infoPartido.Location = new System.Drawing.Point(239, 25);
            this.txt_infoPartido.Multiline = true;
            this.txt_infoPartido.Name = "txt_infoPartido";
            this.txt_infoPartido.Size = new System.Drawing.Size(529, 162);
            this.txt_infoPartido.TabIndex = 1;
            // 
            // pbx_infoPartido
            // 
            this.pbx_infoPartido.Location = new System.Drawing.Point(42, 10);
            this.pbx_infoPartido.Name = "pbx_infoPartido";
            this.pbx_infoPartido.Size = new System.Drawing.Size(178, 194);
            this.pbx_infoPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_infoPartido.TabIndex = 0;
            this.pbx_infoPartido.TabStop = false;
            // 
            // pasambleistas
            // 
            this.pasambleistas.AutoScroll = true;
            this.pasambleistas.Location = new System.Drawing.Point(6, 233);
            this.pasambleistas.Name = "pasambleistas";
            this.pasambleistas.Size = new System.Drawing.Size(782, 423);
            this.pasambleistas.TabIndex = 3;
            // 
            // FormAsambleistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.pasambleistas);
            this.Controls.Add(this.panel_infoPartido);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAsambleistas";
            this.Text = "FormAsambleistas";
            this.panel_infoPartido.ResumeLayout(false);
            this.panel_infoPartido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_infoPartido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_infoPartido;
        private System.Windows.Forms.TextBox txt_infoPartido;
        private System.Windows.Forms.PictureBox pbx_infoPartido;
        private System.Windows.Forms.Panel pasambleistas;
    }
}