﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_Use
{
    public partial class frm_Search_Image : Form
    {
        public frm_Search_Image()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\Sqlexpress;Initial Catalog=Natures_Images_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Image_ID.Clear();
            tb_Image_Description.Clear();
            pb_Add_Image.Image = null;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Image_ID.Text != "") 
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Nature_Images where Image_Id = @IId";

                Cmd.Parameters.Add("IID", SqlDbType.Int).Value = tb_Image_ID.Text;

                SqlDataAdapter da = new SqlDataAdapter("Select * From Nature_Images where Image_Id = " + tb_Image_ID.Text + "", Con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Image_Description.Text = Dr.GetString(Dr.GetOrdinal("Image_Description"));
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pb_Add_Image.Image = new Bitmap(ms);
                }
                else
                {
                    MessageBox.Show("Inavalid ID");
                    Clear_Controls();
                }

                Con_Close();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Show_Images_Click(object sender, EventArgs e)
        {
            Show_Image Obj = new Show_Image();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            Add_Image Obj = new Add_Image();
            Obj.Show();
            this.Hide();
        }

        private void frm_Search_Image_Load(object sender, EventArgs e)
        {

        }
    }
}
