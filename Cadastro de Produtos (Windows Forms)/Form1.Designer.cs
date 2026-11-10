namespace Cadastro_de_Produtos__Windows_Forms_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labe1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtCodigoValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtNomeCampo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.Label();
            this.cmbCategoriaCampo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoCampo = new System.Windows.Forms.TextBox();
            this.cmbFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedorCampo = new System.Windows.Forms.ComboBox();
            this.nudPrecoCusto = new System.Windows.Forms.Label();
            this.txtMargem = new System.Windows.Forms.Label();
            this.nudStockInicial = new System.Windows.Forms.Label();
            this.nudPrecoVenda = new System.Windows.Forms.Label();
            this.nudStockMinimo = new System.Windows.Forms.Label();
            this.nudPrecoCustoCampo = new System.Windows.Forms.NumericUpDown();
            this.nudStockInicialCampo = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoVendaCampo = new System.Windows.Forms.NumericUpDown();
            this.nudStockMinimoCampo = new System.Windows.Forms.NumericUpDown();
            this.txtMargemValor = new System.Windows.Forms.TextBox();
            this.chkProdutoAtivo = new System.Windows.Forms.CheckBox();
            this.dtpDataCadastro = new System.Windows.Forms.Label();
            this.dtpDataCadastroCampo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCustoCampo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicialCampo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVendaCampo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimoCampo)).BeginInit();
            this.SuspendLayout();
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labe1.Location = new System.Drawing.Point(190, 170);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(109, 13);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Cadastro de Produtos";
            this.labe1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFornecedorCampo);
            this.groupBox1.Controls.Add(this.cmbFornecedor);
            this.groupBox1.Controls.Add(this.txtDescricaoCampo);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.cmbCategoriaCampo);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.txtNomeCampo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCodigoValor);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMargemValor);
            this.groupBox2.Controls.Add(this.nudStockMinimoCampo);
            this.groupBox2.Controls.Add(this.nudPrecoVendaCampo);
            this.groupBox2.Controls.Add(this.nudStockInicialCampo);
            this.groupBox2.Controls.Add(this.nudPrecoCustoCampo);
            this.groupBox2.Controls.Add(this.nudStockMinimo);
            this.groupBox2.Controls.Add(this.nudPrecoVenda);
            this.groupBox2.Controls.Add(this.nudStockInicial);
            this.groupBox2.Controls.Add(this.txtMargem);
            this.groupBox2.Controls.Add(this.nudPrecoCusto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precificação e Estoque";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDataCadastroCampo);
            this.groupBox3.Controls.Add(this.dtpDataCadastro);
            this.groupBox3.Controls.Add(this.chkProdutoAtivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(486, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 142);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação / Detalhes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro De Produtos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 74);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(237, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 41);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(392, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 41);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(549, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(131, 41);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(82, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(131, 41);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(-8, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 68);
            this.panel2.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(22, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 13);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Código:";
            this.txtCodigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigoValor
            // 
            this.txtCodigoValor.Location = new System.Drawing.Point(25, 34);
            this.txtCodigoValor.Name = "txtCodigoValor";
            this.txtCodigoValor.ReadOnly = true;
            this.txtCodigoValor.Size = new System.Drawing.Size(122, 22);
            this.txtCodigoValor.TabIndex = 1;
            this.txtCodigoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(194, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(93, 13);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome do Produto:";
            // 
            // txtNomeCampo
            // 
            this.txtNomeCampo.Location = new System.Drawing.Point(197, 34);
            this.txtNomeCampo.MaxLength = 100;
            this.txtNomeCampo.Name = "txtNomeCampo";
            this.txtNomeCampo.Size = new System.Drawing.Size(229, 22);
            this.txtNomeCampo.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoSize = true;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.Location = new System.Drawing.Point(494, 16);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(55, 13);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.Text = "Categoria:";
            // 
            // cmbCategoriaCampo
            // 
            this.cmbCategoriaCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCampo.FormattingEnabled = true;
            this.cmbCategoriaCampo.Location = new System.Drawing.Point(497, 32);
            this.cmbCategoriaCampo.Name = "cmbCategoriaCampo";
            this.cmbCategoriaCampo.Size = new System.Drawing.Size(205, 24);
            this.cmbCategoriaCampo.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(305, 64);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(55, 13);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.Text = "Descrição";
            // 
            // txtDescricaoCampo
            // 
            this.txtDescricaoCampo.Location = new System.Drawing.Point(308, 80);
            this.txtDescricaoCampo.MaxLength = 500;
            this.txtDescricaoCampo.Multiline = true;
            this.txtDescricaoCampo.Name = "txtDescricaoCampo";
            this.txtDescricaoCampo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoCampo.Size = new System.Drawing.Size(394, 63);
            this.txtDescricaoCampo.TabIndex = 7;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.AutoSize = true;
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.Location = new System.Drawing.Point(22, 64);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(64, 13);
            this.cmbFornecedor.TabIndex = 8;
            this.cmbFornecedor.Text = "Fornecedor:";
            // 
            // cmbFornecedorCampo
            // 
            this.cmbFornecedorCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedorCampo.FormattingEnabled = true;
            this.cmbFornecedorCampo.Location = new System.Drawing.Point(25, 80);
            this.cmbFornecedorCampo.Name = "cmbFornecedorCampo";
            this.cmbFornecedorCampo.Size = new System.Drawing.Size(205, 24);
            this.cmbFornecedorCampo.TabIndex = 9;
            // 
            // nudPrecoCusto
            // 
            this.nudPrecoCusto.AutoSize = true;
            this.nudPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecoCusto.Location = new System.Drawing.Point(6, 28);
            this.nudPrecoCusto.Name = "nudPrecoCusto";
            this.nudPrecoCusto.Size = new System.Drawing.Size(106, 13);
            this.nudPrecoCusto.TabIndex = 10;
            this.nudPrecoCusto.Text = "Preço de Custo (R$):";
            // 
            // txtMargem
            // 
            this.txtMargem.AutoSize = true;
            this.txtMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargem.Location = new System.Drawing.Point(6, 71);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(65, 13);
            this.txtMargem.TabIndex = 11;
            this.txtMargem.Text = "Margem (%):";
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.AutoSize = true;
            this.nudStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockInicial.Location = new System.Drawing.Point(6, 110);
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(66, 13);
            this.nudStockInicial.TabIndex = 12;
            this.nudStockInicial.Text = "Stock Inical:";
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.AutoSize = true;
            this.nudPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecoVenda.Location = new System.Drawing.Point(248, 28);
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(107, 13);
            this.nudPrecoVenda.TabIndex = 13;
            this.nudPrecoVenda.Text = "Preço de Venda(R$):";
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.AutoSize = true;
            this.nudStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockMinimo.Location = new System.Drawing.Point(280, 110);
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(74, 13);
            this.nudStockMinimo.TabIndex = 14;
            this.nudStockMinimo.Text = "Stock Minimo:";
            // 
            // nudPrecoCustoCampo
            // 
            this.nudPrecoCustoCampo.DecimalPlaces = 2;
            this.nudPrecoCustoCampo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudPrecoCustoCampo.Location = new System.Drawing.Point(110, 24);
            this.nudPrecoCustoCampo.Name = "nudPrecoCustoCampo";
            this.nudPrecoCustoCampo.Size = new System.Drawing.Size(120, 22);
            this.nudPrecoCustoCampo.TabIndex = 15;
            // 
            // nudStockInicialCampo
            // 
            this.nudStockInicialCampo.Location = new System.Drawing.Point(82, 106);
            this.nudStockInicialCampo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStockInicialCampo.Name = "nudStockInicialCampo";
            this.nudStockInicialCampo.Size = new System.Drawing.Size(120, 22);
            this.nudStockInicialCampo.TabIndex = 16;
            // 
            // nudPrecoVendaCampo
            // 
            this.nudPrecoVendaCampo.Location = new System.Drawing.Point(361, 24);
            this.nudPrecoVendaCampo.Name = "nudPrecoVendaCampo";
            this.nudPrecoVendaCampo.Size = new System.Drawing.Size(87, 22);
            this.nudPrecoVendaCampo.TabIndex = 17;
            // 
            // nudStockMinimoCampo
            // 
            this.nudStockMinimoCampo.Location = new System.Drawing.Point(361, 104);
            this.nudStockMinimoCampo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStockMinimoCampo.Name = "nudStockMinimoCampo";
            this.nudStockMinimoCampo.Size = new System.Drawing.Size(87, 22);
            this.nudStockMinimoCampo.TabIndex = 18;
            // 
            // txtMargemValor
            // 
            this.txtMargemValor.Location = new System.Drawing.Point(95, 66);
            this.txtMargemValor.Name = "txtMargemValor";
            this.txtMargemValor.ReadOnly = true;
            this.txtMargemValor.Size = new System.Drawing.Size(122, 22);
            this.txtMargemValor.TabIndex = 19;
            this.txtMargemValor.Text = "0,00";
            // 
            // chkProdutoAtivo
            // 
            this.chkProdutoAtivo.AutoSize = true;
            this.chkProdutoAtivo.Checked = true;
            this.chkProdutoAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProdutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProdutoAtivo.Location = new System.Drawing.Point(23, 36);
            this.chkProdutoAtivo.Name = "chkProdutoAtivo";
            this.chkProdutoAtivo.Size = new System.Drawing.Size(90, 17);
            this.chkProdutoAtivo.TabIndex = 0;
            this.chkProdutoAtivo.Text = "Produto Ativo";
            this.chkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.AutoSize = true;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Location = new System.Drawing.Point(23, 72);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.dtpDataCadastro.TabIndex = 14;
            this.dtpDataCadastro.Text = "Data de Cadastro";
            // 
            // dtpDataCadastroCampo
            // 
            this.dtpDataCadastroCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastroCampo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroCampo.Location = new System.Drawing.Point(23, 88);
            this.dtpDataCadastroCampo.MaxDate = new System.DateTime(2026, 11, 9, 0, 0, 0, 0);
            this.dtpDataCadastroCampo.Name = "dtpDataCadastroCampo";
            this.dtpDataCadastroCampo.Size = new System.Drawing.Size(216, 20);
            this.dtpDataCadastroCampo.TabIndex = 15;
            this.dtpDataCadastroCampo.Value = new System.DateTime(2026, 11, 9, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCustoCampo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicialCampo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVendaCampo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimoCampo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label cmbCategoria;
        private System.Windows.Forms.TextBox txtNomeCampo;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox txtCodigoValor;
        private System.Windows.Forms.ComboBox cmbFornecedorCampo;
        private System.Windows.Forms.Label cmbFornecedor;
        private System.Windows.Forms.TextBox txtDescricaoCampo;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.ComboBox cmbCategoriaCampo;
        private System.Windows.Forms.Label nudStockMinimo;
        private System.Windows.Forms.Label nudPrecoVenda;
        private System.Windows.Forms.Label nudStockInicial;
        private System.Windows.Forms.Label txtMargem;
        private System.Windows.Forms.Label nudPrecoCusto;
        private System.Windows.Forms.TextBox txtMargemValor;
        private System.Windows.Forms.NumericUpDown nudStockMinimoCampo;
        private System.Windows.Forms.NumericUpDown nudPrecoVendaCampo;
        private System.Windows.Forms.NumericUpDown nudStockInicialCampo;
        private System.Windows.Forms.NumericUpDown nudPrecoCustoCampo;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroCampo;
        private System.Windows.Forms.Label dtpDataCadastro;
        private System.Windows.Forms.CheckBox chkProdutoAtivo;
    }
}

