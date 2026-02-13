using System;
using System.Windows.Forms;
using ProjetoValidacao1.DataBase;
using Microsoft.Data.SqlClient;
using ProjetoValidacao1.Model;


namespace ProjetoValidacao1
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        public FrmTelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexão Realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar:" + ex.Message);

            }

        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroDeproduto_Click(object sender, EventArgs e)
        {
            FrmCadastrodeProduto cadastrodeProduto = new FrmCadastrodeProduto();
            cadastrodeProduto.Show();
        }

        //private void btnListaDeProduto_Click(object sender, EventArgs e)
        //{
        //    FrmListadeProduto listadeProduto = new FrmListadeProduto();
        //    listadeProduto.Show();
        //}
    }

}
