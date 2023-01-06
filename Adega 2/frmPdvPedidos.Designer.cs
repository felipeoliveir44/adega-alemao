
namespace Adega_2
{
    partial class frmPdvPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdvPedidos));
            this.pnlPdvPedidos = new System.Windows.Forms.Panel();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cboTipoPreco = new System.Windows.Forms.ComboBox();
            this.lblTipoPreco = new System.Windows.Forms.Label();
            this.grpPedidos = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorUnitário = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cboPedidosProdutos = new System.Windows.Forms.ComboBox();
            this.lblPdvProdutos = new System.Windows.Forms.Label();
            this.dgvPdv = new System.Windows.Forms.DataGridView();
            this.ColNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProximaEtapa = new System.Windows.Forms.Button();
            this.pnlPdvPedidos.SuspendLayout();
            this.grpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPdvPedidos
            // 
            this.pnlPdvPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlPdvPedidos.Controls.Add(this.cboFormaPagamento);
            this.pnlPdvPedidos.Controls.Add(this.lblFormaPagamento);
            this.pnlPdvPedidos.Controls.Add(this.btnPesquisar);
            this.pnlPdvPedidos.Controls.Add(this.cboTipoPreco);
            this.pnlPdvPedidos.Controls.Add(this.lblTipoPreco);
            this.pnlPdvPedidos.Controls.Add(this.grpPedidos);
            this.pnlPdvPedidos.Controls.Add(this.lblValorTotal);
            this.pnlPdvPedidos.Controls.Add(this.btnRemover);
            this.pnlPdvPedidos.Controls.Add(this.cboPedidosProdutos);
            this.pnlPdvPedidos.Controls.Add(this.lblPdvProdutos);
            this.pnlPdvPedidos.Controls.Add(this.dgvPdv);
            this.pnlPdvPedidos.Controls.Add(this.btnProximaEtapa);
            this.pnlPdvPedidos.Location = new System.Drawing.Point(1, 1);
            this.pnlPdvPedidos.Name = "pnlPdvPedidos";
            this.pnlPdvPedidos.Size = new System.Drawing.Size(998, 627);
            this.pnlPdvPedidos.TabIndex = 0;
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "Pix"});
            this.cboFormaPagamento.Location = new System.Drawing.Point(363, 39);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(148, 21);
            this.cboFormaPagamento.TabIndex = 14;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormaPagamento.Location = new System.Drawing.Point(360, 10);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(107, 13);
            this.lblFormaPagamento.TabIndex = 13;
            this.lblFormaPagamento.Text = "Forma de pagamento";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(559, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(116, 35);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cboTipoPreco
            // 
            this.cboTipoPreco.FormattingEnabled = true;
            this.cboTipoPreco.Items.AddRange(new object[] {
            "Gelado",
            "Quente",
            "Preço de custo"});
            this.cboTipoPreco.Location = new System.Drawing.Point(203, 39);
            this.cboTipoPreco.Name = "cboTipoPreco";
            this.cboTipoPreco.Size = new System.Drawing.Size(148, 21);
            this.cboTipoPreco.TabIndex = 12;
            // 
            // lblTipoPreco
            // 
            this.lblTipoPreco.AutoSize = true;
            this.lblTipoPreco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPreco.Location = new System.Drawing.Point(200, 10);
            this.lblTipoPreco.Name = "lblTipoPreco";
            this.lblTipoPreco.Size = new System.Drawing.Size(55, 13);
            this.lblTipoPreco.TabIndex = 11;
            this.lblTipoPreco.Text = "Descrição";
            // 
            // grpPedidos
            // 
            this.grpPedidos.Controls.Add(this.txtNomeCliente);
            this.grpPedidos.Controls.Add(this.lblNomeCliente);
            this.grpPedidos.Controls.Add(this.txtDescricao);
            this.grpPedidos.Controls.Add(this.lblDescricao);
            this.grpPedidos.Controls.Add(this.txtTotal);
            this.grpPedidos.Controls.Add(this.txtUnitario);
            this.grpPedidos.Controls.Add(this.txtQtde);
            this.grpPedidos.Controls.Add(this.txtNome);
            this.grpPedidos.Controls.Add(this.txtID);
            this.grpPedidos.Controls.Add(this.lblTotal);
            this.grpPedidos.Controls.Add(this.lblValorUnitário);
            this.grpPedidos.Controls.Add(this.btnAdicionarProduto);
            this.grpPedidos.Controls.Add(this.lblQuantidade);
            this.grpPedidos.Controls.Add(this.lblNome);
            this.grpPedidos.Controls.Add(this.lblID);
            this.grpPedidos.Location = new System.Drawing.Point(22, 101);
            this.grpPedidos.Name = "grpPedidos";
            this.grpPedidos.Size = new System.Drawing.Size(916, 183);
            this.grpPedidos.TabIndex = 10;
            this.grpPedidos.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(22, 105);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(139, 20);
            this.txtNomeCliente.TabIndex = 13;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(17, 68);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(73, 25);
            this.lblNomeCliente.TabIndex = 12;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(381, 105);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(74, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(376, 68);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(99, 25);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(676, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(580, 105);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.ReadOnly = true;
            this.txtUnitario.Size = new System.Drawing.Size(73, 20);
            this.txtUnitario.TabIndex = 8;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(492, 105);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(57, 20);
            this.txtQtde.TabIndex = 7;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(223, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 105);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(33, 20);
            this.txtID.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(671, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblValorUnitário
            // 
            this.lblValorUnitário.AutoSize = true;
            this.lblValorUnitário.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblValorUnitário.ForeColor = System.Drawing.Color.White;
            this.lblValorUnitário.Location = new System.Drawing.Point(575, 68);
            this.lblValorUnitário.Name = "lblValorUnitário";
            this.lblValorUnitário.Size = new System.Drawing.Size(78, 25);
            this.lblValorUnitário.TabIndex = 3;
            this.lblValorUnitário.Text = "Unitário";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(761, 79);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(149, 50);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(487, 68);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(55, 25);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Qtde";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(218, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(172, 68);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.lblValorTotal.Location = new System.Drawing.Point(104, 516);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(67, 31);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "0,00";
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(647, 514);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 46);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cboPedidosProdutos
            // 
            this.cboPedidosProdutos.FormattingEnabled = true;
            this.cboPedidosProdutos.Location = new System.Drawing.Point(22, 39);
            this.cboPedidosProdutos.Name = "cboPedidosProdutos";
            this.cboPedidosProdutos.Size = new System.Drawing.Size(148, 21);
            this.cboPedidosProdutos.TabIndex = 7;
            // 
            // lblPdvProdutos
            // 
            this.lblPdvProdutos.AutoSize = true;
            this.lblPdvProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPdvProdutos.Location = new System.Drawing.Point(19, 10);
            this.lblPdvProdutos.Name = "lblPdvProdutos";
            this.lblPdvProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblPdvProdutos.TabIndex = 6;
            this.lblPdvProdutos.Text = "Produtos";
            // 
            // dgvPdv
            // 
            this.dgvPdv.AllowUserToAddRows = false;
            this.dgvPdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNomeCliente,
            this.id,
            this.nome_produto,
            this.descricao,
            this.quantidade,
            this.valor_unitario,
            this.valor_total});
            this.dgvPdv.Location = new System.Drawing.Point(22, 312);
            this.dgvPdv.Name = "dgvPdv";
            this.dgvPdv.Size = new System.Drawing.Size(916, 197);
            this.dgvPdv.TabIndex = 5;
            // 
            // ColNomeCliente
            // 
            this.ColNomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNomeCliente.HeaderText = "Nome cliente";
            this.ColNomeCliente.Name = "ColNomeCliente";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_produto.HeaderText = "Nome";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valor_unitario
            // 
            this.valor_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor_unitario.HeaderText = "Valor Unitário";
            this.valor_unitario.Name = "valor_unitario";
            // 
            // valor_total
            // 
            this.valor_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            // 
            // btnProximaEtapa
            // 
            this.btnProximaEtapa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProximaEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximaEtapa.ForeColor = System.Drawing.Color.White;
            this.btnProximaEtapa.Image = ((System.Drawing.Image)(resources.GetObject("btnProximaEtapa.Image")));
            this.btnProximaEtapa.Location = new System.Drawing.Point(792, 514);
            this.btnProximaEtapa.Name = "btnProximaEtapa";
            this.btnProximaEtapa.Size = new System.Drawing.Size(146, 46);
            this.btnProximaEtapa.TabIndex = 3;
            this.btnProximaEtapa.Text = "Próxima etapa";
            this.btnProximaEtapa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProximaEtapa.UseVisualStyleBackColor = true;
            this.btnProximaEtapa.Click += new System.EventHandler(this.btnProximaEtapa_Click);
            // 
            // frmPdvPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1025, 627);
            this.Controls.Add(this.pnlPdvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPdvPedidos";
            this.Text = "frmPdv";
            this.Load += new System.EventHandler(this.frmPdvPedidos_Load);
            this.pnlPdvPedidos.ResumeLayout(false);
            this.pnlPdvPedidos.PerformLayout();
            this.grpPedidos.ResumeLayout(false);
            this.grpPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPdvPedidos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnProximaEtapa;
        private System.Windows.Forms.DataGridView dgvPdv;
        private System.Windows.Forms.Label lblPdvProdutos;
        private System.Windows.Forms.ComboBox cboPedidosProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorUnitário;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cboTipoPreco;
        private System.Windows.Forms.Label lblTipoPreco;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
    }
}