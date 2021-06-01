using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asambleistas
{
    class ClDatos
    {
        public ClDatos() { 
        }

        public string[,] directivaPrincipal() {
            string[,] matriz;
            matriz = new string[3, 4];
            matriz[0,0] = "ESPERANZA LLORI";
            matriz[0,1] = "Pachakutik";
            matriz[0,2] = "Orellana";
            matriz[0,3] = "En el año 2000 gano la alcadia de Puerto Francisco " +
                "de Orellana, Cuatro años depues fue prefecta del la Provincia de Orellana " +
                "ahora es actual presidenta de la Asamblea";
            matriz[1, 0] = "VIRGUILIO SAQUICELA";
            matriz[1, 1] = "Democracia SI";
            matriz[1, 2] = "Cañar";
            matriz[1, 3] = "Es un abogado nacido en la ciudad de Azogues" +
                "estudio derecho en la universidad de Cuenca" +
                "original mente unicio su trayecto con el partido Pachakutic";

            return matriz;
        }
    }
}
