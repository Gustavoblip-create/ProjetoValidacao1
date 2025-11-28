namespace ProjetoValidacao1.View
{
    partial class FrmListadeProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListadeProduto = new DataGridView();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            cbxPesquisar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListadeProduto).BeginInit();
            SuspendLayout();
            // 
            // dgvListadeProduto
            // 
            dgvListadeProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeProduto.Location = new Point(12, 41);
            dgvListadeProduto.Name = "dgvListadeProduto";
            dgvListadeProduto.Size = new Size(776, 368);
            dgvListadeProduto.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(713, 416);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(12, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cbxPesquisar
            // 
            cbxPesquisar.FormattingEnabled = true;
            cbxPesquisar.Location = new Point(93, 13);
            cbxPesquisar.Name = "cbxPesquisar";
            cbxPesquisar.Size = new Size(695, 23);
            cbxPesquisar.TabIndex = 3;
            // 
            // FrmListadeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(cbxPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvListadeProduto);
            Name = "FrmListadeProduto";
            Text = "Lista de Produtos";
            Load += FrmListadeProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadeProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListadeProduto;
        private Button btnExcluir;
        private Button btnPesquisar;
        private ComboBox cbxPesquisar;
    }
}