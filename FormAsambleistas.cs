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
    public partial class FormAsambleistas : Form
    {
        private List<Panel> panels;
        public List<Panel> bas = new List<Panel>();
        public List<Panel> Panels { get => panels; set => panels = value; }
        public FormAsambleistas()
        {
            InitializeComponent();
            EjecucionCartas(Clvalor1.valor);
        }

        public string equipo(string a) {
            return a; 
        }

        

        public void EjecucionCartas(string a)
        {
            
            Panels = bas;
            CrearCartas(a);
            PosicionPaneles();
            MostrarCartas();

        }

        private void CrearCartas(string Partido)
        {
            panels = new List<Panel>();
            pasambleistas.Controls.Clear();
            pasambleistas.VerticalScroll.Value = 0;
            foreach (var asambleista in Datos.Listado)
            {
                if (asambleista.Partido == Partido)
                {
                    MostrarInformacion(Partido);
                    Cartafront cartafront = new Cartafront(asambleista.Imagen, asambleista.NombreAsambleista1, asambleista.Partido, asambleista.Provincia1, asambleista.Información1);
                    panels.Add(new Panel());
                    panels.Last().Location = new Point(40, 50);
                    panels.Last().Size = new Size(214, 242);
                    cartafront.TopLevel = false;
                    cartafront.Dock = DockStyle.Fill;
                    panels.Last().Controls.Add(cartafront);
                    panels.Last().Tag = cartafront;
                    cartafront.Visible = true;
                    pasambleistas.Controls.Add(panels.Last());
                }
            }
        }

        private void PosicionPaneles()
        {
            int x = 40, y = 50;
            int incx = 29, incy = 50;
            for (int i = 0; i < Panels.Count - 1; i++)
            {
                if (x == 526)
                {
                    x = 40;
                    incy = y + Panels.Last().Height + 25;
                    y = incy;
                }
                else
                {
                    x = (x + Panels.Last().Width + incx);
                    if (Panels.Count > 3)
                    {
                        y = (incy);
                    }
                }
                Panels.ElementAt(i + 1).Location = new Point(x, y);
            }
        }

        private void MostrarCartas()
        {
            foreach (var panel in Panels)
            {
                panel.Show();
            }
        }

        private void MostrarInformacion(string partido)
        {
            pbx_infoPartido.WaitOnLoad = false;
            switch (partido)
            {
                case "ID12":
                    pbx_infoPartido.Load("https://upload.wikimedia.org/wikipedia/commons/1/13/Izquierda_democratica_2018.png");
                    txt_infoPartido.Text = "Es un partido político socialista democrático ecuatoriano, históricamente socialdemócrata ecuatoriano,2​ miembro de la Internacional Socialista. Su líder máximo, Rodrigo Borja Cevallos, fue presidente de Ecuador de 1988 hasta 1992. Fue la fuerza política más importante de ese país, tanto en resultados electorales como en organización partidaria, a finales de la década de 1980, y luego pasó a ser la segunda más importante en la década de 1990, luego del Partido Social Cristiano."; 
                    break;
                case "CD 1":
                    pbx_infoPartido.Load("https://pbs.twimg.com/profile_images/953015820669636609/9cv2czeD.jpg");
                    txt_infoPartido.Text = "Jairala creó este partido en el 2012, con el cual participó en las elecciones seccionales de 2014 en alianza con el movimiento Alianza PAIS, obteniendo la reelección para Jairala y varias alcaldías de la provincia, incluyendo Durán. En ese tiempo el partido existía como una organización que solo abarcaba la provincia del Guayas, teniendo como su número de lista 61.Ese mismo año de elecciones fueron parte de la coalición Frente UNIDOS como miembros fundadores, apoyando al gobierno de Rafael Correa.";
                    break;
                case "MUPP":
                    pbx_infoPartido.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Pachakutik.svg/1200px-Pachakutik.svg.png");
                    txt_infoPartido.Text = "Esta organización se define a sí misma como un movimiento político independiente que representan a otros grupos de poder. Principalmente compuesta por elementos de organizaciones indígenas tiene dentro de su ideario elementos como la constitución del estado plurinacional en el Ecuador que respete la interculturalidad. Inspirados en la cosmovisión indígena y declarando su oposición a cualquier forma de explotación, de opresión y de injusticia a la vez que apoyan la autodeterminación de los pueblos."; 
                    break;
                case "PSC":
                    pbx_infoPartido.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Partido_Social_Cristiano_01.svg/1280px-Partido_Social_Cristiano_01.svg.png");
                    txt_infoPartido.Text = "El Partido Social Cristiano (PSC) es un partido político ecuatoriano de centroderecha.2​ Su tendencia se afirma en la defensa de la economía social de mercado,6​ además autodefiniéndose como conservadores que se inspiran en la doctrina social de la Iglesia.1​ Actualmente, la presidencia del partido queda vacante tras la renuncia de Pascual del Cioppo.7​ Ocupa la lista 6, y es el partido ecuatoriano más antiguo y tradicional en vigencia sin sufrir ningún cambio estructural desde su fundación."; 
                    break; 
            }
        }
    }
}
