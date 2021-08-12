using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace File_Arrangement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void b_locationButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog d1 = new CommonOpenFileDialog();
            d1.IsFolderPicker = true;
            if(d1.ShowDialog() == CommonFileDialogResult.Ok)
            {
                t_location.Text = d1.FileName;
            }
        }

        private void b_targetLocationButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog d2 = new CommonOpenFileDialog();
            d2.IsFolderPicker = true;
            if(d2.ShowDialog() == CommonFileDialogResult.Ok)
            {
                t_targetLocation.Text = d2.FileName;
            }
        }

        private void b_ready_Click(object sender, EventArgs e)
        {
            if(b_locationButton.Enabled == true)
            {
                b_locationButton.Enabled = false;
                b_targetLocationButton.Enabled = false;
                b_ready.Text = "준비중...";
                b_start.Enabled = true;
            }
            else
            {
                b_locationButton.Enabled = true;
                b_targetLocationButton.Enabled = true;
                b_ready.Text = "이동 준비";
                b_start.Enabled = false;
            }
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string user = t_fileName.Text;
            string[] search = Directory.GetFiles(t_location.Text.ToString(), "*");
            foreach(string fileName in search)
            {
                if (fileName.Contains(user))
                {
                    string partOfName = Path.GetFileName(fileName);
                    File.Move(fileName, t_targetLocation.Text + "\\" + partOfName);
                }
            }
            this.Cursor = Cursors.Default;
            MessageBox.Show("완료!", "이동 완료!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
