
namespace Adega_2
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btnBuscarVendas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPesquisarProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarProdutos = new System.Windows.Forms.TextBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblBuscarVendas = new System.Windows.Forms.Label();
            this.dgvPesquisarProdutos = new System.Windows.Forms.DataGridView();
            this.colnome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldata_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvalor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarVendas
            // 
            this.btnBuscarVendas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVendas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVendas.Image")));
            this.btnBuscarVendas.Location = new System.Drawing.Point(503, 120);
            this.btnBuscarVendas.Name = "btnBuscarVendas";
            this.btnBuscarVendas.Size = new System.Drawing.Size(106, 42);
            this.btnBuscarVendas.TabIndex = 7;
            this.btnBuscarVendas.Text = "Buscar";
            this.btnBuscarVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarVendas.UseVisualStyleBackColor = true;
            this.btnBuscarVendas.Click += new System.EventHandler(this.btnBuscarVendas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPesquisarProdutos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPesquisarProdutos);
            this.panel1.Controls.Add(this.dtpFinal);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.lblBuscarVendas);
            this.panel1.Controls.Add(this.btnBuscarVendas);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 196);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(239, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data Início";
            // 
            // lblPesquisarProdutos
            // 
            this.lblPesquisarProdutos.AutoSize = true;
            this.lblPesquisarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPesquisarProdutos.Location = new System.Drawing.Point(21, 103);
            this.lblPesquisarProdutos.Name = "lblPesquisarProdutos";
            this.lblPesquisarProdutos.Size = new System.Drawing.Size(129, 17);
            this.lblPesquisarProdutos.TabIndex = 15;
            this.lblPesquisarProdutos.Text = "Pesquisar Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(361, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data Final";
            // 
            // txtPesquisarProdutos
            // 
            this.txtPesquisarProdutos.Location = new System.Drawing.Point(24, 130);
            this.txtPesquisarProdutos.Name = "txtPesquisarProdutos";
            this.txtPesquisarProdutos.Size = new System.Drawing.Size(206, 23);
            this.txtPesquisarProdutos.TabIndex = 14;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(364, 130);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(106, 23);
            this.dtpFinal.TabIndex = 15;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(242, 130);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(109, 23);
            this.dtpInicio.TabIndex = 14;
            // 
            // lblBuscarVendas
            // 
            this.lblBuscarVendas.AutoSize = true;
            this.lblBuscarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBuscarVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblBuscarVendas.Location = new System.Drawing.Point(36, 35);
            this.lblBuscarVendas.Name = "lblBuscarVendas";
            this.lblBuscarVendas.Size = new System.Drawing.Size(198, 31);
            this.lblBuscarVendas.TabIndex = 12;
            this.lblBuscarVendas.Text = "Buscar Vendas";
            // 
            // dgvPesquisarProdutos
            // 
            this.dgvPesquisarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnome_produto,
            this.colquantidade,
            this.coldata_pedido,
            this.colvalor_total});
            this.dgvPesquisarProdutos.Location = new System.Drawing.Point(527, 264);
            this.dgvPesquisarProdutos.Name = "dgvPesquisarProdutos";
            this.dgvPesquisarProdutos.Size = new System.Drawing.Size(470, 335);
            this.dgvPesquisarProdutos.TabIndex = 12;
            // 
            // colnome_produto
            // 
            this.colnome_produto.HeaderText = "nome_produto";
            this.colnome_produto.Name = "colnome_produto";
            this.colnome_produto.Width = 107;
            // 
            // colquantidade
            // 
            this.colquantidade.HeaderText = "quantidade";
            this.colquantidade.Name = "colquantidade";
            this.colquantidade.Width = 107;
            // 
            // coldata_pedido
            // 
            this.coldata_pedido.HeaderText = "data_pedido";
            this.coldata_pedido.Name = "coldata_pedido";
            this.coldata_pedido.Width = 107;
            // 
            // colvalor_total
            // 
            this.colvalor_total.HeaderText = "valor_total";
            this.colvalor_total.Name = "colvalor_total";
            this.colvalor_total.Width = 107;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(24, 264);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(470, 335);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1026, 650);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvPesquisarProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarVendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuscarVendas;
        private System.Windows.Forms.DataGridView dgvPesquisarProdutos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtPesquisarProdutos;
        private System.Windows.Forms.Label lblPesquisarProdutos;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldata_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvalor_total;
    }
}