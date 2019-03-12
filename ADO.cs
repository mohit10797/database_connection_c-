using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace practisee
{
    public static class connection {
        static SqlConnection con;
        public static SqlConnection getconnection()
        {
           return  new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        }
}
    class ADO
    {
        public static void Main()
        {
            Disconnected_aarchitecture ds = new Disconnected_aarchitecture();
            ds.data_adapter();
            Console.WriteLine("Enter Your Choice \n 1. Insert \n 2. Update \n 3.Delete \n 4. Select");
            byte a = Convert.ToByte(Console.ReadLine());

            

                switch (a)
                {
                    case 1:
                        SqlCommand insert = new SqlCommand("insert into a (id,name,exp,deptid,phone,address,emailid) values (@id, @name, @exp, @deptid, @phone, @address, @email)", connectionString);
                        //SqlParameter p = new SqlParameter("@flg", System.Data.SqlDbType.Int);
                        //p.Direction = System.Data.ParameterDirection.Output;
                        //insert.Parameters.add("p")
                        insert.Parameters.AddWithValue("@id", Convert.ToInt16(Console.ReadLine()));
                        insert.Parameters.AddWithValue("@name", (Console.ReadLine()));
                        insert.Parameters.AddWithValue("@exp", Convert.ToInt16(Console.ReadLine()));
                        insert.Parameters.AddWithValue("@deptid", Convert.ToInt16(Console.ReadLine()));
                        insert.Parameters.AddWithValue("@phone", Console.ReadLine());
                        insert.Parameters.AddWithValue("@address", Console.ReadLine());
                        insert.Parameters.AddWithValue("@email", Console.ReadLine());

                        insert.ExecuteNonQuery();
                        break;
                    case 2:
                        SqlCommand update = new SqlCommand("update a set id =@id, name=@name, exp=@exp, deptid=@deptid, phone=@phone, address=@address, emailid=@email", connectionString);
                        update.Parameters.AddWithValue("@id", Convert.ToInt16(Console.ReadLine()));
                        update.Parameters.AddWithValue("@name", (Console.ReadLine()));
                        update.Parameters.AddWithValue("@exp", Convert.ToInt16(Console.ReadLine()));
                        update.Parameters.AddWithValue("@deptid", Convert.ToInt16(Console.ReadLine()));
                        update.Parameters.AddWithValue("@phone", Console.ReadLine());
                        update.Parameters.AddWithValue("@address", Console.ReadLine());
                        update.Parameters.AddWithValue("@email", Console.ReadLine());

                        update.ExecuteNonQuery();
                        break;
                    case 3:
                        SqlCommand delete = new SqlCommand("delete a where id = @id", connectionString);
                        delete.Parameters.AddWithValue("@id", (Convert.ToInt16(Console.ReadLine())));

                        delete.ExecuteNonQuery();
                        break;
                    case 4:
                        SqlCommand select = new SqlCommand("select * from a", connectionString);

                        SqlDataReader read = select.ExecuteReader();
                        while (read.Read())
                        {
                            for (int i = 0; i <= read.FieldCount; i++)
                            {

                                Console.WriteLine(read[i] + " ");
                            }
                        }
                        break;
                }


            }
        }
    }
}