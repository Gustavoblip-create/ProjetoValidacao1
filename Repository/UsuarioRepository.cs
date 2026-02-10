using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProjetoValidacao1.DataBase;
using ProjetoValidacao1.Repository;
using ProjetoValidacao1.Model;

namespace ProjetoValidacao1.Repository
{
    public class UsuarioRepository
    {
        public Usuario Login(string email, string senha)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                conexao.Open();

                string sql = @"SELECT id, Nome, Email FROM Usuarios
                WHERE Email = @email AND Senha = @senha";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Usuario()
                            {
                                Id = dr.GetInt32(0),
                                Nome = dr.GetString(1),
                                Email = dr.GetString(2)


                            };
                        }
                    }
                    
                }
            }
            return null;
        }
    }
}
