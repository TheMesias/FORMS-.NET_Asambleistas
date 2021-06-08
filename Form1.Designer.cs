
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
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.panel_submenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.picture_socialC = new System.Windows.Forms.PictureBox();
            this.btn_socialCristiano = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_Pachakutic = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_centroDemocratico = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Creo = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel_Lateral.SuspendLayout();
            this.panel_submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_socialC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel_submenu.Controls.Add(this.tableLayoutPanel1);
            this.panel_submenu.Location = new System.Drawing.Point(0, 62);
            this.panel_submenu.Name = "panel_submenu";
            this.panel_submenu.Size = new System.Drawing.Size(200, 369);
            this.panel_submenu.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 330);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buscar.Location = new System.Drawing.Point(29, 322);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(168, 37);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "BUSCAR\r\n";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(29, 267);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(168, 37);
            this.btn_Modificar.TabIndex = 17;
            this.btn_Modificar.Text = "MODIFICAR ASAMBLEISTA";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insertar.BackColor = System.Drawing.Color.White;
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertar.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_insertar.Location = new System.Drawing.Point(29, 215);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(168, 37);
            this.btn_insertar.TabIndex = 15;
            this.btn_insertar.Text = "NUEVO ASAMBLEISTA";
            this.btn_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // picture_socialC
            // 
            this.picture_socialC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_socialC.Image = ((System.Drawing.Image)(resources.GetObject("picture_socialC.Image")));
            this.picture_socialC.Location = new System.Drawing.Point(3, 172);
            this.picture_socialC.Name = "picture_socialC";
            this.picture_socialC.Size = new System.Drawing.Size(20, 20);
            this.picture_socialC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_socialC.TabIndex = 12;
            this.picture_socialC.TabStop = false;
            // 
            // btn_socialCristiano
            // 
            this.btn_socialCristiano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_socialCristiano.BackColor = System.Drawing.Color.White;
            this.btn_socialCristiano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_socialCristiano.FlatAppearance.BorderSize = 0;
            this.btn_socialCristiano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socialCristiano.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_socialCristiano.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_socialCristiano.Location = new System.Drawing.Point(29, 163);
            this.btn_socialCristiano.Name = "btn_socialCristiano";
            this.btn_socialCristiano.Size = new System.Drawing.Size(168, 37);
            this.btn_socialCristiano.TabIndex = 13;
            this.btn_socialCristiano.Text = "SOCIAL CRISTIANO\r\n";
            this.btn_socialCristiano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_socialCristiano.UseVisualStyleBackColor = false;
            this.btn_socialCristiano.Click += new System.EventHandler(this.btn_socialCristiano_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 120);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // btn_Pachakutic
            // 
            this.btn_Pachakutic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pachakutic.BackColor = System.Drawing.Color.White;
            this.btn_Pachakutic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pachakutic.FlatAppearance.BorderSize = 0;
            this.btn_Pachakutic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pachakutic.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pachakutic.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pachakutic.Location = new System.Drawing.Point(29, 111);
            this.btn_Pachakutic.Name = "btn_Pachakutic";
            this.btn_Pachakutic.Size = new System.Drawing.Size(168, 37);
            this.btn_Pachakutic.TabIndex = 11;
            this.btn_Pachakutic.Text = "PACHAKUTIK\r\n";
            this.btn_Pachakutic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pachakutic.UseVisualStyleBackColor = false;
            this.btn_Pachakutic.Click += new System.EventHandler(this.btn_Pachakutic_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 68);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // btn_centroDemocratico
            // 
            this.btn_centroDemocratico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_centroDemocratico.BackColor = System.Drawing.Color.White;
            this.btn_centroDemocratico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_centroDemocratico.FlatAppearance.BorderSize = 0;
            this.btn_centroDemocratico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_centroDemocratico.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_centroDemocratico.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_centroDemocratico.Location = new System.Drawing.Point(29, 59);
            this.btn_centroDemocratico.Name = "btn_centroDemocratico";
            this.btn_centroDemocratico.Size = new System.Drawing.Size(168, 37);
            this.btn_centroDemocratico.TabIndex = 9;
            this.btn_centroDemocratico.Text = "CENTRO DEMOCRATICO\r\n";
            this.btn_centroDemocratico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_centroDemocratico.UseVisualStyleBackColor = false;
            this.btn_centroDemocratico.Click += new System.EventHandler(this.btn_centroDemocratico_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Creo
            // 
            this.btn_Creo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Creo.BackColor = System.Drawing.Color.White;
            this.btn_Creo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Creo.FlatAppearance.BorderSize = 0;
            this.btn_Creo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creo.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Creo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Creo.Location = new System.Drawing.Point(29, 7);
            this.btn_Creo.Name = "btn_Creo";
            this.btn_Creo.Size = new System.Drawing.Size(168, 37);
            this.btn_Creo.TabIndex = 7;
            this.btn_Creo.Text = "IZQUIERDA DEMOCRATICA";
            this.btn_Creo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Creo.UseVisualStyleBackColor = false;
            this.btn_Creo.Click += new System.EventHandler(this.btn_Creo_Click);
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
            this.label2.Size = new System.Drawing.Size(54, 20);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Creo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_centroDemocratico, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_buscar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Pachakutic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_socialCristiano, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Modificar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_insertar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picture_socialC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Lateral.PerformLayout();
            this.panel_submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_socialC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

