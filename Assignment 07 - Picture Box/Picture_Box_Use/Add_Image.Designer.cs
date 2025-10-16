
namespace Picture_Box_Use
{
    partial class Add_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Image));
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_Image_ID = new System.Windows.Forms.TextBox();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Image_Id = new System.Windows.Forms.Label();
            this.tb_Image_Description = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Show_Images = new System.Windows.Forms.Button();
            this.btn_Search_Image = new System.Windows.Forms.Button();
            this.pb_Add_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Reset.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Reset.Location = new System.Drawing.Point(31, 443);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(117, 42);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tb_Image_ID
            // 
            this.tb_Image_ID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_ID.Location = new System.Drawing.Point(219, 132);
            this.tb_Image_ID.MaxLength = 60;
            this.tb_Image_ID.Name = "tb_Image_ID";
            this.tb_Image_ID.Size = new System.Drawing.Size(235, 26);
            this.tb_Image_ID.TabIndex = 1;
            this.tb_Image_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image.Location = new System.Drawing.Point(670, 74);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(59, 22);
            this.lbl_Image.TabIndex = 12;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Uighur", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(311, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(174, 56);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "Insert Image";
            this.lbl_Header.MouseLeave += new System.EventHandler(this.lbl_Header_MouseLeave);
            this.lbl_Header.MouseHover += new System.EventHandler(this.lbl_Header_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(27, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Description";
            // 
            // lbl_Image_Id
            // 
            this.lbl_Image_Id.AutoSize = true;
            this.lbl_Image_Id.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Id.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image_Id.Location = new System.Drawing.Point(27, 130);
            this.lbl_Image_Id.Name = "lbl_Image_Id";
            this.lbl_Image_Id.Size = new System.Drawing.Size(80, 22);
            this.lbl_Image_Id.TabIndex = 12;
            this.lbl_Image_Id.Text = "Image Id";
            // 
            // tb_Image_Description
            // 
            this.tb_Image_Description.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Description.Location = new System.Drawing.Point(219, 208);
            this.tb_Image_Description.MaxLength = 60;
            this.tb_Image_Description.Multiline = true;
            this.tb_Image_Description.Name = "tb_Image_Description";
            this.tb_Image_Description.Size = new System.Drawing.Size(235, 156);
            this.tb_Image_Description.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Save.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Save.Location = new System.Drawing.Point(204, 443);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 42);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Browse.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Browse.Location = new System.Drawing.Point(660, 352);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(96, 37);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            this.btn_Browse.MouseLeave += new System.EventHandler(this.btn_Browse_MouseLeave);
            this.btn_Browse.MouseHover += new System.EventHandler(this.btn_Browse_MouseHover);
            // 
            // btn_Show_Images
            // 
            this.btn_Show_Images.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Show_Images.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Images.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Show_Images.Location = new System.Drawing.Point(619, 443);
            this.btn_Show_Images.Name = "btn_Show_Images";
            this.btn_Show_Images.Size = new System.Drawing.Size(180, 42);
            this.btn_Show_Images.TabIndex = 6;
            this.btn_Show_Images.Text = "Show Images";
            this.btn_Show_Images.UseVisualStyleBackColor = false;
            this.btn_Show_Images.Click += new System.EventHandler(this.btn_Show_Images_Click);
            // 
            // btn_Search_Image
            // 
            this.btn_Search_Image.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Search_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Image.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Search_Image.Location = new System.Drawing.Point(381, 443);
            this.btn_Search_Image.Name = "btn_Search_Image";
            this.btn_Search_Image.Size = new System.Drawing.Size(180, 42);
            this.btn_Search_Image.TabIndex = 6;
            this.btn_Search_Image.Text = "Search Images";
            this.btn_Search_Image.UseVisualStyleBackColor = false;
            this.btn_Search_Image.Click += new System.EventHandler(this.btn_Search_Image_Click);
            // 
            // pb_Add_Image
            // 
            this.pb_Add_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Add_Image.Location = new System.Drawing.Point(562, 110);
            this.pb_Add_Image.Name = "pb_Add_Image";
            this.pb_Add_Image.Size = new System.Drawing.Size(280, 225);
            this.pb_Add_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_Image.TabIndex = 16;
            this.pb_Add_Image.TabStop = false;
            // 
            // Add_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pb_Add_Image);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Search_Image);
            this.Controls.Add(this.btn_Show_Images);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Image_Description);
            this.Controls.Add(this.tb_Image_ID);
            this.Controls.Add(this.lbl_Image_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Image";
            this.Load += new System.EventHandler(this.Add_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_Image_ID;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Image_Id;
        private System.Windows.Forms.TextBox tb_Image_Description;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Show_Images;
        private System.Windows.Forms.Button btn_Search_Image;
        private System.Windows.Forms.PictureBox pb_Add_Image;
    }
}

