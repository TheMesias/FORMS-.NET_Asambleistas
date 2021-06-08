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
    public partial class FormInsertar : Form
    {
        public List<Asambleista> aux = Datos.Listado;
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Asambleista asambleista = new Asambleista();
            try
            {
                if ((txt_nombre.Text.Length < 30) && (txt_descrip.Text.Length < 180) && (txt_nombre.Text != "") && (txt_descrip.Text != "") && (cb_partido.Text != "") && (cb_provin.Text != "") && (txt_imagen.Text != ""))
                {
                    asambleista.NombreAsambleista1 = txt_nombre.Text;
                    asambleista.Información1 = txt_descrip.Text;
                    asambleista.Provincia1 = cb_provin.Text;
                    asambleista.Partido = cb_partido.Text;
                    asambleista.Imagen = txt_imagen.Text;
                    aux.Add(asambleista);
                    Datos.Listado = aux;
                    nuevo();
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

        private void nuevo()
        {
            txt_nombre.Text = "";
            txt_descrip.Text = "";
            txt_imagen.Text = "";
            cb_partido.Text = "";
            cb_provin.Text = "";
        }
    }
}
