
namespace Adega_2
{
    partial class frmFiltrarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrarEstoque));
            this.pnlFiltrarEstoque = new System.Windows.Forms.Panel();
            this.pnlEstoque = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurarEstoque = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltrarEstoque = new System.Windows.Forms.Label();
            this.pnlFiltrarEstoque.SuspendLayout();
            this.pnlEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltrarEstoque
            // 
            this.pnlFiltrarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.pnlFiltrarEstoque.Controls.Add(this.pnlEstoque);
            this.pnlFiltrarEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltrarEstoque.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrarEstoque.Name = "pnlFiltrarEstoque";
            this.pnlFiltrarEstoque.Size = new System.Drawing.Size(848, 494);
            this.pnlFiltrarEstoque.TabIndex = 0;
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.pnlEstoque.Controls.Add(this.dgvEstoque);
            this.pnlEstoque.Controls.Add(this.btnProcurarEstoque);
            this.pnlEstoque.Controls.Add(this.txtFiltrar);
            this.pnlEstoque.Controls.Add(this.lblFiltrarEstoque);
            this.pnlEstoque.Location = new System.Drawing.Point(3, 3);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(845, 458);
            this.pnlEstoque.TabIndex = 2;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeProduto,
            this.colUnidade,
            this.colQuantidade,
            this.colCategoria});
            this.dgvEstoque.Location = new System.Drawing.Point(19, 98);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(794, 332);
            this.dgvEstoque.TabIndex = 3;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeProduto.HeaderText = "Nome_produto";
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            // 
            // colUnidade
            // 
            this.colUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnidade.HeaderText = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.ReadOnly = true;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuantidade.HeaderText = "Qntd_estoque";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // btnProcurarEstoque
            // 
            this.btnProcurarEstoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcurarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnProcurarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarEstoque.Image")));
            this.btnProcurarEstoque.Location = new System.Drawing.Point(674, 26);
            this.btnProcurarEstoque.Name = "btnProcurarEstoque";
            this.btnProcurarEstoque.Size = new System.Drawing.Size(139, 48);
            this.btnProcurarEstoque.TabIndex = 2;
            this.btnProcurarEstoque.Text = "Procurar";
            this.btnProcurarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProcurarEstoque.UseVisualStyleBackColor = true;
            this.btnProcurarEstoque.Click += new System.EventHandler(this.btnProcurarEstoque_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(103, 41);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(213, 20);
            this.txtFiltrar.TabIndex = 1;
            // 
            // lblFiltrarEstoque
            // 
            this.lblFiltrarEstoque.AutoSize = true;
            this.lblFiltrarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFiltrarEstoque.ForeColor = System.Drawing.Color.White;
            this.lblFiltrarEstoque.Location = new System.Drawing.Point(40, 42);
            this.lblFiltrarEstoque.Name = "lblFiltrarEstoque";
            this.lblFiltrarEstoque.Size = new System.Drawing.Size(52, 17);
            this.lblFiltrarEstoque.TabIndex = 0;
            this.lblFiltrarEstoque.Text = "Filtrar: ";
            // 
            // frmFiltrarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 494);
            this.Controls.Add(this.pnlFiltrarEstoque);
            this.Name = "frmFiltrarEstoque";
            this.Text = "frmFiltrarEstoque";
            this.pnlFiltrarEstoque.ResumeLayout(false);
            this.pnlEstoque.ResumeLayout(false);
            this.pnlEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltrarEstoque;
        private System.Windows.Forms.Panel pnlEstoque;
        private System.Windows.Forms.Button btnProcurarEstoque;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFiltrarEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
    }
}