using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFile1.PresentationWF.Extensions
{
    public static class TextBoxValidation
    {
        public static void SetIntValidation(this TextBox textBox)
        {
            textBox.KeyPress += new KeyPressEventHandler(IntValidationOnTextChanged);
        }

        private static void IntValidationOnTextChanged(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
