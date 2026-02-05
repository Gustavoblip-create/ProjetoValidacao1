namespace ProjetoValidacao1.View
{
    partial class FrmteladeLogin
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
            btnentrar = new Button();
            txtemail = new TextBox();
            lblemail = new Label();
            lblsenha = new Label();
            txtsenha = new TextBox();
            SuspendLayout();
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(142, 322);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(75, 23);
            btnentrar.TabIndex = 0;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(139, 217);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 1;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(73, 217);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(41, 15);
            lblemail.TabIndex = 2;
            lblemail.Text = "E-mail";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(73, 276);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(139, 276);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 4;
            // 
            // FrmteladeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsenha);
            Controls.Add(lblsenha);
            Controls.Add(lblemail);
            Controls.Add(txtemail);
            Controls.Add(btnentrar);
            Name = "FrmteladeLogin";
            Text = "FrmteladeLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnentrar;
        private TextBox txtemail;
        private Label lblemail;
        private Label lblsenha;
        private TextBox txtsenha;
    }
}