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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desing();
        }


        /*dropmenu*/
        private void desing() {
            panel_submenu.Visible = false; 
        }

        private void hideSubmenu() {
            if (panel_submenu.Visible == true)
                panel_submenu.Visible = false; 
        }


        private void showSubmenu(Panel submenu) {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else {
                submenu.Visible = false; 
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_submenu); 
        }

        private void btn_Directiva_Click(object sender, EventArgs e)
        {
            hideSubmenu(); 
        }

        private void btn_Creo_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_centroDemocratico_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_Pachakutic_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_socialCristiano_Click(object sender, EventArgs e)
        {
            hideSubmenu();

            FrmSocialCristiano ObjPsc = new FrmSocialCristiano();
            ObjPsc.Show();

        }

        /*Mover el Forms*/

        bool dat = false; 
        private void panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            dat = true; 
        }

        private void panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (dat == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            dat = false; 
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            btn_cerrar.Cursor = Cursors.Hand;
            Application.Exit();
        }

       
    }
}
