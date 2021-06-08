using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asambleistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            generar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void generar()
        {
            Asambleista asambleista1 = new Asambleista("Wilma Piedad Andrade Muñoz", "Fue electa en el Congreso Nacional de Pichincha en el período 2006 - 2010 y volvió a la instancia ejecutiva en 2017", "Pichincha", "ID12", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/REUNI%C3%93N_ID_-_CARONDELET_%2835713764311%29_%28cropped%29.jpg/220px-REUNI%C3%93N_ID_-_CARONDELET_%2835713764311%29_%28cropped%29.jpg");
            Datos.Listado.Add(asambleista1);
            Asambleista asambleista2 = new Asambleista("Eitel James Zambrano Ortiz", "Tiene 33 años de edad y es ingeniero comercial, es el segundo asambleísta de la Izquierda Democrática", "Manabí", "ID12", "https://upload.wikimedia.org/wikipedia/commons/3/31/Eitel_Zambrano.jpg");
            Datos.Listado.Add(asambleista2);
            Asambleista asambleista3 = new Asambleista("Rodrigo Fajardo", "Abogado, forma parte de los asambleístas electos por el partido Izquierda Democrática", "Azuay", "ID12", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Rodrigo-Fajardo.png");
            Datos.Listado.Add(asambleista3);
            Asambleista asambleista4 = new Asambleista("Ramiro Narváez", "Es economista con más de dos décadas en la banca privada y tres años promoviendo el emprendimiento", "Carchi", "ID12", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Ramiro-Narvaez.png");
            Datos.Listado.Add(asambleista4);
            Asambleista asambleista5 = new Asambleista("Dalton Bacigalupo", "Doctor en jurisprudencia, era diputado de la República del Ecuador, representante de la comisión de Asuntos Constitucionales.", "Cotopaxi", "ID12", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Dalton-Bacigalupo.png");
            Datos.Listado.Add(asambleista5);
            Asambleista asambleista6 = new Asambleista("Johanna Moreira", "Tiene 25 años de edad, alcanzó la cuarta vocalía del Consejo de Administración Legislativa.", "El Oro", "ID12", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Johanna-Moreira.png");
            Datos.Listado.Add(asambleista6);
            Asambleista asambleista7 = new Asambleista("Jorge Farah", "Es un reconocido abogado ", "Bolívar", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Jorge-Abedrabo.png");
            Datos.Listado.Add(asambleista7);
            Asambleista asambleista8 = new Asambleista("Pedro Falquez", "Fue profesor y rector del Colegio Carmen Mora de Encalada.", "El Oro", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Carlos-Falquez.png");
            Datos.Listado.Add(asambleista8);
            Asambleista asambleista9 = new Asambleista("Javier Ortiz", "Es un reconocido abogado.", "Esmeraldas", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Javier-Ortiz.png");
            Datos.Listado.Add(asambleista9);
            Asambleista asambleísta10 = new Asambleista("Pedro Zapata", "Es licenciado en ciencias de la educación y también es abogado.", "Galápagos", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Pedro-Zapata.png");
            Datos.Listado.Add(asambleísta10);
            Asambleista asambleista11 = new Asambleista("Luis Almeida", "Es un reconocido abogado.", "Guayas", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Luis-Almeida.png");
            Datos.Listado.Add(asambleista11);
            Asambleista asambleista12 = new Asambleista("Marjorie Chávez", "Empresaria, comunicadora, maestra, emprendedora, activista de temas de género y política de 37 años de edad.", "Pichincha", "PSC", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Marjorie-Chavez.png");
            Datos.Listado.Add(asambleista12);
            Asambleista asambleista13 = new Asambleista("Ricardo Ulcuango", "Arquitecta, nacida en Guayaquil.", "Pichincha", "CD 1", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Ricardo-Ulcuango.png");
            Datos.Listado.Add(asambleista13);
            Asambleista asambleista14 = new Asambleista("Pierina Correa", "Fue diputada por el movimiento Plurinacional Pachakutik y jefa del bloque.", "Guayaquil", "CD 1", "https://pbs.twimg.com/profile_images/1346203499013566465/16IMDgDQ_400x400.jpg");
            Datos.Listado.Add(asambleista14);
            Asambleista asambleista15 = new Asambleista("Raisa Irina Corral", "Tiene 31 años de edad, es contadora, se encargó de la ejecución de proyectos y reconstrucción productiva", "Manabí", "CD 1", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Raisa-Corral.png");
            Datos.Listado.Add(asambleista15);
            Asambleista asambleista16 = new Asambleista("José Agualsaca", "Fue asambleísta alterno de Gabriela Rivadeneira, pasó a formar parte de la Comisión de Salud como reemplazo de Rivadeneira.", "Morona Santiago", "CD 1", "https://confederacionfei.org/wp-content/uploads/2021/02/fondo-blanco-683x1024.jpg");
            Datos.Listado.Add(asambleista16);
            Asambleista asambleista17 = new Asambleista("Paola Cabezas", "Política  de 42 años de edad, es licenciada en Ciencias de la Comunicación y tiene una maestría en Marketing Político.", "Sucumbíos", "CD 1", "https://elestado.net/wp-content/uploads/2021/01/unnamed-1.jpg");
            Datos.Listado.Add(asambleista17);
            Asambleista asambleista18 = new Asambleista("Eduardo Zambrano", "Fue asambleísta por Cirunscripción por América Latina, es integrante de la Comisión Especializada Permanente de Soberanía", "Pichincha", "CD 1", "https://upload.wikimedia.org/wikipedia/commons/5/5f/Eduardo_Zambrano_2016.jpg");
            Datos.Listado.Add(asambleista18);
            Asambleista asambleista19 = new Asambleista("Ángel Maita", "Licenciado en Ciencias en Estudios de Ayudante médico, doctor en medicina y cirugía.", "Loja", "MUPP", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Salvador-Maita.png");
            Datos.Listado.Add(asambleista19);
            Asambleista asambleista20 = new Asambleista("José Chávez", "Bachiller en Agropecuaria forestal, estudiante de la carrera de Administración y Gestión Municipal", "Sto.Domingo T.", "MUPP", "https://observatoriolegislativo.ec/media/fotos_asambleistas/Ricardo-Chavez.png");
            Datos.Listado.Add(asambleista20);
            Asambleista asambleista21 = new Asambleista("Pascacio Córdova", "Licenciada, fue encargada de supervisar ciertas obras en el período del mandato de Rafael Correa.", "Sucumbíos", "MUPP", "a");
            Datos.Listado.Add(asambleista21);
            Asambleista asambleista22 = new Asambleista("Rosa Mayorga", "Comunicadora Social, Magister en Tecnologías para la Gestión y Práctica Docente, Máster Universitario en Teoría y Crítica de la Cultura. ", "Tungurahua", "MUPP", "https://pbs.twimg.com/ext_tw_video_thumb/1355290467966062597/pu/img/3lrwZxTH1hjp4oqW.jpg");
            Datos.Listado.Add(asambleista22);
            Asambleista asambleista23 = new Asambleista("Salvador Quishpe", "Político y sociólogo, tiene 50 años de edad, magister en Gestión Empresarial y Desarrollo Social.", "Zamora Chinchipe", "MUPP", "https://mloji0n3ltha.i.optimole.com/eyiG3pg.yDB-~3199a/w:600/h:400/q:auto/https://gk.city/wp-content/uploads/2021/05/salvador-quishpe.jpg");
            Datos.Listado.Add(asambleista23);
            Asambleista asambleista24 = new Asambleista("Bertha Sánchez", "Arquitecta muy reconocida.", "Guayaquil", "MUPP", "https://primeraplana.com.ec/wp-content/uploads/2021/03/51.-Bertha-Sanchez.jpg");
            Datos.Listado.Add(asambleista24);
        }
    }
}
