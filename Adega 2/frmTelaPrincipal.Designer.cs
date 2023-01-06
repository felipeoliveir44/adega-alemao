
namespace Adega_2
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPdv = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pnlNavUser = new System.Windows.Forms.Panel();
            this.lblOlaUsuario = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlNavUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Controls.Add(this.btnGerenciar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnPdv);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.pnlNavUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 655);
            this.panel1.TabIndex = 0;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.Location = new System.Drawing.Point(0, 424);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(205, 70);
            this.btnCaixa.TabIndex = 7;
            this.btnCaixa.Text = "Fechar caixa";
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.Image")));
            this.btnGerenciar.Location = new System.Drawing.Point(0, 354);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(205, 70);
            this.btnGerenciar.TabIndex = 3;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(0, 585);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(205, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPdv
            // 
            this.btnPdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPdv.FlatAppearance.BorderSize = 0;
            this.btnPdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPdv.ForeColor = System.Drawing.Color.White;
            this.btnPdv.Image = ((System.Drawing.Image)(resources.GetObject("btnPdv.Image")));
            this.btnPdv.Location = new System.Drawing.Point(0, 284);
            this.btnPdv.Name = "btnPdv";
            this.btnPdv.Size = new System.Drawing.Size(205, 70);
            this.btnPdv.TabIndex = 4;
            this.btnPdv.Text = "PDV       ";
            this.btnPdv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPdv.UseVisualStyleBackColor = true;
            this.btnPdv.Click += new System.EventHandler(this.btnPdv_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(0, 214);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(205, 70);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "Vendas  ";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(0, 144);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(205, 70);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // pnlNavUser
            // 
            this.pnlNavUser.Controls.Add(this.lblOlaUsuario);
            this.pnlNavUser.Controls.Add(this.pctUsuario);
            this.pnlNavUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavUser.Location = new System.Drawing.Point(0, 0);
            this.pnlNavUser.Name = "pnlNavUser";
            this.pnlNavUser.Size = new System.Drawing.Size(205, 144);
            this.pnlNavUser.TabIndex = 0;
            // 
            // lblOlaUsuario
            // 
            this.lblOlaUsuario.AutoSize = true;
            this.lblOlaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlaUsuario.ForeColor = System.Drawing.Color.White;
            this.lblOlaUsuario.Location = new System.Drawing.Point(39, 89);
            this.lblOlaUsuario.Name = "lblOlaUsuario";
            this.lblOlaUsuario.Size = new System.Drawing.Size(127, 17);
            this.lblOlaUsuario.TabIndex = 1;
            this.lblOlaUsuario.Text = "Olá, administrador!";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(66, 12);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(63, 63);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUsuario.TabIndex = 0;
            this.pctUsuario.TabStop = false;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormLoader.Location = new System.Drawing.Point(205, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1096, 655);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1301, 655);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.panel1.ResumeLayout(false);
            this.pnlNavUser.ResumeLayout(false);
            this.pnlNavUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNavUser;
        private System.Windows.Forms.Label lblOlaUsuario;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPdv;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button btnCaixa;
    }
}

