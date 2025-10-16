namespace Picture_Box_Use
{
    partial class frm_Search_Image
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_Image_Description = new System.Windows.Forms.TextBox();
            this.tb_Image_ID = new System.Windows.Forms.TextBox();
            this.lbl_Image_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Show_Images = new System.Windows.Forms.Button();
            this.pb_Add_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reset.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Reset.Location = new System.Drawing.Point(128, 451);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(117, 42);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tb_Image_Description
            // 
            this.tb_Image_Description.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Description.Location = new System.Drawing.Point(217, 216);
            this.tb_Image_Description.MaxLength = 60;
            this.tb_Image_Description.Multiline = true;
            this.tb_Image_Description.Name = "tb_Image_Description";
            this.tb_Image_Description.Size = new System.Drawing.Size(242, 168);
            this.tb_Image_Description.TabIndex = 18;
            // 
            // tb_Image_ID
            // 
            this.tb_Image_ID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_ID.Location = new System.Drawing.Point(217, 140);
            this.tb_Image_ID.MaxLength = 60;
            this.tb_Image_ID.Name = "tb_Image_ID";
            this.tb_Image_ID.Size = new System.Drawing.Size(218, 26);
            this.tb_Image_ID.TabIndex = 17;
            this.tb_Image_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Image_Id
            // 
            this.lbl_Image_Id.AutoSize = true;
            this.lbl_Image_Id.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Id.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image_Id.Location = new System.Drawing.Point(25, 138);
            this.lbl_Image_Id.Name = "lbl_Image_Id";
            this.lbl_Image_Id.Size = new System.Drawing.Size(80, 22);
            this.lbl_Image_Id.TabIndex = 23;
            this.lbl_Image_Id.Text = "Image Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(25, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Image Description";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image.Location = new System.Drawing.Point(668, 82);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(59, 22);
            this.lbl_Image.TabIndex = 25;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Uighur", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(353, 24);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(184, 56);
            this.lbl_Header.TabIndex = 26;
            this.lbl_Header.Text = "Search Image";
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Add_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Add_Image.Location = new System.Drawing.Point(347, 451);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(180, 42);
            this.btn_Add_Image.TabIndex = 22;
            this.btn_Add_Image.Text = "Add Images";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Search.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Search.Location = new System.Drawing.Point(453, 132);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 34);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Show_Images
            // 
            this.btn_Show_Images.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Show_Images.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Images.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Show_Images.Location = new System.Drawing.Point(639, 451);
            this.btn_Show_Images.Name = "btn_Show_Images";
            this.btn_Show_Images.Size = new System.Drawing.Size(180, 42);
            this.btn_Show_Images.TabIndex = 22;
            this.btn_Show_Images.Text = "Show Images";
            this.btn_Show_Images.UseVisualStyleBackColor = false;
            this.btn_Show_Images.Click += new System.EventHandler(this.btn_Show_Images_Click);
            // 
            // pb_Add_Image
            // 
            this.pb_Add_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Add_Image.Location = new System.Drawing.Point(560, 118);
            this.pb_Add_Image.Name = "pb_Add_Image";
            this.pb_Add_Image.Size = new System.Drawing.Size(299, 266);
            this.pb_Add_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_Image.TabIndex = 27;
            this.pb_Add_Image.TabStop = false;
            // 
            // frm_Search_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pb_Add_Image);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.btn_Show_Images);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Image_Description);
            this.Controls.Add(this.tb_Image_ID);
            this.Controls.Add(this.lbl_Image_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Search_Image";
            this.Text = "Search Image";
            this.Load += new System.EventHandler(this.frm_Search_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Add_Image;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_Image_Description;
        private System.Windows.Forms.TextBox tb_Image_ID;
        private System.Windows.Forms.Label lbl_Image_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Show_Images;
    }
}