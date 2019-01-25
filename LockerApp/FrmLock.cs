using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using LockerApp.Properties;

namespace LockerApp
{
    public partial class FrmLock : Form
    {
        string pth = "";
        public FrmLock()
        {
            InitializeComponent();
        }

        public FrmLock(string path)
        {
            InitializeComponent();
            CheckForPassword();
            pth = path;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            try
            {
                string paword = txtPass.Text;
                bool match = false;
                string rpaword = Settings.Default["pWord"].ToString();
                match = paword.Equals(rpaword);
                if(match == true)
                {
                    try
                    {
                        string admin = Environment.UserName;
                        DirectorySecurity ds = Directory.GetAccessControl(pth);
                        FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.FullControl, AccessControlType.Deny);
                        ds.AddAccessRule(fs);
                        Directory.SetAccessControl(pth, ds);
                        MessageBox.Show("Folder locked!", "Success");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error whlie locking", "Error!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong Password", "Error!");
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            FrmSetPassword frm = new FrmSetPassword();
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckForPassword()
        {
            string pw = Settings.Default["pWord"].ToString();
            if(pw == "")
            {
                btnLock.Enabled = false;
            }
            if(pw != "")
            {
                btnLock.Enabled = true;
            }
        }
    }
}
