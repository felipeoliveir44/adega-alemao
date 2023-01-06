
namespace Adega_2
{
    partial class frmGerenciarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarFuncionarios));
            this.pnlCadastroFuncionario = new System.Windows.Forms.Panel();
            this.cboCdtFuncaoFuncionario = new System.Windows.Forms.ComboBox();
            this.cboCdtSttsFuncionario = new System.Windows.Forms.ComboBox();
            this.btnAtualizarFuncionario = new System.Windows.Forms.Button();
            this.lblCdtSttsFuncionario = new System.Windows.Forms.Label();
            this.txtCdtEmail = new System.Windows.Forms.TextBox();
            this.lblCdtEmail = new System.Windows.Forms.Label();
            this.txtCdtSenha = new System.Windows.Forms.TextBox();
            this.lblCdtSenha = new System.Windows.Forms.Label();
            this.lblCdtFuncao = new System.Windows.Forms.Label();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.lblCdtDataContratacao = new System.Windows.Forms.Label();
            this.mskCdtDataContratacao = new System.Windows.Forms.MaskedTextBox();
            this.txtCdtId = new System.Windows.Forms.TextBox();
            this.lblCdtId = new System.Windows.Forms.Label();
            this.lblCdtFone = new System.Windows.Forms.Label();
            this.txtCdtNome = new System.Windows.Forms.TextBox();
            this.mskCdtFone = new System.Windows.Forms.MaskedTextBox();
            this.lblCdtNome = new System.Windows.Forms.Label();
            this.mskCdtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskCdtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCdtDataNascimento = new System.Windows.Forms.Label();
            this.lblCdtCpf = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbofuncionario = new System.Windows.Forms.ComboBox();
            this.dgvListarFuncionarios = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataContratacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.pnlCadastroFuncionario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastroFuncionario
            // 
            this.pnlCadastroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.pnlCadastroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroFuncionario.Controls.Add(this.cboCdtFuncaoFuncionario);
            this.pnlCadastroFuncionario.Controls.Add(this.cboCdtSttsFuncionario);
            this.pnlCadastroFuncionario.Controls.Add(this.btnAtualizarFuncionario);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtSttsFuncionario);
            this.pnlCadastroFuncionario.Controls.Add(this.txtCdtEmail);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtEmail);
            this.pnlCadastroFuncionario.Controls.Add(this.txtCdtSenha);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtSenha);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtFuncao);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCadastroUsuario);
            this.pnlCadastroFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtDataContratacao);
            this.pnlCadastroFuncionario.Controls.Add(this.mskCdtDataContratacao);
            this.pnlCadastroFuncionario.Controls.Add(this.txtCdtId);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtId);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtFone);
            this.pnlCadastroFuncionario.Controls.Add(this.txtCdtNome);
            this.pnlCadastroFuncionario.Controls.Add(this.mskCdtFone);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtNome);
            this.pnlCadastroFuncionario.Controls.Add(this.mskCdtDataNascimento);
            this.pnlCadastroFuncionario.Controls.Add(this.mskCdtCpf);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtDataNascimento);
            this.pnlCadastroFuncionario.Controls.Add(this.lblCdtCpf);
            this.pnlCadastroFuncionario.Location = new System.Drawing.Point(12, 80);
            this.pnlCadastroFuncionario.Name = "pnlCadastroFuncionario";
            this.pnlCadastroFuncionario.Size = new System.Drawing.Size(1002, 204);
            this.pnlCadastroFuncionario.TabIndex = 21;
            // 
            // cboCdtFuncaoFuncionario
            // 
            this.cboCdtFuncaoFuncionario.FormattingEnabled = true;
            this.cboCdtFuncaoFuncionario.Items.AddRange(new object[] {
            "A",
            "F"});
            this.cboCdtFuncaoFuncionario.Location = new System.Drawing.Point(14, 143);
            this.cboCdtFuncaoFuncionario.Name = "cboCdtFuncaoFuncionario";
            this.cboCdtFuncaoFuncionario.Size = new System.Drawing.Size(54, 21);
            this.cboCdtFuncaoFuncionario.TabIndex = 29;
            // 
            // cboCdtSttsFuncionario
            // 
            this.cboCdtSttsFuncionario.FormattingEnabled = true;
            this.cboCdtSttsFuncionario.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.cboCdtSttsFuncionario.Location = new System.Drawing.Point(641, 80);
            this.cboCdtSttsFuncionario.Name = "cboCdtSttsFuncionario";
            this.cboCdtSttsFuncionario.Size = new System.Drawing.Size(80, 21);
            this.cboCdtSttsFuncionario.TabIndex = 28;
            // 
            // btnAtualizarFuncionario
            // 
            this.btnAtualizarFuncionario.AutoSize = true;
            this.btnAtualizarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarFuncionario.Location = new System.Drawing.Point(817, 60);
            this.btnAtualizarFuncionario.Name = "btnAtualizarFuncionario";
            this.btnAtualizarFuncionario.Size = new System.Drawing.Size(151, 40);
            this.btnAtualizarFuncionario.TabIndex = 27;
            this.btnAtualizarFuncionario.Text = "Atualizar informações";
            this.btnAtualizarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarFuncionario.UseVisualStyleBackColor = true;
            this.btnAtualizarFuncionario.Click += new System.EventHandler(this.btnAtualizarFuncionario_Click);
            // 
            // lblCdtSttsFuncionario
            // 
            this.lblCdtSttsFuncionario.AutoSize = true;
            this.lblCdtSttsFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtSttsFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtSttsFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblCdtSttsFuncionario.Location = new System.Drawing.Point(637, 60);
            this.lblCdtSttsFuncionario.Name = "lblCdtSttsFuncionario";
            this.lblCdtSttsFuncionario.Size = new System.Drawing.Size(48, 17);
            this.lblCdtSttsFuncionario.TabIndex = 26;
            this.lblCdtSttsFuncionario.Text = "Status";
            // 
            // txtCdtEmail
            // 
            this.txtCdtEmail.Location = new System.Drawing.Point(391, 80);
            this.txtCdtEmail.Name = "txtCdtEmail";
            this.txtCdtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtCdtEmail.TabIndex = 23;
            // 
            // lblCdtEmail
            // 
            this.lblCdtEmail.AutoSize = true;
            this.lblCdtEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtEmail.ForeColor = System.Drawing.Color.White;
            this.lblCdtEmail.Location = new System.Drawing.Point(388, 60);
            this.lblCdtEmail.Name = "lblCdtEmail";
            this.lblCdtEmail.Size = new System.Drawing.Size(42, 17);
            this.lblCdtEmail.TabIndex = 24;
            this.lblCdtEmail.Text = "Email";
            // 
            // txtCdtSenha
            // 
            this.txtCdtSenha.Location = new System.Drawing.Point(235, 80);
            this.txtCdtSenha.Name = "txtCdtSenha";
            this.txtCdtSenha.PasswordChar = '*';
            this.txtCdtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtCdtSenha.TabIndex = 21;
            // 
            // lblCdtSenha
            // 
            this.lblCdtSenha.AutoSize = true;
            this.lblCdtSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtSenha.ForeColor = System.Drawing.Color.White;
            this.lblCdtSenha.Location = new System.Drawing.Point(232, 60);
            this.lblCdtSenha.Name = "lblCdtSenha";
            this.lblCdtSenha.Size = new System.Drawing.Size(49, 17);
            this.lblCdtSenha.TabIndex = 22;
            this.lblCdtSenha.Text = "Senha";
            // 
            // lblCdtFuncao
            // 
            this.lblCdtFuncao.AutoSize = true;
            this.lblCdtFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtFuncao.ForeColor = System.Drawing.Color.White;
            this.lblCdtFuncao.Location = new System.Drawing.Point(13, 125);
            this.lblCdtFuncao.Name = "lblCdtFuncao";
            this.lblCdtFuncao.Size = new System.Drawing.Size(55, 17);
            this.lblCdtFuncao.TabIndex = 20;
            this.lblCdtFuncao.Text = "Função";
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCadastroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.lblCadastroUsuario.Location = new System.Drawing.Point(8, 14);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(274, 31);
            this.lblCadastroUsuario.TabIndex = 1;
            this.lblCadastroUsuario.Text = "Cadastrar funcionário";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.AutoSize = true;
            this.btnCadastrarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.Image")));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(817, 125);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(150, 40);
            this.btnCadastrarFuncionario.TabIndex = 18;
            this.btnCadastrarFuncionario.Text = "Adicionar funcionário";
            this.btnCadastrarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // lblCdtDataContratacao
            // 
            this.lblCdtDataContratacao.AutoSize = true;
            this.lblCdtDataContratacao.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtDataContratacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtDataContratacao.ForeColor = System.Drawing.Color.White;
            this.lblCdtDataContratacao.Location = new System.Drawing.Point(262, 124);
            this.lblCdtDataContratacao.Name = "lblCdtDataContratacao";
            this.lblCdtDataContratacao.Size = new System.Drawing.Size(117, 17);
            this.lblCdtDataContratacao.TabIndex = 16;
            this.lblCdtDataContratacao.Text = "Data contratação";
            // 
            // mskCdtDataContratacao
            // 
            this.mskCdtDataContratacao.Location = new System.Drawing.Point(265, 144);
            this.mskCdtDataContratacao.Mask = "00/00/0000";
            this.mskCdtDataContratacao.Name = "mskCdtDataContratacao";
            this.mskCdtDataContratacao.Size = new System.Drawing.Size(143, 20);
            this.mskCdtDataContratacao.TabIndex = 17;
            // 
            // txtCdtId
            // 
            this.txtCdtId.Enabled = false;
            this.txtCdtId.Location = new System.Drawing.Point(17, 80);
            this.txtCdtId.Name = "txtCdtId";
            this.txtCdtId.Size = new System.Drawing.Size(45, 20);
            this.txtCdtId.TabIndex = 2;
            // 
            // lblCdtId
            // 
            this.lblCdtId.AutoSize = true;
            this.lblCdtId.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtId.ForeColor = System.Drawing.Color.White;
            this.lblCdtId.Location = new System.Drawing.Point(14, 60);
            this.lblCdtId.Name = "lblCdtId";
            this.lblCdtId.Size = new System.Drawing.Size(21, 17);
            this.lblCdtId.TabIndex = 3;
            this.lblCdtId.Text = "ID";
            // 
            // lblCdtFone
            // 
            this.lblCdtFone.AutoSize = true;
            this.lblCdtFone.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtFone.ForeColor = System.Drawing.Color.White;
            this.lblCdtFone.Location = new System.Drawing.Point(440, 124);
            this.lblCdtFone.Name = "lblCdtFone";
            this.lblCdtFone.Size = new System.Drawing.Size(40, 17);
            this.lblCdtFone.TabIndex = 15;
            this.lblCdtFone.Text = "Fone";
            // 
            // txtCdtNome
            // 
            this.txtCdtNome.Location = new System.Drawing.Point(68, 80);
            this.txtCdtNome.Name = "txtCdtNome";
            this.txtCdtNome.Size = new System.Drawing.Size(161, 20);
            this.txtCdtNome.TabIndex = 4;
            // 
            // mskCdtFone
            // 
            this.mskCdtFone.Location = new System.Drawing.Point(440, 144);
            this.mskCdtFone.Mask = "(00) 00000-0000";
            this.mskCdtFone.Name = "mskCdtFone";
            this.mskCdtFone.Size = new System.Drawing.Size(132, 20);
            this.mskCdtFone.TabIndex = 14;
            // 
            // lblCdtNome
            // 
            this.lblCdtNome.AutoSize = true;
            this.lblCdtNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtNome.ForeColor = System.Drawing.Color.White;
            this.lblCdtNome.Location = new System.Drawing.Point(63, 60);
            this.lblCdtNome.Name = "lblCdtNome";
            this.lblCdtNome.Size = new System.Drawing.Size(45, 17);
            this.lblCdtNome.TabIndex = 5;
            this.lblCdtNome.Text = "Nome";
            // 
            // mskCdtDataNascimento
            // 
            this.mskCdtDataNascimento.Location = new System.Drawing.Point(100, 144);
            this.mskCdtDataNascimento.Mask = "00/00/0000";
            this.mskCdtDataNascimento.Name = "mskCdtDataNascimento";
            this.mskCdtDataNascimento.Size = new System.Drawing.Size(137, 20);
            this.mskCdtDataNascimento.TabIndex = 13;
            // 
            // mskCdtCpf
            // 
            this.mskCdtCpf.Location = new System.Drawing.Point(531, 80);
            this.mskCdtCpf.Mask = "000,000,000-00";
            this.mskCdtCpf.Name = "mskCdtCpf";
            this.mskCdtCpf.Size = new System.Drawing.Size(103, 20);
            this.mskCdtCpf.TabIndex = 12;
            // 
            // lblCdtDataNascimento
            // 
            this.lblCdtDataNascimento.AutoSize = true;
            this.lblCdtDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblCdtDataNascimento.Location = new System.Drawing.Point(97, 124);
            this.lblCdtDataNascimento.Name = "lblCdtDataNascimento";
            this.lblCdtDataNascimento.Size = new System.Drawing.Size(114, 17);
            this.lblCdtDataNascimento.TabIndex = 11;
            this.lblCdtDataNascimento.Text = "Data nascimento";
            // 
            // lblCdtCpf
            // 
            this.lblCdtCpf.AutoSize = true;
            this.lblCdtCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCdtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCdtCpf.ForeColor = System.Drawing.Color.White;
            this.lblCdtCpf.Location = new System.Drawing.Point(528, 60);
            this.lblCdtCpf.Name = "lblCdtCpf";
            this.lblCdtCpf.Size = new System.Drawing.Size(34, 17);
            this.lblCdtCpf.TabIndex = 9;
            this.lblCdtCpf.Text = "CPF";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbofuncionario);
            this.panel2.Controls.Add(this.dgvListarFuncionarios);
            this.panel2.Controls.Add(this.btnBuscarFuncionario);
            this.panel2.Controls.Add(this.lblDadosFuncionario);
            this.panel2.Location = new System.Drawing.Point(12, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 313);
            this.panel2.TabIndex = 22;
            // 
            // cbofuncionario
            // 
            this.cbofuncionario.FormattingEnabled = true;
            this.cbofuncionario.Location = new System.Drawing.Point(710, 21);
            this.cbofuncionario.Name = "cbofuncionario";
            this.cbofuncionario.Size = new System.Drawing.Size(121, 21);
            this.cbofuncionario.TabIndex = 60;
            this.cbofuncionario.SelectedIndexChanged += new System.EventHandler(this.cbofuncionario_SelectedIndexChanged);
            // 
            // dgvListarFuncionarios
            // 
            this.dgvListarFuncionarios.AllowUserToAddRows = false;
            this.dgvListarFuncionarios.AllowUserToDeleteRows = false;
            this.dgvListarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colEmail,
            this.colCpf,
            this.colStatus,
            this.colFuncao,
            this.colDataNasc,
            this.colDataContratacao,
            this.colFone});
            this.dgvListarFuncionarios.Location = new System.Drawing.Point(14, 57);
            this.dgvListarFuncionarios.Name = "dgvListarFuncionarios";
            this.dgvListarFuncionarios.ReadOnly = true;
            this.dgvListarFuncionarios.Size = new System.Drawing.Size(978, 192);
            this.dgvListarFuncionarios.TabIndex = 59;
            this.dgvListarFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarFuncionarios_CellClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colFuncao
            // 
            this.colFuncao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFuncao.HeaderText = "Função";
            this.colFuncao.Name = "colFuncao";
            this.colFuncao.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataNasc.HeaderText = "Data Nascimento";
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            // 
            // colDataContratacao
            // 
            this.colDataContratacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataContratacao.HeaderText = "Data Contratação";
            this.colDataContratacao.Name = "colDataContratacao";
            this.colDataContratacao.ReadOnly = true;
            // 
            // colFone
            // 
            this.colFone.HeaderText = "Fone";
            this.colFone.Name = "colFone";
            this.colFone.ReadOnly = true;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFuncionario.Image")));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(885, 13);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(107, 38);
            this.btnBuscarFuncionario.TabIndex = 36;
            this.btnBuscarFuncionario.Text = "Pesquisar";
            this.btnBuscarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDadosFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.lblDadosFuncionario.Location = new System.Drawing.Point(8, 11);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(270, 31);
            this.lblDadosFuncionario.TabIndex = 20;
            this.lblDadosFuncionario.Text = "Dados do funcionário";
            // 
            // frmGerenciarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1026, 647);
            this.Controls.Add(this.pnlCadastroFuncionario);
            this.Controls.Add(this.panel2);
            this.Name = "frmGerenciarFuncionarios";
            this.Text = "frmGerenciarFuncionarios";
            this.Load += new System.EventHandler(this.frmGerenciarFuncionarios_Load);
            this.pnlCadastroFuncionario.ResumeLayout(false);
            this.pnlCadastroFuncionario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroFuncionario;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Label lblCdtDataContratacao;
        private System.Windows.Forms.MaskedTextBox mskCdtDataContratacao;
        private System.Windows.Forms.Label lblCdtFone;
        private System.Windows.Forms.TextBox txtCdtNome;
        private System.Windows.Forms.MaskedTextBox mskCdtFone;
        private System.Windows.Forms.Label lblCdtNome;
        private System.Windows.Forms.MaskedTextBox mskCdtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskCdtCpf;
        private System.Windows.Forms.Label lblCdtDataNascimento;
        private System.Windows.Forms.Label lblCdtCpf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.Label lblCdtFuncao;
        private System.Windows.Forms.TextBox txtCdtEmail;
        private System.Windows.Forms.Label lblCdtEmail;
        private System.Windows.Forms.TextBox txtCdtSenha;
        private System.Windows.Forms.Label lblCdtSenha;
        private System.Windows.Forms.Label lblCdtSttsFuncionario;
        private System.Windows.Forms.DataGridView dgvListarFuncionarios;
        private System.Windows.Forms.TextBox txtCdtId;
        private System.Windows.Forms.Label lblCdtId;
        private System.Windows.Forms.ComboBox cbofuncionario;
        private System.Windows.Forms.Button btnAtualizarFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataContratacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFone;
        private System.Windows.Forms.ComboBox cboCdtFuncaoFuncionario;
        private System.Windows.Forms.ComboBox cboCdtSttsFuncionario;
    }
}