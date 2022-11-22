using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public  class MonedaExtranjera
    {

        public string Ejemplo()
        {
            var result = string.Empty;
            using (SqlConnection connection = new SqlConnection())
            {
                var command = new SqlCommand("",connection);
                command.CommandType = System.Data.CommandType.Text;
                var reader  = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }

            return result;
        }

    }
}
