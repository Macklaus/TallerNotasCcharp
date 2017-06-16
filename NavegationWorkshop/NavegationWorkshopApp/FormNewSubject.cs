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
    public partial class FormNewSubject : Form
    {
        //verify if the windows is opened for create or modify a subject
        private int action; //1 = create - 2 = modify

        public FormNewSubject(int action)
        {
            InitializeComponent();
            this.action = action;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
