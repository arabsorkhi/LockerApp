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
using System.IO;
using System.Security.AccessControl;

namespace LockerApp
{
    public partial class FrmMain : Form
    {

        private string path = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            FrmLock frm = new FrmLock(path);
            frm.ShowDialog();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            FrmUnlock frm = new FrmUnlock(path);
            frm.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if(fdb.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fdb.SelectedPath;
                path = txtPath.Text;
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            FrmSetPassword frm = new FrmSetPassword();
            frm.ShowDialog();
        }
    }
}
