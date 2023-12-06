using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm__Login : Form
    {
        public frm__Login()
        {
            InitializeComponent();
        }

        private void btn__close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close programing?", "Wanning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
