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
    public partial class FrmPSC1 : Form
    {
        public FrmPSC1()
        {
            InitializeComponent();
        }

        private void BtnInfoJor_Click(object sender, EventArgs e)
        {
            PnlInfoJor.Visible = true;
        }

        private void BtnGuarJor_Click(object sender, EventArgs e)
        {
            PnlInfoJor.Visible = false;
        }

        private void BtnInfoFa_Click(object sender, EventArgs e)
        {
            PnlInfoFal.Visible = true;
        }

        private void BtnGuarFal_Click(object sender, EventArgs e)
        {
            PnlInfoFal.Visible = false;
        }

        private void BtnInfoJav_Click(object sender, EventArgs e)
        {
            PnlInfoJav.Visible = true;
        }

        private void BtnGuarJa_Click(object sender, EventArgs e)
        {
            PnlInfoJav.Visible = false;
        }

        private void BtnInfoPedZa_Click(object sender, EventArgs e)
        {
            PnlInfoPed.Visible = true;
        }

        private void BtnGuarPedZap_Click(object sender, EventArgs e)
        {
            PnlInfoPed.Visible = false;
        }
    }
}
