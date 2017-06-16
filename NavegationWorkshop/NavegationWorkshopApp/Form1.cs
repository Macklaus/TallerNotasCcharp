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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Thread threadInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(openWindowsCreateUser));
            threadInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            threadInterfaz.Start();
            this.Close();
        }

        public void openWindowsCreateUser()
        {
            FormCreateUser form = new FormCreateUser();
            form.ShowDialog();
        }

        public void openWindowsMenuSubject()
        {
            FormMenuNotes form = new FormMenuNotes();
            form.ShowDialog();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            String user = txtUsername.Text;
            String pass = txtPassword.Text;

            ControllerUser controller = new ControllerUser();
            ClassUser u = controller.verifyCredentials(user, pass);
            if(u != null)
            {
                ControllerUser.userLogged = u;
                Thread threadInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(openWindowsMenuSubject));
                threadInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
                threadInterfaz.Start();
                this.Close();
            } else
            {
                MessageBox.Show("Credentials are incorrect");
            }
        }
    }
}
