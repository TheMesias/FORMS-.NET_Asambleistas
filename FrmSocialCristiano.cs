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
    public partial class FrmSocialCristiano : Form
    {
        public FrmSocialCristiano()
        {
            InitializeComponent();
        }

      

        private void GrbxDesPsc_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnInfoHen_Click(object sender, EventArgs e)
        {
            PnlInfoHen.Visible=true;

        }

        private void BtnInfoNat_Click(object sender, EventArgs e)
        {
            PnlInfoNat.Visible = true;
        }

        private void BtnGuarHen_Click(object sender, EventArgs e)
        {
            PnlInfoHen.Visible = false;
        }

        private void BtnGuarNat_Click(object sender, EventArgs e)
        {
            PnlInfoNat.Visible = false;
        }
    }
}
