using Microsoft.Data.SqlClient;
using ProjetoValidacao1.DataBase;
using ProjetoValidacao1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoValidacao1.Repository
{
    public class ProdutoRepository
    {
        // ============ INSERIR =============
        public void Inserir(CadastroDeProduto p)
        {
            string sql = @"INSERT INTO CadastroDeProduto 
                           (nome_produto, data_produto, valor_produto, lote_produto)
                           VALUES (@nome, @data, @valor, @lote)";

            using (SqlConnection con = ConexaoDB.GetConexao())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", p.NomeProduto);
                cmd.Parameters.AddWithValue("@data", p.DataProduto);
                cmd.Parameters.AddWithValue("@valor", p.ValorProduto);
                cmd.Parameters.AddWithValue("@lote", p.LoteProduto);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============ LISTAR TODOS =============
        public List<CadastroDeProduto> Listar()
        {
            List<CadastroDeProduto> lista = new List<CadastroDeProduto>();

            string sql = "SELECT * FROM CadastroDeProduto";

            using (SqlConnection con = ConexaoDB.GetConexao())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new CadastroDeProduto
                    {
                        id = (int)dr["id_produto"],
                        NomeProduto = dr["nome_produto"].ToString(),
                        DataProduto = (DateTime)dr["data_produto"],
                        ValorProduto = (decimal)dr["valor_produto"],
                        LoteProduto = dr["lote_produto"].ToString()
                    });
                }
            }

            return lista;
        }

        // ============ EXCLUIR POR ID ============
        public void Excluir(int id)
        {
            string sql = "DELETE FROM CadastroDeProduto WHERE id_produto = @id";

            using (SqlConnection con = ConexaoDB.GetConexao())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============ ATUALIZAR ============
        public void Atualizar(CadastroDeProduto p)
        {
            string sql = @"UPDATE CadastroDeProduto 
                           SET nome_produto = @nome,
                               data_produto = @data,
                               valor_produto = @valor,
                               lote_produto = @lote
                           WHERE id_produto = @id";

            using (SqlConnection con = ConexaoDB.GetConexao())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", p.NomeProduto);
                cmd.Parameters.AddWithValue("@data", p.DataProduto);
                cmd.Parameters.AddWithValue("@valor", p.ValorProduto);
                cmd.Parameters.AddWithValue("@lote", p.LoteProduto);
                cmd.Parameters.AddWithValue("@id", p.id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============ BUSCAR POR ID ============
        public CadastroDeProduto BuscarPorId(int id)
        {
            CadastroDeProduto p = null;

            string sql = "SELECT * FROM CadastroDeProduto WHERE id_produto = @id";

            using (SqlConnection con = ConexaoDB.GetConexao())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    p = new CadastroDeProduto
                    {
                        id = (int)dr["id_produto"],
                        NomeProduto = dr["nome_produto"].ToString(),
                        DataProduto = (DateTime)dr["data_produto"],
                        ValorProduto = (decimal)dr["valor_produto"],
                        LoteProduto = dr["lote_produto"].ToString()
                    };
                }
            }

            return p;
        }
    }
}
