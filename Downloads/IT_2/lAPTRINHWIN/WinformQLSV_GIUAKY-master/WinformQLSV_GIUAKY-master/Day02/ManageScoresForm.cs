using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class ManageScoresForm : Form
    {
        public ManageScoresForm()
        {
            InitializeComponent();
        }
        Boolean flag = false;
        COURSES courses = new COURSES();
        STUDENT students = new STUDENT();
        SCORE scores = new SCORE();
        private void ManageScoresForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = courses.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "Id";

            //dataGridView1.DataSource = scores.getScore();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
/*            tb_StdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxCourse.ValueMember = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_Score.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_Des.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();*/
        }

        private void bt_showStd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select id_student as studentID, fname as First_Name, lname as Last_Name, bdate as birth_Day  from std");
            dataGridView1.DataSource = students.getStudents(command);
            dataGridView1.Columns[0].HeaderCell.Value = "Student ID";
            dataGridView1.Columns[1].HeaderCell.Value = "First Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Last Name";
            dataGridView1.Columns[3].HeaderCell.Value = "birth day";
            flag = false;
        }

        private void bt_showScore_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = scores.getStudentCourseScore();
            dataGridView1.Columns[0].HeaderCell.Value = "Student ID";
            dataGridView1.Columns[1].HeaderCell.Value = "First Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Last Name";
            dataGridView1.Columns[3].HeaderCell.Value = "Course ID";
            dataGridView1.Columns[4].HeaderCell.Value = "Label";
            dataGridView1.Columns[5].HeaderCell.Value = "Score Course";
            
            flag = true;
        }

        private void bt_AvgSByCourse_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScoreBy = new avgScoreByCourseForm();
            avgScoreBy.ShowDialog(Owner);
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (flag == true)
            {
                tb_StdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //comboBoxCourse.ValueMember = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBoxCourse.SelectedIndex =Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString())-1;
                tb_Score.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //tb_Des.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
