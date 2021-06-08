using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asambleistas
{
    public partial class Cartapost : Form
    {
        private string imagen, nombre, partido, provincia, descripcion;
        public Cartapost(string imagen, string nombre, string partido, string provincia, string descripcion)
        {
            InitializeComponent();
            txtpartido.Text = partido;
            txtprovincia.Text = provincia;
            txtdescripcion.Text = descripcion;
            this.imagen = imagen;
            this.nombre = nombre;
            this.partido = partido;
            this.provincia = provincia;
            this.descripcion = descripcion;
        }

        private void pbcerrar_Click(object sender, EventArgs e)
        {
            showForm(new Cartafront(imagen, nombre, partido, provincia, descripcion));
        }
        private void showForm(object formShow)
        {
            if (this.pcartapost.Controls.Count > 0)
            {
                this.pcartapost.Controls.Clear();
            }
            Form fh = formShow as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pcartapost.Controls.Add(fh);
            this.pcartapost.Tag = fh;
            fh.Show();
        }
    }
}
