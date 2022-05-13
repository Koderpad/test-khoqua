using System;
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

namespace Day02
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
            
        }
        public bool Flag = true;
        MY_DB myDB = new MY_DB();
        STUDENT student = new STUDENT();

        /*private void find_Gender()
        {
            string gender = "Male";
            if (radioButton_Female.Checked == true)
            {
                gender = "Female";
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE gender LIKE '" + gender + "'", myDB.getConnection);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE phone = " + phone, myDB.getConnection);
            STUDENT s = new STUDENT();
            DataTable table = s.getStudents(cmd);

            if (table.Rows.Count > 0)
            {
                tb_ID.Text = table.Rows[0]["id"].ToString();
                tb_firstName.Text = table.Rows[0]["fname"].ToString();
                tb_lastName.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker_birthDate.Value = (DateTime)table.Rows[0]["bdate"];

                //gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButton_Female.Checked = true;
                }
                else
                    radioButton_Male.Checked = true;

                //tb_Phone.Text = table.Rows[0]["phone"].ToString();
                tb_Address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

                label8.Show();
                pictureBox1.Show();
                bt_uploadImage.Show();
            }
        }*/

        private void find_Phone()
        {

            //int phone = int.Parse(tb_ID.Text);
            string phone = tb_Phone.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE phone LIKE '"+phone+"'", myDB.getConnection);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE phone = " + phone, myDB.getConnection);
            STUDENT s = new STUDENT();
            DataTable table = s.getStudents(cmd);

            if (table.Rows.Count > 0)
            {
                tb_ID.Text = table.Rows[0]["id"].ToString();
                tb_firstName.Text = table.Rows[0]["fname"].ToString();
                tb_lastName.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker_birthDate.Value = (DateTime)table.Rows[0]["bdate"];

                //gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButton_Female.Checked = true;
                }
                else
                    radioButton_Male.Checked = true;

                //tb_Phone.Text = table.Rows[0]["phone"].ToString();
                tb_Address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

                label8.Show();
                pictureBox1.Show();
                bt_uploadImage.Show();

            }
            else
                MessageBox.Show("Not found!!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void find_ID()
            {
            myDB.openConnection();

            //find ID
            int id = int.Parse(tb_ID.Text);
            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE id = "+id,myDB.getConnection);

            STUDENT s = new STUDENT();
            DataTable table = s.getStudents(cmd);

            if (table.Rows.Count > 0)
            {
                tb_firstName.Text = table.Rows[0]["fname"].ToString();
                tb_lastName.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker_birthDate.Value = (DateTime)table.Rows[0]["bdate"];

                //gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButton_Female.Checked = true;
                }
                else
                    radioButton_Male.Checked = true;

                tb_Phone.Text = table.Rows[0]["phone"].ToString();
                tb_Address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

                label8.Show();
                pictureBox1.Show();
                bt_uploadImage.Show();
                //end find ID
                }
            else
                MessageBox.Show("Not found!!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BT_find_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                find_ID();
                bt_Edit.Show();
                bt_Remove.Show();
                BT_find.Show();
                BackColor = Color.LimeGreen;
            }
            if (tb_Phone.Text != "")
            {
                find_Phone();
                bt_Edit.Show();
                bt_Remove.Show();
                BT_find.Show();
                BackColor = Color.LimeGreen;
            }
            if (tb_firstName.Text!="" || tb_lastName.Text!="")
            {
                bt_Edit.Show();
                bt_Remove.Show();
                BT_find.Show();
                BackColor = Color.LimeGreen;
                string searchName = tb_firstName.Text + tb_lastName.Text;
                FindStudentsForm findStd = new FindStudentsForm();
                findStd.cmd = "SELECT * FROM std WHERE CONCAT(fname,lname) LIKE '%" + searchName + "%'";
                findStd.ShowDialog(this);
            }
            if (radioButton_Female.Checked ==true || radioButton_Male.Checked==true)
            {
                bt_Edit.Show();
                bt_Remove.Show();
                BT_find.Show();
                BackColor = Color.LimeGreen;
                string gender = "Male";
                if (radioButton_Female.Checked)
                {
                    gender = "Female";
                }
                FindStudentsForm findStd = new FindStudentsForm();

                findStd.cmd = "SELECT * FROM std WHERE gender = '"+gender+"'";
                findStd.ShowDialog(this);
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            int id;
            string studId = tb_StuID.Text;
            string fname = tb_firstName.Text;
            string lname = tb_lastName.Text;
            DateTime bdate = dateTimePicker_birthDate.Value;
            string phone = tb_Phone.Text;
            string adr = tb_Address.Text;
            string gender = "Male";

            if (radioButton_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker_birthDate.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK);
            }
            else if (verif())
            {
                id = Convert.ToInt32(tb_ID.Text);
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                try
                {
                    if ((student.updateStudent(studId, fname, lname, bdate, gender, phone, adr, pic)))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edits Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        bool verif()
        {
            if ((tb_firstName.Text.Trim() == "")
                    || (tb_lastName.Text.Trim() == "")
                    || (tb_Phone.Text.Trim() == "")
                    || (pictureBox1.Image == null)
                    )
            {
                return false;
            }
            else return true;
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = Convert.ToInt32(tb_ID.Text);
                if ((MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                {
                    if ((student.deleteStudent(tb_StuID.Text)))
                    {


                        foreach (Control i in Controls)
                        {
                            if (i is TextBox)
                            {
                                i.Text = "";
                            }
                        }
                        dateTimePicker_birthDate.Value = DateTime.Now;
                        pictureBox1.Image = null;
                        radioButton_Male.Checked = false;
                        radioButton_Female.Checked = false;

                        MessageBox.Show("Delete Success", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM std",myDB.getConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

/*            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxSearch.Items.Add(ds.Tables[0].Rows[i][0] + " " + ds.Tables[0].Rows[i][1] + " " + ds.Tables[0].Rows[i][2]);
            }*/

            for (int i = 0; i < ds.Tables[0].Columns.Count-1; i++)
            {
                comboBoxSearch.Items.Add(ds.Tables[0].Columns[i].ColumnName);
            }
            comboBoxSearch.Enabled = true;
        }
    }
}
