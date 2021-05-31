
namespace Asambleistas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.panel_submenu = new System.Windows.Forms.Panel();
            this.picture_socialC = new System.Windows.Forms.PictureBox();
            this.btn_socialCristiano = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_Pachakutic = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_centroDemocratico = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Creo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Directiva = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel_Lateral.SuspendLayout();
            this.panel_submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_socialC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(34)))));
            this.panel_Superior.Controls.Add(this.btn_home);
            this.panel_Superior.Controls.Add(this.btn_cerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(1000, 30);
            this.panel_Superior.TabIndex = 0;
            this.panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseDown);
            this.panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseMove);
            this.panel_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseUp);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(972, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 24);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_Lateral
            // 
            this.panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel_Lateral.Controls.Add(this.panel_submenu);
            this.panel_Lateral.Controls.Add(this.pictureBox4);
            this.panel_Lateral.Controls.Add(this.label2);
            this.panel_Lateral.Controls.Add(this.btn_Menu);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 30);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(200, 662);
            this.panel_Lateral.TabIndex = 3;
            // 
            // panel_submenu
            // 
            this.panel_submenu.Controls.Add(this.picture_socialC);
            this.panel_submenu.Controls.Add(this.btn_socialCristiano);
            this.panel_submenu.Controls.Add(this.pictureBox7);
            this.panel_submenu.Controls.Add(this.btn_Pachakutic);
            this.panel_submenu.Controls.Add(this.pictureBox6);
            this.panel_submenu.Controls.Add(this.btn_centroDemocratico);
            this.panel_submenu.Controls.Add(this.pictureBox5);
            this.panel_submenu.Controls.Add(this.btn_Creo);
            this.panel_submenu.Controls.Add(this.pictureBox3);
            this.panel_submenu.Controls.Add(this.btn_Directiva);
            this.panel_submenu.Location = new System.Drawing.Point(0, 62);
            this.panel_submenu.Name = "panel_submenu";
            this.panel_submenu.Size = new System.Drawing.Size(200, 256);
            this.panel_submenu.TabIndex = 5;
            // 
            // picture_socialC
            // 
            this.picture_socialC.Image = ((System.Drawing.Image)(resources.GetObject("picture_socialC.Image")));
            this.picture_socialC.Location = new System.Drawing.Point(9, 218);
            this.picture_socialC.Name = "picture_socialC";
            this.picture_socialC.Size = new System.Drawing.Size(20, 20);
            this.picture_socialC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_socialC.TabIndex = 12;
            this.picture_socialC.TabStop = false;
            // 
            // btn_socialCristiano
            // 
            this.btn_socialCristiano.BackColor = System.Drawing.Color.White;
            this.btn_socialCristiano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_socialCristiano.FlatAppearance.BorderSize = 0;
            this.btn_socialCristiano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socialCristiano.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_socialCristiano.Location = new System.Drawing.Point(0, 210);
            this.btn_socialCristiano.Name = "btn_socialCristiano";
            this.btn_socialCristiano.Size = new System.Drawing.Size(200, 37);
            this.btn_socialCristiano.TabIndex = 13;
            this.btn_socialCristiano.Text = "SOCIAL CRISTIANO\r\n";
            this.btn_socialCristiano.UseVisualStyleBackColor = false;
            this.btn_socialCristiano.Click += new System.EventHandler(this.btn_socialCristiano_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(9, 165);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // btn_Pachakutic
            // 
            this.btn_Pachakutic.BackColor = System.Drawing.Color.White;
            this.btn_Pachakutic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pachakutic.FlatAppearance.BorderSize = 0;
            this.btn_Pachakutic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pachakutic.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pachakutic.Location = new System.Drawing.Point(0, 157);
            this.btn_Pachakutic.Name = "btn_Pachakutic";
            this.btn_Pachakutic.Size = new System.Drawing.Size(200, 37);
            this.btn_Pachakutic.TabIndex = 11;
            this.btn_Pachakutic.Text = "PACHAKUTIK\r\n";
            this.btn_Pachakutic.UseVisualStyleBackColor = false;
            this.btn_Pachakutic.Click += new System.EventHandler(this.btn_Pachakutic_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(9, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // btn_centroDemocratico
            // 
            this.btn_centroDemocratico.BackColor = System.Drawing.Color.White;
            this.btn_centroDemocratico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_centroDemocratico.FlatAppearance.BorderSize = 0;
            this.btn_centroDemocratico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_centroDemocratico.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_centroDemocratico.Location = new System.Drawing.Point(0, 105);
            this.btn_centroDemocratico.Name = "btn_centroDemocratico";
            this.btn_centroDemocratico.Size = new System.Drawing.Size(200, 37);
            this.btn_centroDemocratico.TabIndex = 9;
            this.btn_centroDemocratico.Text = "CENTRO DEMOCRATICO\r\n";
            this.btn_centroDemocratico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_centroDemocratico.UseVisualStyleBackColor = false;
            this.btn_centroDemocratico.Click += new System.EventHandler(this.btn_centroDemocratico_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Creo
            // 
            this.btn_Creo.BackColor = System.Drawing.Color.White;
            this.btn_Creo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Creo.FlatAppearance.BorderSize = 0;
            this.btn_Creo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Creo.Location = new System.Drawing.Point(0, 52);
            this.btn_Creo.Name = "btn_Creo";
            this.btn_Creo.Size = new System.Drawing.Size(200, 37);
            this.btn_Creo.TabIndex = 7;
            this.btn_Creo.Text = "CREO\r\n\r\n";
            this.btn_Creo.UseVisualStyleBackColor = false;
            this.btn_Creo.Click += new System.EventHandler(this.btn_Creo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Directiva
            // 
            this.btn_Directiva.BackColor = System.Drawing.Color.White;
            this.btn_Directiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Directiva.FlatAppearance.BorderSize = 0;
            this.btn_Directiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Directiva.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Directiva.Location = new System.Drawing.Point(0, 0);
            this.btn_Directiva.Name = "btn_Directiva";
            this.btn_Directiva.Size = new System.Drawing.Size(200, 37);
            this.btn_Directiva.TabIndex = 5;
            this.btn_Directiva.Text = "DIRECTIVA PRINCIPAL\r\n";
            this.btn_Directiva.UseVisualStyleBackColor = false;
            this.btn_Directiva.Click += new System.EventHandler(this.btn_Directiva_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 551);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(164, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MENU";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(12, 17);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(24, 24);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 6;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Location = new System.Drawing.Point(200, 30);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(800, 662);
            this.panel_Contenedor.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(945, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(20, 20);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_home.TabIndex = 6;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 692);
            this.Controls.Add(this.panel_Lateral);
            this.Controls.Add(this.panel_Superior);
            this.Controls.Add(this.panel_Contenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Lateral.PerformLayout();
            this.panel_submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_socialC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.Panel panel_submenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Directiva;
        private System.Windows.Forms.PictureBox picture_socialC;
        private System.Windows.Forms.Button btn_socialCristiano;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_Pachakutic;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_centroDemocratico;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Creo;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.PictureBox btn_home;
    }
}

