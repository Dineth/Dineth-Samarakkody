using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DbConnection
    {
        private static SqlConnection con;
        private static String constring = "Data Source=DELL-PC;Initial Catalog=StudentInformation;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        
            public static SqlConnection getConnection()
            {

                if(con==null)
                {
                    con=new SqlConnection(constring);
                    return con;
                }

               return con;


            }



    }
}
