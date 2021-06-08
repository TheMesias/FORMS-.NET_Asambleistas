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
    public partial class FormBuscar : Form
    {
        
        public FormBuscar()
        {
            InitializeComponent();
        }
        public List<Asambleista> aux = Datos.Listado;
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TxtBusNom.Text;

            try
            {
                foreach (var asambleista in Datos.Listado)
                {

                    //Agrega los datos al dataGridview
                    dataGridView1.Rows.Add();

                    int filas = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, filas].Value = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].NombreAsambleista1;
                    dataGridView1[1, filas].Value = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Información1;
                    dataGridView1[2, filas].Value = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Provincia1;
                    dataGridView1[3, filas].Value = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Partido;
                    dataGridView1[4, filas].Value = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Imagen;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("El Asambleista no fue encontrado");

            }
        }

        private void TxtBusNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClValidar.SoloLetras(e); 
        }
    }
}
