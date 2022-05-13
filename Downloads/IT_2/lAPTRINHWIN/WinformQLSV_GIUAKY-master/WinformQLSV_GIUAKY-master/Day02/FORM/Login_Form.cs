using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            textBox_UserName.Text = "user01";
            textBox_passWord.Text = "123";
        }

        Form_registration form_Open = new Form_registration();

        private void bt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT *FROM login WHERE username = @User AND password = @Password", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBox_passWord.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                progressBar_login.Show();
                progressBar_login.Minimum = 0;
                progressBar_login.Maximum = 10;
                progressBar_login.Step = 2;
                for (int i = 0; i < 10; i += 2)
                {
                    Thread.Sleep(200);

                    progressBar_login.PerformStep();
                    progressBar_login.Update();
                }
                //MessageBox.Show("OK, next time will be go to Main Menu of App","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("../../images/image1.png");
            //pictureBox1.Image = Image.FromFile("C:/Users/Dell/Downloads/IT_2/lAPTRINHWIN/day2/Day02/Day02/images/Anonymous_emblem.svg.png");
            progressBar_login.Hide();
        }

        private void bt_createNUser_Click(object sender, EventArgs e)
        {
            form_Open.ShowDialog();
        }
    }
}
