using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class SCORE
    {
        MY_DB db = new MY_DB();
        public bool insertScore(int stdId, int cId,float score, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT into score values(@stdId,@cId,@score,@des)", db.getConnection);
            cmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = cId;
            cmd.Parameters.Add("@score", SqlDbType.Float).Value = score;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = description;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool studentScoreExist(int stdId, int cId)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM score WHERE student_id=@stdId and course_id=@cId", db.getConnection);
            cmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = cId;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
                return false;
        }

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = "select course.label, avg(score)" +
                " from course inner join score on course.Id = score.course_id" +
                " group by course.label ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool deleteScore(int stdId, int cId)
        {
            SqlCommand cmd = new SqlCommand("Delete FROM score WHERE student_id=@stdId and course_id=@cId", db.getConnection);
            cmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = cId;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getScore()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM score", db.getConnection);
            DataTable courses = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, db.getConnection);
            da.Fill(courses);

            return courses;
        }

        public DataTable getStudentCourseScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;
            command.CommandText = "select std.id_student as student_id, std.fname, std.lname, c.Id as course_id, c.label, s.score " +
                "from std inner join score s on std.id_student = s.student_id inner join course c on s.course_id = c.Id";
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getResultCourseScoreStudent(string columns)
        {

            string sql2 = "SELECT * FROM " +
                "(select std.id_student, std.fname, std.lname, Course.label, score.score from std inner join score on std.id_student = score.student_id inner join Course on score.course_id = Course.Id )"
                + "As t PIVOT(sum(score)  FOR label IN(" + columns + ")) AS pivot_table";

            SqlCommand command2 = new SqlCommand(sql2, db.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            adapter.Fill(table);
            return table;
        }
    }
}
