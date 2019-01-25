using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LockerApp.Properties;
using System.Security.AccessControl;

namespace LockerApp
{
    public partial class FrmSetPassword : Form
    {
        public FrmSetPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pw1 = txtPw1.Text;
                string pw2 = txtPw2.Text;
                bool match = false;
                match = pw1.Equals(pw2);
                if (match == true)
                {
                    Settings.Default["pWord"] = pw1;
                    MessageBox.Show("Password saved!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                    txtPw1.Clear();
                    txtPw2.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
