using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtExtension.Text.Equals(""))
                return;

            lstExtension.Items.Add(txtExtension.Text);
            txtExtension.Text = null;
        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAdd_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lstExtension.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstExtension.Items.RemoveAt(lstExtension.SelectedIndices[i]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstExtension.Items.Clear();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (FD.ShowDialog() == DialogResult.OK)
                txtPath.Text = FD.SelectedPath + "\\";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                string sPath = txtPath.Text;
                string ext;

                if (sPath == "")
                {
                    MessageBox.Show("경로를 설정해주세요");
                    return;
                }

                timer1.Interval = (int.Parse(txtInterval.Text) * 1000);
                timer1.Enabled = true;
                btnStart.Text = "중지";

                for (int i = 0; i < lstExtension.Items.Count; i++)
                {
                    ext = sPath + lstExtension.Items[i].ToString();
                    if (!Directory.Exists(sPath + lstExtension.Items[i]))
                        Directory.CreateDirectory(ext);
                }


            } else {
                timer1.Enabled = false;
                btnStart.Text = "시작";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sPath = txtPath.Text;
                string[] sFiles = Directory.GetFiles(sPath);

                foreach (var file in sFiles)
                {
                    string ext = Path.GetExtension(file).Replace(".", "");
                    string FileName = Path.GetFileName(file);

                    if (Directory.Exists(sPath + "\\" + ext))
                        File.Move(file, sPath + ext + "\\" + FileName);
                }
            }
            catch (Exception)
            {
                timer1.Enabled = false;
                btnStart.Text = "시작";
                MessageBox.Show("에러발생!");
            }

        }

    }
}
