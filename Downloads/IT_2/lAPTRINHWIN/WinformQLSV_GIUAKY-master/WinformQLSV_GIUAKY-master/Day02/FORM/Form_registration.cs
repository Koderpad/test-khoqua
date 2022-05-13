using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Day02
{
    public partial class Form_registration : Form
    {
        public Form_registration()
        {
            InitializeComponent();
        }

        private void bt_Regis_Click(object sender, EventArgs e)
        {
            if (tb_userRegis.Text == "" && tb_PasswordRegis.Text == "" && tb_rePasswordRegis.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_PasswordRegis.Text == tb_rePasswordRegis.Text&&tb_userRegis.Text!=""
                && tb_PasswordRegis.Text!="")
            {

                MY_DB dbs = new MY_DB();
                //
                SqlCommand cmd = new SqlCommand("SELECT username From login WHERE username=@id", dbs.getConnection);
                SqlConnection db1 = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tb_userRegis.Text;
                db1.Open();
                dbs.openConnection();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("Bị trùng userID!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db1.Close();
                    foreach (Control i in this.Controls)
                    {
                        if (i is TextBox)
                        {
                            i.Text = "";
                        }
                    }
                    return;
                }
                else
                {
                    rd.Close();
                    //
                    SqlCommand commands = new SqlCommand("SELECT MAX(login.Id) as res FROM login", dbs.getConnection);

                    int num_ = 0;

                    try
                    {
                        dbs.openConnection();
                        using (SqlDataReader read = commands.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                num_ = Int32.Parse(read["res"].ToString());
                            }
                        }

                    }
                    finally
                    {
                        dbs.closeConnection();
                    }

                    num_ += 1;
                    /*                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
                                    SqlCommand commands = new SqlCommand("SELECT MAX(login.Id) as result FROM login", con);

                                    int num_ = 0;
                                    con.Open();
                                    SqlDataReader dr = commands.ExecuteReader();
                                    if (dr.HasRows)
                                    {
                                        while (dr.Read())
                                        {
                                            num_ = Int32.Parse(dr["result"].ToString());
                                        }
                                    }
                                    con.Close();
                                    num_ += 1;*/

                    SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");


                    string register = @"INSERT INTO [myDB].[dbo].[login]"
                        + "([Id],[username],[password]) VALUES ('" + num_ + "','" + tb_userRegis.Text + "','" + tb_PasswordRegis.Text + "')";
                    SqlCommand command = new SqlCommand(register, db);
                    db.Open();
                    command.ExecuteNonQuery();
                    db.Close();

                    MessageBox.Show("You Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    foreach (Control i in this.Controls)
                    {
                        if (i is TextBox)
                        {
                            i.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_PasswordRegis.Text = "";
                tb_rePasswordRegis.Text = "";
                tb_PasswordRegis.Focus();
            }
        }

        private void tb_rePasswordRegis_Leave(object sender, EventArgs e)
        {
/*            if(tb_rePasswordRegis.Text != tb_PasswordRegis.Text)
            {
                MessageBox.Show("Rewrite","Notice",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_rePasswordRegis.Focus();
                return;
            }
            else
            {
               MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }*/
        }

/*        private void button_checkUser_Click(object sender, EventArgs e)
        {
            if (tb_userRegis.Text != "")
            {
                MY_DB dbs = new MY_DB();
                //
                SqlCommand cmd = new SqlCommand("SELECT username From login WHERE username=@id", dbs.getConnection);
                SqlConnection db1 = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tb_userRegis.Text;
                db1.Open();
                dbs.openConnection();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("Username đã tồn tại!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db1.Close();
                    foreach (Control i in this.Controls)
                    {
                        if (i is TextBox)
                        {
                            i.Text = "";
                        }
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Username được kiểm tra thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Username!", "Kiểm tra tính duy nhất Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/

        private void tb_userRegis_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_userRegis.Text != "")
            {
                MY_DB dbs = new MY_DB();
                //
                SqlCommand cmd = new SqlCommand("SELECT * From login WHERE username=@id", dbs.getConnection);
                SqlConnection db1 = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");

                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tb_userRegis.Text;
                db1.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Username đã tồn tại!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db1.Close();
                    foreach (Control i in this.Controls)
                    {
                        if (i is TextBox)
                        {
                            i.Text = "";
                        }
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Username được kiểm tra thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
