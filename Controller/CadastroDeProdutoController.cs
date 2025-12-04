using System.Drawing.Text;
using System.Windows.Forms;
using ProjetoValidacao1.Model;

using ProjetoValidacao1.Repositories;

namespace ProjetoValidacao1.Controller

{

    public class CadastroDeProdutoController

    {
        private FrmCadastrodeProduto _frmCadastroDeProduto; //Antes era view
        private CadastroDeProdutoRepository _cadastroDeProdutoRepository;

        public CadastroDeProdutoController(FrmCadastrodeProduto view)
        {
            _frmCadastroDeProduto = view;
            _cadastroDeProdutoRepository = new CadastroDeProdutoRepository();
            
        }

        public void Salvar(CadastroDeProduto produto)
        {
            try
            {
                _cadastroDeProdutoRepository.Inserir(produto);
                _frmCadastroDeProduto.ExibirMensagem("Produto salvo com sucesso!");
                Listar();
                _frmCadastroDeProduto.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroDeProduto.ExibirMensagem("Erro ao salvar: " + ex.Message);
            }
        }

        public void Atualizar(CadastroDeProduto produto)
        {
            try
            {
                _cadastroDeProdutoRepository.Atualizar(produto);
                _frmCadastroDeProduto.ExibirMensagem("Produto atualizado com sucesso!");
                Listar();
                _frmCadastroDeProduto.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroDeProduto.ExibirMensagem("Erro ao atualizar: " + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _cadastroDeProdutoRepository.Excluir(id);
                _frmCadastroDeProduto.ExibirMensagem("Produto excluído com sucesso!");
                Listar();
                _frmCadastroDeProduto.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroDeProduto.ExibirMensagem("Erro ao excluir: " + ex.Message);
            }
        }





    }

} 

