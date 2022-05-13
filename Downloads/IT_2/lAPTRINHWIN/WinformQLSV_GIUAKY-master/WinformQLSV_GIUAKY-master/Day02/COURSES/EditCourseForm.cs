using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            COURSES course = new COURSES();
            if (tb_Label.Text.Trim() == "")
            {
                MessageBox.Show("Edit A Course Name", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (course.checkCourseName(tb_Label.Text, Convert.ToInt32( comboBox_CourseID.Text)))
            {
                if (course.editCourse(comboBox_CourseID.Text, tb_Label.Text, numericUpDown1.Text, tb_Des.Text))
                {
                    MessageBox.Show("Course Edited", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Course Not Available", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.myDBDataSet.course);
            comboBox_CourseID.DataSource = course.getAllCourses();
            comboBox_CourseID.DisplayMember = "id";
            comboBox_CourseID.ValueMember = "id";
            comboBox_CourseID.SelectedItem = "1";
        }

        private void comboBox_CourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox_CourseID.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                tb_Label.Text = table.Rows[0][1].ToString();
                numericUpDown1.Value = Int32.Parse(table.Rows[0][2].ToString());
                tb_Des.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }
    }
}
