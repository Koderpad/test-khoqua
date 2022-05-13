using System;
using System.Collections;
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
    public partial class ManageCoursesForm : Form
    {
        public ManageCoursesForm()
        {
            InitializeComponent();
        }
        int pos;
        COURSES courses = new COURSES();
        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataInSql.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.dataInSql.course);
            reloadListBoxData();
        }

        void reloadListBoxData()
        {
            listBoxCourses.DataSource = courses.getAllCourses();
            listBoxCourses.ValueMember = "Id";
            listBoxCourses.DisplayMember = "label";
            listBoxCourses.SelectedItem = null;

            lb_totalCourses.Text = ("Total Courses: " + courses.totalCourses());
        }

        void showData(int index)
        {
            DataRow dr = courses.getAllCourses().Rows[index];
            listBoxCourses.SelectedIndex = index;

            tb_ID.Text = dr.ItemArray[0].ToString();
            tb_Label.Text = dr.ItemArray[1].ToString();
            numericUpDown_hoursNum.Value = Convert.ToInt32(dr.ItemArray[2].ToString());
            tb_Description.Text = dr.ItemArray[3].ToString();
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            //DataRowView drv = (DataRowView)listBoxCourses.SelectedItem;
            pos = listBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_Label.Text.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (courses.checkCourseName(tb_Label.Text))
            {
                if (courses.insertCourse(tb_ID.Text, tb_Label.Text, numericUpDown_hoursNum.Value.ToString(), tb_Description.Text))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reloadListBoxData();
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

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (tb_Label.Text.Trim() == "")
            {
                MessageBox.Show("Edit A Course Name", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (courses.checkCourseName(tb_Label.Text,Convert.ToInt32( tb_ID.Text)))
            {
                if (courses.editCourse(tb_ID.Text, tb_Label.Text, numericUpDown_hoursNum.Value.ToString(), tb_Description.Text))
                {
                    MessageBox.Show("Course Edited", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reloadListBoxData();
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

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (courses.removeCourse(tb_ID.Text))
            {
                MessageBox.Show("Success remove!!", "Annouce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Fail remove!!", "Annouce", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            if (pos < (courses.getAllCourses().Rows.Count - 1))
            {
                pos += 1;
                showData(pos);
            }
        }

        private void bt_Pre_Click(object sender, EventArgs e)
        {
            if (pos > (courses.getAllCourses().Rows.Count - 1))
            {
                pos -= 1;
                showData(pos);
            }
        }

        private void bt_Last_Click(object sender, EventArgs e)
        {
            pos = courses.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
