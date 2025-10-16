namespace Fork_Infosystems_App
{
    partial class frm_File_Upload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Next_Form = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.lbl_File_Name = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Select_Resume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Header.Location = new System.Drawing.Point(243, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(257, 57);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "File Upload";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.White;
            this.btn_Browse.Font = new System.Drawing.Font("Californian FB", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Browse.Location = new System.Drawing.Point(456, 237);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(124, 38);
            this.btn_Browse.TabIndex = 13;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Next_Form
            // 
            this.btn_Next_Form.BackColor = System.Drawing.Color.White;
            this.btn_Next_Form.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next_Form.ForeColor = System.Drawing.Color.Orange;
            this.btn_Next_Form.Location = new System.Drawing.Point(665, 406);
            this.btn_Next_Form.Name = "btn_Next_Form";
            this.btn_Next_Form.Size = new System.Drawing.Size(97, 32);
            this.btn_Next_Form.TabIndex = 14;
            this.btn_Next_Form.Text = "Next ";
            this.btn_Next_Form.UseVisualStyleBackColor = false;
            this.btn_Next_Form.Click += new System.EventHandler(this.btn_Next_Form_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.White;
            this.btn_Upload.Font = new System.Drawing.Font("Californian FB", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Upload.Location = new System.Drawing.Point(323, 352);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(121, 44);
            this.btn_Upload.TabIndex = 12;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // lbl_File_Name
            // 
            this.lbl_File_Name.AutoSize = true;
            this.lbl_File_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_File_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_File_Name.Location = new System.Drawing.Point(586, 247);
            this.lbl_File_Name.Name = "lbl_File_Name";
            this.lbl_File_Name.Size = new System.Drawing.Size(74, 16);
            this.lbl_File_Name.TabIndex = 11;
            this.lbl_File_Name.Text = "File Name";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(423, 133);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(214, 31);
            this.tb_Username.TabIndex = 15;
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Uname.Location = new System.Drawing.Point(146, 133);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(119, 25);
            this.lbl_Uname.TabIndex = 11;
            this.lbl_Uname.Text = "User Name";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(471, 288);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(86, 15);
            this.lbl_Note.TabIndex = 11;
            this.lbl_Note.Text = "(Select .pdf file)";
            // 
            // lbl_Select_Resume
            // 
            this.lbl_Select_Resume.AutoSize = true;
            this.lbl_Select_Resume.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select_Resume.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Select_Resume.Location = new System.Drawing.Point(146, 238);
            this.lbl_Select_Resume.Name = "lbl_Select_Resume";
            this.lbl_Select_Resume.Size = new System.Drawing.Size(153, 25);
            this.lbl_Select_Resume.TabIndex = 11;
            this.lbl_Select_Resume.Text = "Select Resume";
            // 
            // frm_File_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Next_Form);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.lbl_Select_Resume);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_File_Name);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_File_Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Upload Basic";
            this.Load += new System.EventHandler(this.frm_File_Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Next_Form;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label lbl_File_Name;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Select_Resume;
    }
}

