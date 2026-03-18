using System.Configuration;
using Microsoft.Data.SqlClient;

namespace ProjetoValidacao1.DataBase
{
    public static class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["projeto_validacao"].ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}