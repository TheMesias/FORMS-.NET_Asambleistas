using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Asambleistas
{
    class ClValidar
    {
        public static void SoloLetras(KeyPressEventArgs Valid)
        {
            if (Char.IsLetter(Valid.KeyChar))
            {

                Valid.Handled = false;

            }
            else if (Char.IsSeparator(Valid.KeyChar))
            {

                Valid.Handled = false;
            }
            else if (Char.IsControl(Valid.KeyChar))
            {
                Valid.Handled = false;
            }
            else
            {
                Valid.Handled = true;
            }

        }
        public static void SoloNumeros(KeyPressEventArgs valid)
        {
            if (Char.IsDigit(valid.KeyChar))
            {
                valid.Handled = false;
            }
            else if (Char.IsSeparator(valid.KeyChar))
            {
                valid.Handled = false;
            }
            else if (Char.IsControl(valid.KeyChar))
            {
                valid.Handled = false;
            }
            else if (valid.KeyChar.ToString().Equals("."))
            {
                valid.Handled = false;
            }
            else if (valid.KeyChar.ToString().Equals("-"))
            {
                valid.Handled = false;
            }
            else
            {
                valid.Handled = true;
            }
        }
    }
}
