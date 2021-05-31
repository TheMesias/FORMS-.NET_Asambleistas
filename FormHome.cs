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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btn_Descripcion_Click(object sender, EventArgs e)
        {
            FormDescripcion Descripcion = new FormDescripcion();
            Descripcion.ShowDialog(); 
        }
    }
}
