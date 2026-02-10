namespace ProjetoValidacao1
{
    partial class FrmCadastrodeProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeProduto = new Label();
            lblCodigoProduto = new Label();
            lblDataProduto = new Label();
            lblPrecoProduto = new Label();
            btnSalvar = new Button();
            grbCadastrarProdutos = new GroupBox();
            dtpDataProduto = new DateTimePicker();
            txtNomeDoProduto = new TextBox();
            txtLoteDoProduto = new TextBox();
            txtValorProduto = new TextBox();
            txtCodigoDoProduto = new TextBox();
            lblLoteProduto = new Label();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            dgvCadastroDeProdutos = new DataGridView();
            grbCadastrarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastroDeProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(6, 32);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.AutoSize = true;
            lblCodigoProduto.Location = new Point(6, 107);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(109, 15);
            lblCodigoProduto.TabIndex = 3;
            lblCodigoProduto.Text = "Código do Produto";
            // 
            // lblDataProduto
            // 
            lblDataProduto.AutoSize = true;
            lblDataProduto.Location = new Point(192, 107);
            lblDataProduto.Name = "lblDataProduto";
            lblDataProduto.Size = new Size(94, 15);
            lblDataProduto.TabIndex = 5;
            lblDataProduto.Text = "Data do Produto";
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Location = new Point(402, 107);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(100, 15);
            lblPrecoProduto.TabIndex = 7;
            lblPrecoProduto.Text = "Preço do Produto";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(473, 612);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // grbCadastrarProdutos
            // 
            grbCadastrarProdutos.Controls.Add(dtpDataProduto);
            grbCadastrarProdutos.Controls.Add(txtNomeDoProduto);
            grbCadastrarProdutos.Controls.Add(txtLoteDoProduto);
            grbCadastrarProdutos.Controls.Add(txtValorProduto);
            grbCadastrarProdutos.Controls.Add(txtCodigoDoProduto);
            grbCadastrarProdutos.Controls.Add(lblLoteProduto);
            grbCadastrarProdutos.Controls.Add(lblNomeProduto);
            grbCadastrarProdutos.Controls.Add(lblCodigoProduto);
            grbCadastrarProdutos.Controls.Add(lblPrecoProduto);
            grbCadastrarProdutos.Controls.Add(lblDataProduto);
            grbCadastrarProdutos.Location = new Point(12, 12);
            grbCadastrarProdutos.Name = "grbCadastrarProdutos";
            grbCadastrarProdutos.Size = new Size(776, 177);
            grbCadastrarProdutos.TabIndex = 10;
            grbCadastrarProdutos.TabStop = false;
            grbCadastrarProdutos.Text = "Cadastrar Produtos";
            // 
            // dtpDataProduto
            // 
            dtpDataProduto.Location = new Point(192, 125);
            dtpDataProduto.Name = "dtpDataProduto";
            dtpDataProduto.Size = new Size(200, 23);
            dtpDataProduto.TabIndex = 16;
            // 
            // txtNomeDoProduto
            // 
            txtNomeDoProduto.Location = new Point(6, 50);
            txtNomeDoProduto.Name = "txtNomeDoProduto";
            txtNomeDoProduto.Size = new Size(684, 23);
            txtNomeDoProduto.TabIndex = 15;
            // 
            // txtLoteDoProduto
            // 
            txtLoteDoProduto.Location = new Point(592, 125);
            txtLoteDoProduto.Name = "txtLoteDoProduto";
            txtLoteDoProduto.Size = new Size(136, 23);
            txtLoteDoProduto.TabIndex = 14;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(402, 125);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(163, 23);
            txtValorProduto.TabIndex = 13;
            // 
            // txtCodigoDoProduto
            // 
            txtCodigoDoProduto.Location = new Point(6, 125);
            txtCodigoDoProduto.Name = "txtCodigoDoProduto";
            txtCodigoDoProduto.Size = new Size(163, 23);
            txtCodigoDoProduto.TabIndex = 11;
            // 
            // lblLoteProduto
            // 
            lblLoteProduto.AutoSize = true;
            lblLoteProduto.Location = new Point(592, 107);
            lblLoteProduto.Name = "lblLoteProduto";
            lblLoteProduto.Size = new Size(93, 15);
            lblLoteProduto.TabIndex = 9;
            lblLoteProduto.Text = "Lote do Produto";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(633, 612);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(392, 612);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 612);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(552, 612);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvCadastroDeProdutos
            // 
            dgvCadastroDeProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastroDeProdutos.Location = new Point(12, 210);
            dgvCadastroDeProdutos.Name = "dgvCadastroDeProdutos";
            dgvCadastroDeProdutos.ReadOnly = true;
            dgvCadastroDeProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCadastroDeProdutos.Size = new Size(776, 396);
            dgvCadastroDeProdutos.TabIndex = 15;
            dgvCadastroDeProdutos.CellContentClick += dgvCadastroDeProdutos_CellContentClick;
            dgvCadastroDeProdutos.CellDoubleClick += dgvCadastroDeProdutos_CellDoubleClick;
            // 
            // FrmCadastrodeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(799, 647);
            Controls.Add(dgvCadastroDeProdutos);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(grbCadastrarProdutos);
            Controls.Add(btnSalvar);
            Name = "FrmCadastrodeProduto";
            Text = "Cadastro De Produtos";
            Load += FrmCadastrodeProduto_Load;
            grbCadastrarProdutos.ResumeLayout(false);
            grbCadastrarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastroDeProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblNomeProduto;
        private Label lblCodigoProduto;
        private Label lblDataProduto;
        private Label lblPrecoProduto;
        private Button btnSalvar;
        private GroupBox grbCadastrarProdutos;
        private Label lblLoteProduto;
        private TextBox txtLoteDoProduto;
        private TextBox txtValorProduto;
        private TextBox txtCodigoDoProduto;
        private TextBox txtNomeDoProduto;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnEditar;
        private DateTimePicker dtpDataProduto;
        private DataGridView dgvCadastroDeProdutos;
    }
}
