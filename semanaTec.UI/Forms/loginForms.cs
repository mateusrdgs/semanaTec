using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Forms
{
    public partial class loginForms : Form
    {
        public loginForms()
        {
            InitializeComponent();
        }

        private void newUserLbl_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;            
        }

        private void newUserLbl_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
