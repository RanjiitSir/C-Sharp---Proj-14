using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Titan_Shop_Mgt_System.Windows_Forms
{
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Titan_Watch_Shop_Mgt_System_DB;Integrated Security=True");

        int pCnt = 1, C_Stock = 0;

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Customer_ID) from Customer_Details", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Customer_ID) from Customer_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 10001;
            }

            Con_Close();

            return Cnt;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        void Bind_ComboBox()
        {
            Con_Open();

            cmb_Category.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Distinct(Category_Name) From Category_Details";
            Cmd.Connection = Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());

            dtp_Bill_Date.ResetText();
            tb_Customer_Name.Clear();
            tb_Customer_Mob_No.Clear();

            pCnt = 1;
            C_Stock = 0;

            tb_Quantity.Text = "0";
            tb_Discount.Text = "0";
            tb_GST.Text = "0";
            tb_Bill.Text = "0";
            tb_Price.Text = "0";
            tb_Total_Price.Text = "0";
            tb_Total_Bill.Text = "0";
            dgv_Purchase_Details.Rows.Clear();

            cmb_Category.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            tb_Customer_Name.Focus();
            Bind_ComboBox();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cmb_Model_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Watch_Model_Name) From Watch_Model_Details where Watch_Category = '" + cmb_Category.Text + "'", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Watch_Model_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void cmb_Model_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();
            C_Stock = 0;

            SqlCommand Cmd = new SqlCommand("Select Sales_Rate, Current_Stock From Watch_Model_Details where Watch_Category = '" + cmb_Category.Text + "'  And Watch_Model_Name = '" + cmb_Model_Name.Text + "' ", Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Price.Text = (obj["Sales_Rate"].ToString());
                C_Stock = Convert.ToInt32(obj["Current_Stock"]);
            }

            tb_Quantity.Enabled = true;

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            double Tot = 0;

            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                Tot = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Price.Text);

                tb_Total_Price.Text = Convert.ToString(Tot);
            }

            btn_Add.Enabled = true;
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if (tb_Quantity.Text == "" || tb_Quantity.Text == "0")
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Quantity.Text = "0";
                tb_Quantity.Focus();
                btn_Add.Enabled = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

            for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[2].Value) == cmb_Model_Name.Text)
                {
                    flag = 0;

                    Qty += Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[4].Value);

                    if (C_Stock >= Qty)
                    {
                        double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Price.Text);

                        dgv_Purchase_Details.Rows[i].Cells[4].Value = Qty;
                        dgv_Purchase_Details.Rows[i].Cells[5].Value = Tot_Price;
                    }
                    else
                    {
                        MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }
            }

            if (flag == -1)
            {
                if (C_Stock >= Qty)
                {
                    dgv_Purchase_Details.Rows.Add(pCnt, cmb_Category.Text, cmb_Model_Name.Text, tb_Price.Text, tb_Quantity.Text, tb_Total_Price.Text);

                    pCnt++;
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = 1;
                }
            }

            if (flag < 1)
            {
                double Bill = Convert.ToDouble(tb_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                tb_Bill.Text = Convert.ToString(Bill);
                tb_Total_Bill.Text = Convert.ToString(Bill);
            }

            cmb_Category.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;

            tb_Price.Clear();
            tb_Quantity.Text = "0";
            tb_Total_Price.Clear();

            tb_Quantity.Enabled = false;

            btn_Add.Enabled = false;
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "")
            {
                double GST = Convert.ToDouble(tb_Bill.Text) * (Convert.ToDouble(tb_GST.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Total_Bill.Text) + GST;

                tb_Total_Bill.Text = Convert.ToString(Tot_Bill);

                btn_Save.Enabled = true;
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "")
            {
                double Disc = Convert.ToDouble(tb_Bill.Text) * (Convert.ToDouble(tb_Discount.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Total_Bill.Text) - Disc;

                tb_Total_Bill.Text = Convert.ToString(Tot_Bill);

                btn_Save.Enabled = true;
            }
        }

        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if (tb_GST.Text == "")
            {
                MessageBox.Show("GST Should be Zero or Positive Value!!!");
                tb_GST.Text = "0";
                tb_GST.Focus();
                btn_Save.Enabled = false;
            }
        }

        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Customer_Name.Text != "" || tb_Customer_Mob_No.Text != "" || pCnt > 1 || tb_Bill.Text != "" || tb_Total_Bill.Text != "" || tb_GST.Text != "" || tb_Discount.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_Name.Text != "" && tb_Customer_Mob_No.Text != "" && pCnt > 1 && tb_Bill.Text != "" && tb_Total_Bill.Text != "" && tb_GST.Text != "" && tb_Discount.Text != "")
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Customer_Details Values (@C_ID, @C_Name, @C_Mob_No, @Bill_Date, @Bill_Amount, @GST, @Disc, @Total_Bill) ", Con);

                cmd.Parameters.Add("@C_ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                cmd.Parameters.Add("@C_Name", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                cmd.Parameters.Add("@C_Mob_No", SqlDbType.Decimal).Value = tb_Customer_Mob_No.Text;
                cmd.Parameters.Add("@Bill_Date", SqlDbType.Date).Value = dtp_Bill_Date.Value.Date;
                cmd.Parameters.Add("@Bill_Amount", SqlDbType.Money).Value = tb_Bill.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("@Disc", SqlDbType.Float).Value = tb_Discount.Text;
                cmd.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = tb_Total_Bill.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert Into Customer_Purchase_Details Values (@ID, @Cat, @M_Name, @Price, @Qty, @Tot_Price )", Con);

                    cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    cmd1.Parameters.Add("@Cat", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd1.Parameters.Add("@M_Name", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd1.Parameters.Add("@Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd1.Parameters.Add("@Qty", SqlDbType.Int).Value = dgv_Purchase_Details.Rows[i].Cells[4].Value;
                    cmd1.Parameters.Add("@Tot_Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[5].Value;

                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();

                    int Saled_Qty = Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[4].Value); // 3
                    int P_C_Stock = 0;
                    int W_ID = 0;
                    int New_Stock = 0;

                    cmd1.CommandText = "Select Watch_ID, Current_Stock From Watch_Model_Details where Watch_Category = '" + dgv_Purchase_Details.Rows[i].Cells[1].Value + "' And Watch_Model_Name = '" + dgv_Purchase_Details.Rows[i].Cells[2].Value + "'";
                    cmd1.Connection = Con;

                    SqlDataReader obj = cmd1.ExecuteReader();

                    if (obj.Read())
                    {
                        W_ID = Convert.ToInt32((obj["Watch_ID"].ToString()));   // 101
                        P_C_Stock = Convert.ToInt32((obj["Current_Stock"].ToString()));  /// 100
                    }

                    New_Stock = P_C_Stock - Saled_Qty;   // 100 - 3 = 97
                    obj.Close();
                    cmd1.Dispose();

                    SqlDataAdapter sda = new SqlDataAdapter("Update Watch_Model_Details Set Current_Stock = " + New_Stock + " where Watch_ID = " + W_ID + "", Con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }

                MessageBox.Show("Customer Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Fill Customer & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Customer_Name.Text != "" || tb_Customer_Mob_No.Text != "" || pCnt > 1 || tb_Bill.Text != "" || tb_Total_Bill.Text != "" || tb_GST.Text != "" || tb_Discount.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
