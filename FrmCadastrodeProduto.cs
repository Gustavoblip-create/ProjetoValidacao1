using ProjetoValidacao1.Model;
using ProjetoValidacao1.Repository;
using System;
using System.Windows.Forms;

namespace ProjetoValidacao1
{
    public partial class FrmCadastrodeProduto : Form
    {
        private ProdutoRepository _repo;

        public FrmCadastrodeProduto()
        {
            InitializeComponent();
            _repo = new ProdutoRepository();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroDeProduto p = new 
                {
                    Nome = txtNomeProduto.Text,
                    DataProduto = Date.Value,
                    Valor = decimal.Parse(txtPrecoProduto.Text),
                   
                };

                _repo.Inserir(p);

                MessageBox.Show("Produto cadastrado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
           
        }
    }
}
