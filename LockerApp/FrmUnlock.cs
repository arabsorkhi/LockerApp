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
using LockerApp.Properties;
using System.IO;

namespace LockerApp
{
    public partial class FrmUnlock : Form
    {

        private string pth = "";

        public FrmUnlock()
        {
            InitializeComponent();
        }

        public FrmUnlock(string path)
        {
            InitializeComponent();
            pth = path;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                string pword = txtPword.Text;
                string rpword = Settings.Default["pWord"].ToString();
                bool match = false;
                match = pword.Equals(rpword);
                if(match == true)
                {
                    try
                    {
                        string admin = Environment.UserName;
                        DirectorySecurity ds = Directory.GetAccessControl(pth);
                        
                        FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.FullControl, AccessControlType.Allow);
                        ds.ResetAccessRule(fs);
                        Directory.SetAccessControl(pth, ds);
                        MessageBox.Show("Folder is unlocked!", "Success");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while unlocking", "Error!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong Password", "Error!");
            }
        }
    }
}
