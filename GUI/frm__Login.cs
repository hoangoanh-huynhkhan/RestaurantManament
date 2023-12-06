using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Entities;

namespace GUI
{
    public partial class frm__Login : Form
    {
        private EmployerService employerService;

        List<Employer> employers;
        public frm__Login()
        {
            employerService = new EmployerService();
            employers = new List<Employer>();
            InitializeComponent();

            this.Load += Frm__Login_Load;
        }

        private void Frm__Login_Load(object sender, EventArgs e)
        {
            try
            {
                var employermodels = employerService.GetAll();
                foreach (Employer item in employermodels)
                {
                    employers.Add(item);
                }
                MessageBox.Show(employers.Count.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
