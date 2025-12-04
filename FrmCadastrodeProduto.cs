using ProjetoValidacao1.Controller;
using ProjetoValidacao1.Model;
using System;
using System.Windows.Forms;

namespace ProjetoValidacao1
{
    public partial class FrmCadastrodeProduto : Form
    {
        private CadastroDeProdutoController _cadastroDeProdutoController;




        public FrmCadastrodeProduto()
        {
            InitializeComponent();
            _cadastroDeProdutoController = new CadastroDeProdutoController(this);

        }
        public void ExibirProdutos(List<CadastroDeProduto> produtos)
        {
            dgvCadastroDeProdutos.DataSource = produtos;
        }



        private void FrmCadastrodeProduto_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            _cadastroDeProdutoController.ListarProduto();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void HabilitarCampos()
        {
            txtNomeDoProduto.ReadOnly = false;
            txtValorProduto.ReadOnly = false;
            dtpDataProduto.Enabled = true;
            txtLoteDoProduto.ReadOnly = false;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigoDoProduto.Clear();
            txtNomeDoProduto.Clear();
            txtValorProduto.Clear();
            txtLoteDoProduto.Clear();
            dtpDataProduto.Value = DateTime.Now;

        }

        public void DesabilitarCampos()
        {
            txtNomeDoProduto.ReadOnly = true;
            txtValorProduto.ReadOnly = true;
            dtpDataProduto.Enabled = false;
            txtLoteDoProduto.ReadOnly = true;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public bool Validar(CadastroDeProduto validar)
        {
            if (string.IsNullOrWhiteSpace(validar.NomeProduto))
            {
                ExibirMensagem("O nome do produto é obrigatório.");
                txtNomeDoProduto.Focus();
                return false;
            }

            if (validar.ValorProduto <= 0)
            {
                ExibirMensagem("O valor do produto deve ser maior que zero.");
                txtValorProduto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(validar.LoteProduto))
            {
                ExibirMensagem("O lote é obrigatório.");
                txtLoteDoProduto.Focus();
                return false;
            }

            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroDeProduto produto = new CadastroDeProduto()

            {

                NomeProduto = txtNomeDoProduto.Text,

                ValorProduto = decimal.TryParse(txtValorProduto.Text, out decimal v) ? v : 0,

                DataProduto = dtpDataProduto.Value,

                LoteProduto = txtLoteDoProduto.Text

            };

            if (!Validar(produto)) return;

            if (string.IsNullOrEmpty(txtCodigoDoProduto.Text))

            {

                // Salvar

                _cadastroDeProdutoController.Salvar(produto);

            }
            else
            {
                produto.Id = Convert.ToInt32(txtCodigoDoProduto.Text);
                _cadastroDeProdutoController.Atualizar(produto);



            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            HabilitarCampos();
            btnEditar.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoDoProduto.Text))

            {


                ExibirMensagem("Selecione um produto para excluir!");

                return;

            }

            var resp = MessageBox.Show("Deseja excluir este produto?",

                "Confirmação",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)

            {

                _cadastroDeProdutoController.Excluir(Convert.ToInt32(txtCodigoDoProduto.Text));

            }

        }

       

        private void dgvCadastroDeProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhasSelecionada = dgvCadastroDeProdutos.Rows[e.RowIndex];

                txtCodigoDoProduto.Text = linhasSelecionada.Cells["Id"].Value.ToString();
                txtLoteDoProduto.Text = linhasSelecionada.Cells["LoteProduto"].Value.ToString();
                txtNomeDoProduto.Text = linhasSelecionada.Cells["NomeProduto"].Value.ToString();
                txtValorProduto.Text = linhasSelecionada.Cells["ValorProduto"].Value.ToString();
                dtpDataProduto.Text = linhasSelecionada.Cells["DataProduto"].Value.ToString();

            }
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnNovo.Enabled = false;
        }
    }
}
