using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace semanaTec.Metodos
{
    public class isEmpty
    {
        public string empty(Control controls)
        {
            string tag = "";
            foreach (Control child in controls.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(child is Label)
                { }
                else if (child is Button)
                { }
                else if (child is DataGridView)
                { }
                else if (child is TextBox)
                {
                    if (string.IsNullOrEmpty(child.Text)
                    || (string.IsNullOrWhiteSpace(child.Text)
                    || child.Text == string.Empty))
                    {
                        tag = child.Tag.ToString();
                        break;
                    }
                    else
                    { }
                }
                else if (child is MaskedTextBox)
                {
                    ((MaskedTextBox)child).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if((string.IsNullOrEmpty(child.Text) || string.IsNullOrWhiteSpace(child.Text))
                    || child.Text == string.Empty)
                    {
                        tag = child.Tag.ToString();
                        break;
                    }
                }
                else if (child is ComboBox && ((ComboBox)child).SelectedIndex < 0)
                {
                    tag = child.Tag.ToString();
                    break;
                }
            }
            return tag;
        }
    }
}
