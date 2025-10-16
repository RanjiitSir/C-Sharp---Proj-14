
namespace Picture_Box_Use
{
    partial class Show_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Image));
            this.pb_Add_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.btn_Search_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Add_Image
            // 
            this.pb_Add_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Add_Image.Location = new System.Drawing.Point(32, 105);
            this.pb_Add_Image.Name = "pb_Add_Image";
            this.pb_Add_Image.Size = new System.Drawing.Size(372, 278);
            this.pb_Add_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_Image.TabIndex = 19;
            this.pb_Add_Image.TabStop = false;
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image.Location = new System.Drawing.Point(171, 69);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(59, 22);
            this.lbl_Image.TabIndex = 17;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Uighur", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(351, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(170, 56);
            this.lbl_Header.TabIndex = 18;
            this.lbl_Header.Text = "Show Image";
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.AllowUserToAddRows = false;
            this.dgv_Image_List.AllowUserToDeleteRows = false;
            this.dgv_Image_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(491, 105);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.ReadOnly = true;
            this.dgv_Image_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Image_List.Size = new System.Drawing.Size(369, 278);
            this.dgv_Image_List.TabIndex = 20;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged);
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Add_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Add_Image.Location = new System.Drawing.Point(535, 442);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(180, 42);
            this.btn_Add_Image.TabIndex = 21;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image_List.Location = new System.Drawing.Point(623, 69);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(92, 22);
            this.lbl_Image_List.TabIndex = 17;
            this.lbl_Image_List.Text = "Image List";
            // 
            // btn_Search_Image
            // 
            this.btn_Search_Image.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Search_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Image.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Search_Image.Location = new System.Drawing.Point(190, 442);
            this.btn_Search_Image.Name = "btn_Search_Image";
            this.btn_Search_Image.Size = new System.Drawing.Size(180, 42);
            this.btn_Search_Image.TabIndex = 22;
            this.btn_Search_Image.Text = "Search Images";
            this.btn_Search_Image.UseVisualStyleBackColor = false;
            this.btn_Search_Image.Click += new System.EventHandler(this.btn_Search_Image_Click);
            // 
            // Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_Search_Image);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Add_Image);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Image";
            this.Load += new System.EventHandler(this.Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Add_Image;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.Button btn_Search_Image;
    }
}