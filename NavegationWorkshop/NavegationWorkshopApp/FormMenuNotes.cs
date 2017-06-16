using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegationWorkshopApp
{
    public partial class FormMenuNotes : Form
    {

        public FormMenuNotes()
        {
            InitializeComponent();
            lblUserName.Text = ControllerUser.userLogged.Name;
        }

        private void btnSetPercentages_Click(object sender, EventArgs e)
        {
            Thread threadInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(openWindowsSetPercentages));
            threadInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            threadInterfaz.Start();
            this.Close();
        }

        public void openWindowsSetPercentages()
        {
            FormSetPercentage form = new FormSetPercentage();
            form.ShowDialog();
        }

    }
}
