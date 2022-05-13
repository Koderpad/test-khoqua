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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        private void bt_AddCourse_Click(object sender, EventArgs e)
        {
            if (tb_Label.Text.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (course.checkCourseName(tb_Label.Text))
            {
                if (course.insertCourse(tb_CourseID.Text, tb_Label.Text, tb_Period.Text, tb_Description.Text))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
