namespace teladelogin
{
    partial class FrmProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.lblBusca = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtcodBarras = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.cmbMedida);
            this.panel1.Controls.Add(this.cmbMarca);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Controls.Add(this.lblRg);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(10, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 248);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(191, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(278, 222);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cmbMedida
            // 
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Items.AddRange(new object[] {
            "Selecione uma medida",
            "Unitário",
            "Kilo",
            "Pacote"});
            this.cmbMedida.Location = new System.Drawing.Point(143, 148);
            this.cmbMedida.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(190, 21);
            this.cmbMedida.TabIndex = 6;
            this.cmbMedida.SelectedIndexChanged += new System.EventHandler(this.cmbMedida_SelectedIndexChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Selecione uma marca",
            ""});
            this.cmbMarca.Location = new System.Drawing.Point(143, 88);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(190, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(72, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 23);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Cadastro de Produtos ";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(88, 222);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(10, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(143, 185);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(190, 20);
            this.txtQuant.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(143, 116);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(190, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(18, 189);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(77, 16);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Quantidade:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(18, 153);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(122, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Unidade de medida:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCpf.Location = new System.Drawing.Point(18, 120);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 16);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "Preço:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRg.Location = new System.Drawing.Point(18, 93);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(66, 16);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "Categoria:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(18, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do produto:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(314, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBusca.Controls.Add(this.btnBuscar);
            this.pnlBusca.Controls.Add(this.txtcodBarras);
            this.pnlBusca.Controls.Add(this.lblMatricula);
            this.pnlBusca.Controls.Add(this.lblBusca);
            this.pnlBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBusca.Location = new System.Drawing.Point(10, 22);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(376, 118);
            this.pnlBusca.TabIndex = 5;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBusca.Location = new System.Drawing.Point(84, 11);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(202, 23);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Pesquisa de Produto";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatricula.Location = new System.Drawing.Point(18, 45);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(72, 16);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "ID Produto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(88, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtcodBarras
            // 
            this.txtcodBarras.Location = new System.Drawing.Point(88, 45);
            this.txtcodBarras.Name = "txtcodBarras";
            this.txtcodBarras.Size = new System.Drawing.Size(202, 20);
            this.txtcodBarras.TabIndex = 2;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 412);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlBusca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtcodBarras;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblBusca;
    }
}