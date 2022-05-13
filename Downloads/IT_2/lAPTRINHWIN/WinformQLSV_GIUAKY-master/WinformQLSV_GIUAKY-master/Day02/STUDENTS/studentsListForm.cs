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
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void studentsListForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            //            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            //this.stdTableAdapter.Fill(this.myDBDataSet1.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;
            //xử lý hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count!=0)
            {
                UpdateDeleteStudentForm s = new UpdateDeleteStudentForm();
                s.tb_ID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                s.tb_StuID.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                s.tb_firstName.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
                s.tb_lastName.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
                s.dateTimePicker_birthDate.Value = (DateTime)DataGridView1.CurrentRow.Cells[4].Value;

                if ((DataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Female"))
                {
                    s.radioButton_Female.Checked = true;
                    //s.radioButton_Male.Checked = true;
                }
                else
                {
                    s.radioButton_Male.Checked = true;
                    //s.radioButton_Female.Checked = false;
                }

                s.tb_Phone.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
                s.tb_Address.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();

                //code process image
                byte[] pic;
                pic = (byte[])DataGridView1.CurrentRow.Cells[8].Value;
                MemoryStream picture = new MemoryStream(pic);
                s.pictureBox1.Image = Image.FromStream(picture);


                this.Show();
                s.Show();
            }
            else
            {
                MessageBox.Show("There are no students", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
