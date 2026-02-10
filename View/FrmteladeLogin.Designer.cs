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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmteladeLogin));
            btnentrar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // btnentrar
            // 
            btnentrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnentrar.Location = new Point(290, 294);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(173, 38);
            btnentrar.TabIndex = 0;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(281, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(221, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(221, 241);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(280, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(203, 23);
            txtSenha.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "FrmLoginPng.png");
            // 
            // FrmteladeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FrmLoginPng;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(545, 369);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnentrar);
            Name = "FrmteladeLogin";
            Text = "FrmTeladeLogin";
            Load += FrmteladeLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnentrar;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private ImageList imageList1;
    }
}