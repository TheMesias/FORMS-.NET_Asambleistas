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
    public partial class FormDirectiva : Form
    {
        public FormDirectiva()
        {
            InitializeComponent();
            cargarDatos(); 
        }
        
        public void cargarDatos() {
            ClDatos datos = new ClDatos();
            string[,] matriz;
            matriz = datos.directivaPrincipal();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    if (i == 0) {
                        lbl_nPresidenta.Text = matriz[i, 0];
                        lbl_pPresidenta.Text = matriz[i, 1];
                        lbl_proPresidenta.Text = matriz[i, 2];
                        lbl_dPresidenta.Text = matriz[i, 3];

                    }
                }
            }
        }

        private void BtnInfoPresi_Click(object sender, EventArgs e)
        {
            CAtrasPresidenta.Visible = true; 
        }

        private void BtnRegresarPresidenta_Click(object sender, EventArgs e)
        {
            CAtrasPresidenta.Visible = false; 
        }
    }
}
