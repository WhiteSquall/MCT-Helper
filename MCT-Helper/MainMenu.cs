using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCT_Helper
{
    public partial class fMainMenu : Form
    {
        public fMainMenu()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            bool mFormState = new bool();
            mFormState = false;

            foreach (Form mForm in Application.OpenForms)
            {
                if (mForm.GetType() == frm.GetType())
                {
                    mFormState = true;
                }
            }

            if (!mFormState)
            {
                frm.Show();
                frm.Activate();
            }
            else
            {
                frm.Dispose();
            }
        }

        private void bPCD_Click(object sender, EventArgs e)
        {
            FormShow(new fPCD());
        }

        private void bTap_Click(object sender, EventArgs e)
        {
            FormShow(new fTap());
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
