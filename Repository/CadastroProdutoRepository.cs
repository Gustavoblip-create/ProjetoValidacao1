using Microsoft.Data.SqlClient;
using ProjetoValidacao1.DataBase;
using ProjetoValidacao1.Model;

namespace ProjetoValidacao1.Repositories

{

    public class CadastroDeProdutoRepository

    {
        public List<CadastroDeProduto> Listar()

        {

            var lista = new List<CadastroDeProduto>();

            using (var conexao = ConexaoDB.GetConexao())

            {

                string sql = "SELECT * FROM produto";

                

                 

                using (var comando = new SqlCommand(sql, conexao))

                {

                   

                      

                    conexao.Open();

                    using (var reader = comando.ExecuteReader())

                    {

                        while (reader.Read())

                        {

                            lista.Add(new CadastroDeProduto()

                            {

                                Id = Convert.ToInt32(reader["id_produto"]),

                                NomeProduto = reader["nome_produto"].ToString(),

                                ValorProduto = Convert.ToDecimal(reader["valor_produto"]),

                                DataProduto = Convert.ToDateTime(reader["data_produto"]),

                                LoteProduto = reader["lote_produto"].ToString()

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
                string sql =
                    "INSERT INTO produto(nome_produto, valor_produto, data_produto, lote_produto) " +
                    "VALUES(@nome, @valor, @data, @lote)";

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

                string sql =

                    "UPDATE produto SET nome_produto=@nome, valor_produto=@valor, " +

                    "data_produto=@data, lote_produto=@lote WHERE id_produto=@id_produto";

                using (var comando = new SqlCommand(sql, conexao))

                {

                    comando.Parameters.AddWithValue("@id_produto", produto.Id);

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

                string sql = "DELETE FROM produto WHERE id_produto=@id_produto";

                using (var comando = new SqlCommand(sql, conexao))

                {

                    comando.Parameters.AddWithValue("@id_produto", id);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                }

            }

        }




    }

}

