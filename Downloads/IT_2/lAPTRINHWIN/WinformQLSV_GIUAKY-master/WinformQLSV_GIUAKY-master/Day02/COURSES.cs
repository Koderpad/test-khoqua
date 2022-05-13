using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class COURSES
    {
        MY_DB db = new MY_DB();
        public bool checkCourseName(string cName, int cID = 0)
        {
            SqlCommand command = new SqlCommand("select * from course where label=@cName and Id <> @cID", db.getConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = cID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id=@cid", db.getConnection);

            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertCourse(string Cid, string label, string period, string description)
        {
            int id = Convert.ToInt32(Cid);
            int peri = Convert.ToInt32(period);
            SqlCommand command = new SqlCommand("INSERT INTO course (Id,label, period, description)" +
                " VALUES (@id,@label,@Pe,@Des)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Cid;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@Pe", SqlDbType.Int).Value = peri;
            command.Parameters.Add("@Des", SqlDbType.NVarChar).Value = description;
            db.openConnection();


            if (command.ExecuteNonQuery() == 1)
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

        public bool removeCourse(String Cid)
        {
            int id = Convert.ToInt32(Cid);
            SqlCommand command = new SqlCommand("delete from course where Id=@Id", db.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Cid;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool editCourse(string Cid, string label, string period, string description)
        {
            int id = Convert.ToInt32(Cid);
            int peri = Convert.ToInt32(period);
            SqlCommand command = new SqlCommand("update course set label=@label, period=@Pe,description=@Des where Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Cid;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@Pe", SqlDbType.Int).Value = peri;
            command.Parameters.Add("@Des", SqlDbType.NVarChar).Value = description;
            db.openConnection();


            if (command.ExecuteNonQuery() == 1)
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


        public DataTable getAllCourses()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course", db.getConnection);
            DataTable courses = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText,db.getConnection);
            da.Fill(courses);

            return courses;
        }

        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            db.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }

        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM course");
        }


    }
}
