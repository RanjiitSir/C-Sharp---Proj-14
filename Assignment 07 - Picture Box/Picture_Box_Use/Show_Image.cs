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
    public partial class Show_Image : Form
    {
        public Show_Image()
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
        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            Add_Image Obj = new Add_Image();
            Obj.Show();
            this.Hide();
        }

        void Bind_Grid(string Query, DataGridView DGV)
        {
            Con_Open();

            DGV.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            DGV.DataSource = dt;

            Con_Close();
        }

        void View_Image(string Query, PictureBox pb)
        {
            Con_Open();

            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image ID!!!");
            }

            Con_Close();
        }

        private void Show_Image_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Image_Id, Image_Description from Nature_Images ", dgv_Image_List);
        }

        private void dgv_Image_List_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgv_Image_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                int Index = dgv_Image_List.SelectedCells[0].RowIndex;

                int ID = Convert.ToInt32(dgv_Image_List.Rows[Index].Cells[0].Value);

                View_Image("Select Image From Nature_Images where Image_Id = " + ID + "", pb_Add_Image);
            }
        }

        private void btn_Search_Image_Click(object sender, EventArgs e)
        {
            frm_Search_Image Obj = new frm_Search_Image();
            Obj.Show();
            this.Hide();
        }
    }
}
