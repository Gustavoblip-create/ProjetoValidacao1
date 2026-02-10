using Microsoft.Data.SqlClient;
using ProjetoValidacao1.DataBase;
using ProjetoValidacao1.Model;
using System.Collections.Generic;

namespace ProjetoValidacao1.Repositories
{
    public class CadastroDeProdutoRepository
    {
        public List<CadastroDeProduto> Listar()
        {

            
            var lista = new List<CadastroDeProduto>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
                    SELECT 
                        id_produto   AS Id,
                        nome_produto AS NomeProduto,
                        valor_produto AS ValorProduto,
                        data_produto AS DataProduto,
                        lote_produto AS LoteProduto
                    FROM produto";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CadastroDeProduto
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                NomeProduto = reader.GetString(reader.GetOrdinal("NomeProduto")),
                                ValorProduto = reader.GetDecimal(reader.GetOrdinal("ValorProduto")),
                                DataProduto = reader.GetDateTime(reader.GetOrdinal("DataProduto")),
                                LoteProduto = reader.GetString(reader.GetOrdinal("LoteProduto"))
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Inserir(CadastroDeProduto produto)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
                    INSERT INTO produto 
                    (nome_produto, valor_produto, data_produto, lote_produto)
                    VALUES 
                    (@nome, @valor, @data, @lote)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", produto.NomeProduto);
                    comando.Parameters.AddWithValue("@valor", produto.ValorProduto);
                    comando.Parameters.AddWithValue("@data", produto.DataProduto);
                    comando.Parameters.AddWithValue("@lote", produto.LoteProduto);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(CadastroDeProduto produto)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
                    UPDATE produto 
                    SET 
                        nome_produto = @nome,
                        valor_produto = @valor,
                        data_produto = @data,
                        lote_produto = @lote
                    WHERE id_produto = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", produto.Id);
                    comando.Parameters.AddWithValue("@nome", produto.NomeProduto);
                    comando.Parameters.AddWithValue("@valor", produto.ValorProduto);
                    comando.Parameters.AddWithValue("@data", produto.DataProduto);
                    comando.Parameters.AddWithValue("@lote", produto.LoteProduto);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM produto WHERE id_produto = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
