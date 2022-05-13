using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Day02
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        
        //get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //open the connec
        public void openConnection()
        {
            if((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        //close the connec
        public void closeConnection()
        {
            if((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }


    }
}
