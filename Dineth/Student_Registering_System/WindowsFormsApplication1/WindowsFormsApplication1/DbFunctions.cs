using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DbFunctions
    {
        private static SqlConnection con = DbConnection.getConnection();




        public static bool insertStudent(String Name, String Dob, Double gpa, String active)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insertstd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@names", Name);
                cmd.Parameters.AddWithValue("@dob", Dob);
                cmd.Parameters.AddWithValue("@gpa", gpa);
                cmd.Parameters.AddWithValue("@active", active);


                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }

            catch
            {

                return false;

            }
        }


        public static DataTable getStudents()


        {  

            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("getstudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                dt.Load(dr);

                con.Close();

            }

            catch
            {

                MessageBox.Show("problem with database connectivity"); 

            }
            return dt;

        }


    }
}
