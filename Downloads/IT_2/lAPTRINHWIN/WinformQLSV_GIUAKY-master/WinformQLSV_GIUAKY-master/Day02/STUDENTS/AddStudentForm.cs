using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void bt_CancelAddStudentForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_AddStudentForm_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            //int id = Convert.ToInt32(tb_StudentID_AddStudentForm.Text);
            string stuId = tb_StuID.Text;
            string fname = tb_FirstName_AddStudentForm.Text;
            string lname = tb_LastName_AddStudentForm.Text;
            DateTime bdate = dateTimePicker_BirthDate_AddStudentForm.Value;
            string phone = tb_Phone_AddStudentForm.Text;
            string adr = tb_Address_AddStudentForm.Text;
            string gender = "Male";

            if (radioButton_Female_AddStudentForm.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker_BirthDate_AddStudentForm.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK);
            }
            else if (verif())
            {
                pictureBox_AddStudentForm.Image.Save(pic, pictureBox_AddStudentForm.Image.RawFormat);
                if ((student.insertStudent(stuId, fname, lname, bdate, gender, phone, adr, pic)))
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

        }
        bool verif()
        {
            if ((tb_FirstName_AddStudentForm.Text.Trim() == "")
                    || (tb_LastName_AddStudentForm.Text.Trim() == "")
                    || (tb_Phone_AddStudentForm.Text.Trim() == "")
                    || (pictureBox_AddStudentForm.Image == null
                    || (tb_StuID.Text.Trim()) == "")
                    )
            {
                return false;
            }
            else return true;
        }

        private void bt_UploadImage_AddStudentForm_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_AddStudentForm.Image = Image.FromFile(opf.FileName);
            }
        }

        private void tb_StuID_MouseMove(object sender, MouseEventArgs e)
        {
            if (tb_StuID.Text != "")
            {
                STUDENT std = new STUDENT();
                if (std.checkStdID((tb_StuID.Text)))
                {
                    MessageBox.Show("Student ID đã tồn tại!!, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    MessageBox.Show("Student ID được kiểm tra thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
