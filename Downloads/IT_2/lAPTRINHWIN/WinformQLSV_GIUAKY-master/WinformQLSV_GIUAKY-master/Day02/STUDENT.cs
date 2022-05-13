using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
     public class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public bool checkStdID(string StdID)
        {
            string query = "SELECT * FROM std WHERE id_student = "+StdID+" ";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            //cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = StdID;

            mydb.openConnection();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool checkStd(int id)
        {
            string query = "SELECT * FROM std WHERE id = @id ";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool insertStudent(string idStu, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id,id_student,fname,lname,bdate,gender,phone,address,picture)" +
                "VALUES (@id,@id_student,@fname,@lname,@bdate,@gender,@phone,@address,@picture)", mydb.getConnection);
            //command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@id_student", SqlDbType.VarChar).Value = idStu;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            MydatabaseLINQDataContext dataContext = new MydatabaseLINQDataContext();
            var maxID =
                from p in dataContext.stds
                select p.id;

            int maxId = 0;
            try
            {
                maxId = maxID.Max()+1;
            }
            catch
            {
                maxId = 1;
            }

            command.Parameters.Add("@id", SqlDbType.Int).Value = maxId;


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            /*            SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table is null)
                            return null;
                        return table;*/
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                NewMethod(adapter, table);
                return table;
            }
        }

        private static void NewMethod(SqlDataAdapter adapter, DataTable table)
        {
            adapter.Fill(table);
        }

        public bool updateStudent(string studId, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fname,lname=@lname,bdate=@bdate,gender=@gender,phone=@phone,address=@address,picture=@picture"
             +" where id_student=@studId"  , mydb.getConnection);
            //command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@studId", SqlDbType.VarChar).Value = studId;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteStudent(string StdID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id_student=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = StdID;

            MydatabaseLINQDataContext dataContext = new MydatabaseLINQDataContext();
            //update id of students
            var amountID =

                from p in dataContext.stds

                select p.id;

            int countID = amountID.Count();


            (from p in dataContext.stds
             select p).ToList()
                       .ForEach(x =>
                       {
                           for (int i = 1; i <= countID; i++)
                           {
                               SqlCommand cmd = new SqlCommand("UPDATE std set id = @curId where id=@oldID", mydb.getConnection);
                               cmd.Parameters.Add("@curId", SqlDbType.Int).Value = i;
                               cmd.Parameters.Add("@oldID", SqlDbType.Int).Value = x.id;
                           };
                       });

            dataContext.SubmitChanges();


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM std");
        }

        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Male'");
        }

        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Female'");
        }
    }
}
