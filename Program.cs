using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CollegeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server = LAPTOP-C1FQQ50G\MSSQLSERVER2019;
                        database =college;
                        user id= sa;
                        password = Password@1";

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Students;", con );
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();


            while (dr.Read() )
            {
                string StudentId = dr["StudentId"].ToString();
                string StudentName = dr["StudentName"].ToString();

                Console.WriteLine(StudentId + "" + StudentName);
            }

            dr.Close();
            Console.ReadLine();
        }
    }
}
