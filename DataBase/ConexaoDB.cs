using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace ProjetoValidacao1.DataBase
{
    public static class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectioString = ConfigurationManager.ConnectionStrings["projeto_validacao"].ConnectionString;

            return new SqlConnection(connectioString);
        }
    }
}
