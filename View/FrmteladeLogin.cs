using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoValidacao1.Model;

namespace ProjetoValidacao1.View
{
    public partial class FrmteladeLogin : Form
    {
        public FrmteladeLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtsenha.Text))
            {
                MessageBox.Show("Preencha o email ou senha");
                return;
            }

            UsuarioRepository repo = new UsuarioRepository();
            Usuario usuario = repo.Login(
                txtEmail.Text.Trim(),
                txtSenha.Text.Trim()
            );

            if (usuario != null)
            {
                MessageBox.Show($"Bem-vindo, {usuario.Nome}");

                FrmTelaPrincipal tela = new FrmTelaPrincipal(usuario);
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos!");
            }

        }
    }
}
