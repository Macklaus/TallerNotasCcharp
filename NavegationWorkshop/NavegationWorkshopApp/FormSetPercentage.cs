using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegationWorkshopApp
{
    public partial class FormSetPercentage : Form
    {
        public FormSetPercentage()
        {
            InitializeComponent();
            showPercentages();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        public void showPercentages()
        {
            ClassPercentage p = ControllerUser.userLogged.Percentage;
            txtPartial1.Text = "" + p.Partial1;
            txtPartial2.Text = "" + p.Partial2;
            txtPartial3.Text = "" + p.Partial3;
            txtWorkshop1.Text = "" + p.Workshop1;
            txtWorkshop2.Text = "" + p.Workshop2;
            txtWorkshop3.Text = "" + p.Workshop3;
        }
    }
}
