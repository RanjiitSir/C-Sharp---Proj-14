using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Fork_Infosystems_App
{
    public partial class frm_File_Upload : Form
    {
        public frm_File_Upload()
        {
            InitializeComponent();
        }

        string strNewPath = "";
        string strOldPath = "";

        private void frm_File_Upload_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Obj = new OpenFileDialog();

            Obj.Filter = "Files(*.pdf;)| *.pdf;";

            if (Obj.ShowDialog() == DialogResult.OK)
            {
                lbl_File_Name.Text = Obj.FileName;
                strOldPath = Obj.FileName;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && strOldPath != "")
            {
                string UploadFolder = @"C:\Fork_App-Resume";

                if (!Directory.Exists(UploadFolder))
                {
                    Directory.CreateDirectory(UploadFolder);
                }

                string fileName = "" + tb_Username.Text + ".pdf";

                strNewPath = Path.Combine(UploadFolder, fileName);

                File.Copy(strOldPath, strNewPath, true);

                MessageBox.Show($"File '{fileName}' uploaded successfully to '{UploadFolder}'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tb_Username.Clear();
            lbl_File_Name.Text = "FileName";
        }

        private void btn_Next_Form_Click(object sender, EventArgs e)
        {

        }
    }
}
