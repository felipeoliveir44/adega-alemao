
namespace Adega_2
{
    partial class frmTesteAutoComplete
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
            this.lblNomeAuto = new System.Windows.Forms.Label();
            this.txtNomeAuto = new System.Windows.Forms.TextBox();
            this.lblCategoriasAuto = new System.Windows.Forms.Label();
            this.cboCategoriasAuto = new System.Windows.Forms.ComboBox();
            this.btnPesquisarAuto = new System.Windows.Forms.Button();
            this.btnLimparAuto = new System.Windows.Forms.Button();
            this.btnSairAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeAuto
            // 
            this.lblNomeAuto.AutoSize = true;
            this.lblNomeAuto.Location = new System.Drawing.Point(80, 68);
            this.lblNomeAuto.Name = "lblNomeAuto";
            this.lblNomeAuto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAuto.TabIndex = 0;
            this.lblNomeAuto.Text = "Nome";
            // 
            // txtNomeAuto
            // 
            this.txtNomeAuto.Location = new System.Drawing.Point(160, 66);
            this.txtNomeAuto.Name = "txtNomeAuto";
            this.txtNomeAuto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAuto.TabIndex = 1;
            // 
            // lblCategoriasAuto
            // 
            this.lblCategoriasAuto.AutoSize = true;
            this.lblCategoriasAuto.Location = new System.Drawing.Point(80, 129);
            this.lblCategoriasAuto.Name = "lblCategoriasAuto";
            this.lblCategoriasAuto.Size = new System.Drawing.Size(57, 13);
            this.lblCategoriasAuto.TabIndex = 2;
            this.lblCategoriasAuto.Text = "Categorias";
            // 
            // cboCategoriasAuto
            // 
            this.cboCategoriasAuto.FormattingEnabled = true;
            this.cboCategoriasAuto.Location = new System.Drawing.Point(160, 129);
            this.cboCategoriasAuto.Name = "cboCategoriasAuto";
            this.cboCategoriasAuto.Size = new System.Drawing.Size(121, 21);
            this.cboCategoriasAuto.TabIndex = 3;
            this.cboCategoriasAuto.SelectedIndexChanged += new System.EventHandler(this.cboCategoriasAuto_SelectedIndexChanged);
            this.cboCategoriasAuto.SelectionChangeCommitted += new System.EventHandler(this.cboCategoriasAuto_SelectionChangeCommitted);
            // 
            // btnPesquisarAuto
            // 
            this.btnPesquisarAuto.Location = new System.Drawing.Point(396, 58);
            this.btnPesquisarAuto.Name = "btnPesquisarAuto";
            this.btnPesquisarAuto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarAuto.TabIndex = 4;
            this.btnPesquisarAuto.Text = "Pesquisar";
            this.btnPesquisarAuto.UseVisualStyleBackColor = true;
            //this.btnPesquisarAuto.Click += new System.EventHandler(this.btnPesquisarAuto_Click);
            // 
            // btnLimparAuto
            // 
            this.btnLimparAuto.Location = new System.Drawing.Point(396, 119);
            this.btnLimparAuto.Name = "btnLimparAuto";
            this.btnLimparAuto.Size = new System.Drawing.Size(75, 23);
            this.btnLimparAuto.TabIndex = 5;
            this.btnLimparAuto.Text = "Limpar";
            this.btnLimparAuto.UseVisualStyleBackColor = true;
            // 
            // btnSairAuto
            // 
            this.btnSairAuto.Location = new System.Drawing.Point(396, 188);
            this.btnSairAuto.Name = "btnSairAuto";
            this.btnSairAuto.Size = new System.Drawing.Size(75, 23);
            this.btnSairAuto.TabIndex = 6;
            this.btnSairAuto.Text = "Sair";
            this.btnSairAuto.UseVisualStyleBackColor = true;
            // 
            // frmTesteAutoComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSairAuto);
            this.Controls.Add(this.btnLimparAuto);
            this.Controls.Add(this.btnPesquisarAuto);
            this.Controls.Add(this.cboCategoriasAuto);
            this.Controls.Add(this.lblCategoriasAuto);
            this.Controls.Add(this.txtNomeAuto);
            this.Controls.Add(this.lblNomeAuto);
            this.Name = "frmTesteAutoComplete";
            this.Text = "frmTesteAutoComplete";
            this.Load += new System.EventHandler(this.frmTesteAutoComplete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAuto;
        private System.Windows.Forms.TextBox txtNomeAuto;
        private System.Windows.Forms.Label lblCategoriasAuto;
        private System.Windows.Forms.ComboBox cboCategoriasAuto;
        private System.Windows.Forms.Button btnPesquisarAuto;
        private System.Windows.Forms.Button btnLimparAuto;
        private System.Windows.Forms.Button btnSairAuto;
    }
}