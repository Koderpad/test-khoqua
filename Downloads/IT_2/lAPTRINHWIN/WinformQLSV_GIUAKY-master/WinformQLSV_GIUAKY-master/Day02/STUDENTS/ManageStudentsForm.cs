using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        MY_DB mdb = new MY_DB();
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM std",mdb.getConnection);
            /* dataGridView1.ReadOnly = true;
             //xử lý hình ảnh
             DataGridViewImageColumn picCol = new DataGridViewImageColumn();
             dataGridView1.RowTemplate.Height = 80;
             dataGridView1.DataSource = student.getStudents(cmd);
             dataGridView1.AllowUserToAddRows = false;*/
            fillFGrid(cmd);
        }

        private void fillFGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            label_totalStd.Text = ("Toltal Students: " + dataGridView1.Rows.Count);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + textBox_Search.Text + "%'");
            fillFGrid(cmd);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_stuID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_fNAME.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_lName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;

                if ((dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Female"))
                {
                    radioButton_Fe.Checked = true;
                    //radioButton_Male.Checked = true;
                }
                else
                {
                    radioButton_Male.Checked = true;
                    //radioButton_Female.Checked = false;
                }

                textBox_Phone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox_Address.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                //code process image
                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            //int id = Convert.ToInt32(textBox_ID.Text);
            string Stuid = tb_stuID.Text;
            string fname = textBox_fNAME.Text;
            string lname = textBox_lName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_Phone.Text;
            string adr = textBox_Address.Text;
            string gender = "Male";

            if (radioButton_Fe.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK);
            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if ((student.insertStudent(Stuid, fname, lname, bdate, gender, phone, adr, pic)))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillFGrid(new SqlCommand("SELECT * FROM std"));
        }

        bool verif()
        {
            if ((textBox_fNAME.Text.Trim() == "")
                    || (textBox_lName.Text.Trim() == "")
                    || (textBox_Phone.Text.Trim() == "")
                    || (pictureBox1.Image == null)
                    )
            {
                return false;
            }
            else return true;
        }

        private void button_UpdatePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            //int id;
            string studId = tb_stuID.Text;
            string fname = textBox_fNAME.Text;
            string lname = textBox_lName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_Phone.Text;
            string adr = textBox_Address.Text;
            string gender = "Male";

            if (radioButton_Fe.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK);
            }
            else if (verif())
            {
                //id = Convert.ToInt32(textBox_ID.Text);
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                try
                {
                    if ((student.updateStudent( studId, fname, lname, bdate, gender, phone, adr, pic)))
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
            fillFGrid(new SqlCommand("SELECT * FROM std"));

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = Convert.ToInt32(textBox_ID.Text);
                if ((MessageBox.Show("Are you sure you want to delete this student", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                {
                    if ((student.deleteStudent(tb_stuID.Text)))
                    {
                        foreach (Control i in Controls)
                        {
                            if (i is TextBox)
                            {
                                i.Text = "";
                            }
                        }
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox1.Image = null;
                        radioButton_Male.Checked = false;
                        radioButton_Fe.Checked = false;

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
            fillFGrid(new SqlCommand("SELECT * FROM std"));
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            foreach(Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }

            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
            radioButton_Fe.Checked = false;
            radioButton_Male.Checked = false;
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + tb_stuID.Text);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image in the picturebox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + "." + ImageFormat.Jpeg.ToString()));
            }
        }
    }
}
