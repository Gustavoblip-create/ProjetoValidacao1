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
            txtNomeProduto = new ComboBox();
            lblCodigoProduto = new Label();
            txtCodigoProduto = new ComboBox();
            lblDataProduto = new Label();
            txtDataProduto = new ComboBox();
            lblPrecoProduto = new Label();
            txtPrecoProduto = new ComboBox();
            bntSalvar = new Button();
            grbCadastrarProdutos = new GroupBox();
            grbCadastrarProdutos.SuspendLayout();
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
            // txtNomeProduto
            // 
            txtNomeProduto.FormattingEnabled = true;
            txtNomeProduto.Location = new Point(6, 50);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(684, 23);
            txtNomeProduto.TabIndex = 2;
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
            // txtCodigoProduto
            // 
            txtCodigoProduto.FormattingEnabled = true;
            txtCodigoProduto.Location = new Point(6, 125);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(140, 23);
            txtCodigoProduto.TabIndex = 4;
            // 
            // lblDataProduto
            // 
            lblDataProduto.AutoSize = true;
            lblDataProduto.Location = new Point(172, 107);
            lblDataProduto.Name = "lblDataProduto";
            lblDataProduto.Size = new Size(94, 15);
            lblDataProduto.TabIndex = 5;
            lblDataProduto.Text = "Data do Produto";
            // 
            // txtDataProduto
            // 
            txtDataProduto.FormattingEnabled = true;
            txtDataProduto.Location = new Point(172, 125);
            txtDataProduto.Name = "txtDataProduto";
            txtDataProduto.Size = new Size(148, 23);
            txtDataProduto.TabIndex = 6;
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Location = new Point(343, 107);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(100, 15);
            lblPrecoProduto.TabIndex = 7;
            lblPrecoProduto.Text = "Preço do Produto";
            lblPrecoProduto.Click += label5_Click;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.FormattingEnabled = true;
            txtPrecoProduto.Location = new Point(343, 125);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(148, 23);
            txtPrecoProduto.TabIndex = 8;
            // 
            // bntSalvar
            // 
            bntSalvar.Location = new Point(713, 356);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(75, 23);
            bntSalvar.TabIndex = 9;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            // 
            // grbCadastrarProdutos
            // 
            grbCadastrarProdutos.Controls.Add(txtNomeProduto);
            grbCadastrarProdutos.Controls.Add(lblNomeProduto);
            grbCadastrarProdutos.Controls.Add(txtPrecoProduto);
            grbCadastrarProdutos.Controls.Add(lblCodigoProduto);
            grbCadastrarProdutos.Controls.Add(lblPrecoProduto);
            grbCadastrarProdutos.Controls.Add(txtCodigoProduto);
            grbCadastrarProdutos.Controls.Add(txtDataProduto);
            grbCadastrarProdutos.Controls.Add(lblDataProduto);
            grbCadastrarProdutos.Location = new Point(12, 12);
            grbCadastrarProdutos.Name = "grbCadastrarProdutos";
            grbCadastrarProdutos.Size = new Size(776, 318);
            grbCadastrarProdutos.TabIndex = 10;
            grbCadastrarProdutos.TabStop = false;
            grbCadastrarProdutos.Text = "Cadastrar Produtos";
            // 
            // FrmCadastrodeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(799, 397);
            Controls.Add(grbCadastrarProdutos);
            Controls.Add(bntSalvar);
            Name = "FrmCadastrodeProduto";
            Text = "Cadastro De Produtos";
            grbCadastrarProdutos.ResumeLayout(false);
            grbCadastrarProdutos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblNomeProduto;
        private ComboBox txtNomeProduto;
        private Label lblCodigoProduto;
        private ComboBox txtCodigoProduto;
        private Label lblDataProduto;
        private ComboBox txtDataProduto;
        private Label lblPrecoProduto;
        private ComboBox txtPrecoProduto;
        private Button bntSalvar;
        private GroupBox grbCadastrarProdutos;
    }
}
