using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Metodos
{
    public class cleanControls
    {
        public void limpa(Control controls)
        {
            foreach (Control child in controls.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (child is Label)
                { }
                else if (child is Button)
                { }
                else if (child is TextBox)
                {
                    if (!string.IsNullOrEmpty(child.Text)
                    || (!string.IsNullOrWhiteSpace(child.Text) 
                    || child.Text != string.Empty))
                    child.Text = "";
                }
                else if (child is MaskedTextBox)
                {
                    ((MaskedTextBox)child).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if ((!string.IsNullOrEmpty(child.Text) || !string.IsNullOrWhiteSpace(child.Text))
                    || child.Text != string.Empty)
                    {
                        child.Text = "";
                    }
                }
                else if (child is ComboBox && ((ComboBox)child).SelectedIndex > 0)
                {
                    ((ComboBox)child).SelectedIndex = -1;
                }
            }
        }
    }
}
