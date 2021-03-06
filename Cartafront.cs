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
    public partial class Cartafront : Form
    {
        private string imagen,nombre,partido, provincia, descripcion;
        public Cartafront(string imagen, string nombre, string partido, string provincia, string descripcion)
        {
            InitializeComponent();
            pccandidato.WaitOnLoad = false;
            pccandidato.LoadAsync(imagen);
            txtnombre.Text = nombre;
            this.imagen = imagen;
            this.nombre = nombre;
            this.partido = partido;
            this.provincia = provincia;
            this.descripcion = descripcion;
        }
        private void showForm(object formShow)
        {
            if (this.cartafront1.Controls.Count > 0)
            {
                this.cartafront1.Controls.Clear();
            }
            Form fh = formShow as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.cartafront1.Controls.Add(fh);
            this.cartafront1.Tag = fh;
            fh.Show();
        }
        private void btninformacion_Click(object sender, EventArgs e)
        {
            showForm(new Cartapost(imagen, nombre, partido, provincia, descripcion));
        }
    }
}
