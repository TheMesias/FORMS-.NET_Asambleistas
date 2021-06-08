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
    public partial class FormModificar : Form
    {
        int posicion;
        string nombre1, info1, provincia1, partido1, imagen1;

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtNombre.Text.Length < 30) && (TxtInfo.Text.Length < 180) && (TxtNombre.Text != "") && (TxtInfo.Text != "") && (TxtPartido.Text != "") && (TxtProvin.Text != "") && (TxtImagen.Text != ""))
                {
                    Datos.Listado[posicion].NombreAsambleista1 = TxtNombre.Text;
                    Datos.Listado[posicion].Información1 = TxtInfo.Text;
                    Datos.Listado[posicion].Provincia1 = TxtProvin.Text;
                    Datos.Listado[posicion].Partido = TxtPartido.Text;
                    Datos.Listado[posicion].Imagen = TxtImagen.Text;
                    MessageBox.Show("Se ha editado correctamente");
                    TxtNombre.Text = "";
                    TxtInfo.Text = "";
                    TxtProvin.Text = "";
                    TxtPartido.Text = "";
                    TxtImagen.Text = "";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Le recordamos que en el nombre solo puede ingresar hasta 30 caracteres y en la descripción hasta 180 caracteres.\nTambien la url debe terminar en algun formato de imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombus.Text;


            foreach (var asambleista in Datos.Listado)
            {
                var index = Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre);
                posicion = index;


                nombre1 = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].NombreAsambleista1;
                info1 = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Información1;
                provincia1 = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Provincia1;
                partido1 = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Partido;
                imagen1 = Datos.Listado[Datos.Listado.FindIndex(x => x.NombreAsambleista1 == nombre)].Imagen;

                TxtNombre.Text = nombre1;
                TxtInfo.Text = info1;
                TxtProvin.Text = provincia1;
                TxtPartido.Text = partido1;
                TxtImagen.Text = imagen1;

                return;
            }
        }
    }
}
