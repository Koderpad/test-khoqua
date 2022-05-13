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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        COURSES courses = new COURSES();
        STUDENT students = new STUDENT();
        SCORE scores = new SCORE();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = courses.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "Id";

            SqlCommand cmd = new SqlCommand("select id_student,fname,lname from std");
            dataGridView1.DataSource = students.getStudents(cmd);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tb_StdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void bt_AddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int stdId = Convert.ToInt32(tb_StdID.Text);
                int cId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                double score = Convert.ToDouble(tb_Score.Text);
                string des = tb_Des.Text;

                if (scores.studentScoreExist(stdId, cId))
                {

                    if (scores.insertScore(stdId, cId, (float)score, des))
                    {
                        MessageBox.Show("sTUDENT Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else
                    {
                        MessageBox.Show("sTUDENT Score not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("The score for this course are already set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
