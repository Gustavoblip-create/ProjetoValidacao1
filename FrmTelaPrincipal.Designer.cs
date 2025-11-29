namespace ProjetoValidacao1
{
    partial class FrmTelaPrincipal
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
            btnFrmCadastroProduto = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnFrmCadastroProduto
            // 
            btnFrmCadastroProduto.Location = new Point(8, 16);
            btnFrmCadastroProduto.Name = "btnFrmCadastroProduto";
            btnFrmCadastroProduto.Size = new Size(208, 23);
            btnFrmCadastroProduto.TabIndex = 0;
            btnFrmCadastroProduto.Text = "Cadastro de Produtos";
            btnFrmCadastroProduto.UseVisualStyleBackColor = true;
            btnFrmCadastroProduto.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 16);
            button2.Name = "button2";
            button2.Size = new Size(216, 23);
            button2.TabIndex = 1;
            button2.Text = "Lista de Produtos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sem_título;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 500);
            Controls.Add(button2);
            Controls.Add(btnFrmCadastroProduto);
            Name = "FrmTelaPrincipal";
            ShowIcon = false;
            Text = "ProjetoValidacao1";
            Load += FrmTelaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmCadastroProduto;
        private Button button2;
    }
}