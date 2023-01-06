
namespace Adega_2
{
    partial class frmEstoque
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
            this.pnlNovoProduto = new System.Windows.Forms.Panel();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.lblProdutosEstoque = new System.Windows.Forms.Label();
            this.pnlEstoque = new System.Windows.Forms.Panel();
            this.pnlNovoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNovoProduto
            // 
            this.pnlNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.pnlNovoProduto.Controls.Add(this.btnNovoProduto);
            this.pnlNovoProduto.Controls.Add(this.lblProdutosEstoque);
            this.pnlNovoProduto.Location = new System.Drawing.Point(75, 30);
            this.pnlNovoProduto.Name = "pnlNovoProduto";
            this.pnlNovoProduto.Size = new System.Drawing.Size(845, 132);
            this.pnlNovoProduto.TabIndex = 0;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.btnNovoProduto.Location = new System.Drawing.Point(674, 53);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(139, 35);
            this.btnNovoProduto.TabIndex = 1;
            this.btnNovoProduto.Text = "Novo produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // lblProdutosEstoque
            // 
            this.lblProdutosEstoque.AutoSize = true;
            this.lblProdutosEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.lblProdutosEstoque.Location = new System.Drawing.Point(37, 49);
            this.lblProdutosEstoque.Name = "lblProdutosEstoque";
            this.lblProdutosEstoque.Size = new System.Drawing.Size(271, 31);
            this.lblProdutosEstoque.TabIndex = 0;
            this.lblProdutosEstoque.Text = "Produtos em estoque";
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.pnlEstoque.Location = new System.Drawing.Point(75, 188);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(845, 458);
            this.pnlEstoque.TabIndex = 1;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1026, 680);
            this.Controls.Add(this.pnlEstoque);
            this.Controls.Add(this.pnlNovoProduto);
            this.Name = "frmEstoque";
            this.Text = "frmEstoque";
            this.pnlNovoProduto.ResumeLayout(false);
            this.pnlNovoProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNovoProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Label lblProdutosEstoque;
        private System.Windows.Forms.Panel pnlEstoque;
    }
}