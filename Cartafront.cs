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
        private string partido, provincia, descripcion;
        public Cartafront(string imagen, string nombre, string partido, string provincia, string descripcion)
        {
            InitializeComponent();
            pccandidato.WaitOnLoad = false;
            pccandidato.LoadAsync(imagen);
            textBox1.Text = nombre;
            this.partido = partido;
            this.provincia = provincia;
            this.descripcion = descripcion;
        }
    }
}
