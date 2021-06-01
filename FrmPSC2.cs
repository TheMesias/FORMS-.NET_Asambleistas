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
    public partial class FrmPSC2 : Form
    {
        public FrmPSC2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfoDall_Click(object sender, EventArgs e)
        {
            PnlInfoDall.Visible = true;

        }

        private void BtnGuarDall_Click(object sender, EventArgs e)
        {
            PnlInfoDall.Visible = false;
        }

        private void BtnInfoCes_Click(object sender, EventArgs e)
        {
            PnlInfoCes.Visible = true;
        }

        private void BtnGuarCes_Click(object sender, EventArgs e)
        {
            PnlInfoCes.Visible = false;

        }

        private void BtnInfoMari_Click(object sender, EventArgs e)
        {
            PnlInfoMaria.Visible = true;

        }

        private void BtnGuarMaria_Click(object sender, EventArgs e)
        {
            PnlInfoMaria.Visible = false;
        }

        private void BtnInfoJho_Click(object sender, EventArgs e)
        {
            PnlInfoJhon.Visible = true;
        }

        private void BtnGuarJhon_Click(object sender, EventArgs e)
        {
            PnlInfoJhon.Visible = false;
        }
    }
}
