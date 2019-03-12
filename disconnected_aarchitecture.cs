using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practisee;

class Disconnected_aarchitecture
{
    public  void data_adapter()
    {
        using (SqlConnection connectionstring = connection.getconnection())
        {
            connectionstring.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from a", connectionstring);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    Console.WriteLine(dr[dc] + " ");

                }
            }
        }
    }
}

