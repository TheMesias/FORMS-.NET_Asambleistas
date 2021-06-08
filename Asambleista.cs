using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asambleistas
{
    public class Asambleista
    {
        private string NombreAsambleista;
        private string imagen;
        private string Información;
        private string Provincia;
        private string partido;

        public string NombreAsambleista1 { get => NombreAsambleista; set => NombreAsambleista = value; }
        public string Información1 { get => Información; set => Información = value; }
        public string Provincia1 { get => Provincia; set => Provincia = value; }
        public string Partido { get => partido; set => partido = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public Asambleista()
        {
            NombreAsambleista = "";
            Información1 = "";
            Provincia1 = "";
            Partido = "";
            Imagen = "";
        }
        public Asambleista(string nombre, string informacion, string provincia, string partido, string imagen)
        {
            NombreAsambleista = nombre;
            Información1 = informacion;
            Provincia1 = provincia;
            Partido = partido;
            Imagen = imagen;
        }
    }
}
