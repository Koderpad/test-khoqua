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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        MY_DB mydB = new MY_DB();
        SCORE score = new SCORE();
        private void ResultForm_Load(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("select * from Course", mydB.getConnection);
            mydB.openConnection();
            var dataReader = command1.ExecuteReader();
            string columns = "";
            int countCourse = 0;
            //countCourse = dataReader.FieldCount;
            while (dataReader.Read())
            {
                columns = columns + " [" + dataReader["label"].ToString() + "],";
                countCourse++;
            }
            mydB.closeConnection();
            columns = columns.TrimEnd(',');
            //label3.Text = columns;
            dataGridView1.DataSource = score.getResultCourseScoreStudent(columns);
            dataGridView1.Columns.Add("res", "Results");

            float stdScore = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                stdScore = 0;
                 for (int j = 0; j < countCourse; j++)
                {
                    stdScore += (float) Convert.ToDouble(dataGridView1.Rows[i].Cells[3 + j].Value);
                }
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value =Math.Round( stdScore/countCourse,2);
            }


            /////////////////////
            ///
 /*           MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tableUser = new DataTable();
            SqlCommand command = new SqlCommand("select * from (select std.id as stdid,fname, lname, COURSE.id as courseid, LABEL  from std, course) as q left join score on stdid = student_id and courseid = course_id", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableUser);

            DataTable tableCourse = new DataTable();
            command = new SqlCommand("select * from course", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableCourse);

            int nCourse = tableCourse.Rows.Count;
            int nUser = tableUser.Rows.Count;
            int total = nUser / nCourse;
            dataGridView1.Columns.Add("id", "Student ID");
            dataGridView1.Columns.Add("fname", "First Name");
            dataGridView1.Columns.Add("lname", "Last Name");
            foreach (DataRow VARIABLE in tableCourse.Rows)
            {
                dataGridView1.Columns.Add(VARIABLE["id"].ToString(), VARIABLE["label"].ToString());
            }
            dataGridView1.Columns.Add("av", "Average Score");
            dataGridView1.Columns.Add("res", "Results");
            double tong = 0;
            int dem = 1;
            for (int i = 0; i < total; i++)
            {
                dataGridView1.Rows.Add((DataGridViewRow)dataGridView1.Rows[0].Clone());
                dataGridView1.Rows[i].Cells[0].Value = tableUser.Rows[i + i * nCourse][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = tableUser.Rows[i + i * nCourse][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = tableUser.Rows[i + i * nCourse][2].ToString();
                tong = dem = 0;
                for (int j = 0; j < nCourse; j++)
                {
                    if (tableUser.Rows[j + i * nCourse][7].ToString().Trim() != "")
                    {
                        tong += Convert.ToDouble(tableUser.Rows[j + i * nCourse][7].ToString());
                        dem += 1;
                    }
                    dataGridView1.Rows[i].Cells[3 + j].Value = tableUser.Rows[j + i * nCourse][7].ToString();
                }

                if (dem != 0)
                {
                    double diem = (tong * 1.0 / dem);
                    dataGridView1.Rows[i].Cells[3 + nCourse].Value = Math.Round(diem, 2);
                    dataGridView1.Rows[i].Cells[4 + nCourse].Value = diem > 5 ? "Đạt" : "Rớt";
                }
            }*/
        }
    }
}
