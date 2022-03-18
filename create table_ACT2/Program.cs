using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace create_table_ACT2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Createtable();
        }

        public void Createtable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = lathifah;database=ProdiTI;User ID=sa;Password=kimtaehyung");
                con.Open();

                SqlCommand cm = new SqlCommand("Create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Table Sukses Dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }




        }
    }
}
