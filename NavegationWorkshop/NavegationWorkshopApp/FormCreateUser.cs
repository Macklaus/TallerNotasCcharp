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
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread threadInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(OpenWindows));
            threadInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            threadInterfaz.Start();
            this.Close();
        }

        public void OpenWindows()
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Equals("") || txtPassword.Text.Equals("") 
                || txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Please, Complete all fields");
            } else
            {
                if (!txtPassword.Text.Equals(txtVerifyPassword.Text))
                {
                    MessageBox.Show("Passwords are not same");
                } else
                {
                    String name = txtName.Text;
                    String user = txtUsername.Text;
                    String pass = txtPassword.Text;
                    ClassPercentage percentage = new ClassPercentage();
                    ClassUser u = new ClassUser(name, user, pass, percentage);
                    ControllerUser controller = new ControllerUser();
                    if (controller.saveUser(u))
                    {
                        MessageBox.Show("User has been registrated!!!");
                        cleanFields();
                    } else
                    {
                        MessageBox.Show("There already is a user with that username");
                    }
                }
            }
        }

        public void cleanFields()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtVerifyPassword.Text = "";
        }
    }
}
