using ConsoleApp1.DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class TestSp
    {
        private readonly static string strConexion = ConfigurationManager.ConnectionStrings["CnxTendencia"].ConnectionString;
        public static void  UpdateTemplateOne()
        {
            
                SqlConnection conexion = new SqlConnection(strConexion);
                var obj = new Object();
                using (conexion)
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand("Sp_UpdateTemplateNewsTrendsOne", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Id", 2);
                    command.Parameters.AddWithValue("@Title", "Titulo plantilla");
                    command.Parameters.AddWithValue("@TextArea", "Texto referencia");
                    command.Parameters.AddWithValue("@LinkText", "Mi texto del enlaze");
                    command.Parameters.AddWithValue("@Link", "http://www.youtube.com");
                    command.Parameters.AddWithValue("@RolloVer", "Texto rollo ver");
                    command.Parameters.AddWithValue("@Status", false);
                    command.Parameters.AddWithValue("@Section", 3);
                    command.Parameters.AddWithValue("@IdUserCreate", 1);
                    command.Parameters.AddWithValue("@IdUserUpdate", 1);
                    command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                    command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                    obj = command.ExecuteNonQuery();
                    conexion.Close();
                };
           
        }

        public static DataTable UsarSpOne()
        {
            DataTable dataTabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(strConexion);

            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_UpdateTemplateNewsTrendsOne", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", 3);
                command.Parameters.AddWithValue("@Title", "Titulo plantilla 3");
                command.Parameters.AddWithValue("@TextArea", "Texto referencia 3");
                command.Parameters.AddWithValue("@LinkText", "Mi texto de enlaze3");
                command.Parameters.AddWithValue("@Link", "http://www.youtube.com.co");
                command.Parameters.AddWithValue("@RolloVer", "Texto rollo ver 3");
                command.Parameters.AddWithValue("@Status", true);
                command.Parameters.AddWithValue("@Section", 5);
                command.Parameters.AddWithValue("@IdUserCreate", 1);
                command.Parameters.AddWithValue("@IdUserUpdate", 2);
                command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                SqlDataAdapter dataAdaptador = new SqlDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public static DataTable UsarSpTwo()
        {
            DataTable dataTabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(strConexion);

            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_UpdateTemplateNewsTrendsTwo", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id",0);
                command.Parameters.AddWithValue("@Title", "Titulo plantilla");
                command.Parameters.AddWithValue("@TextRef", "Texto referencia");
                command.Parameters.AddWithValue("@Status", true);
                command.Parameters.AddWithValue("@Section", 2);
                command.Parameters.AddWithValue("@IdUserCreate", 4);
                command.Parameters.AddWithValue("@IdUserUpdate", 4);
                command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                SqlDataAdapter dataAdaptador = new SqlDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public static DataTable UsarSpFour()
        {
            DataTable dataTabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(strConexion);

            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand("Sp_UpdateTemplateNewsTrendsFour", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", 1);
                command.Parameters.AddWithValue("@TextArea", "Texto referencia 1");
                command.Parameters.AddWithValue("@LinkText", "Mi texto de enlaze 1");
                command.Parameters.AddWithValue("@Link", "http://www.youtube.com");
                command.Parameters.AddWithValue("@RolloVer", "Texto rollo ver");
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Section", 2);
                command.Parameters.AddWithValue("@IdUserCreate", 1);
                command.Parameters.AddWithValue("@IdUserUpdate", 1);
                command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                SqlDataAdapter dataAdaptador = new SqlDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }
    }
}
