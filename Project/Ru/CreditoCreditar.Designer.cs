﻿namespace Ru
{
    partial class fCreditoCreditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreditoCreditar));
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.lblFormCadastro = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.pctbFoto = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.gpbBolsista = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtValorASerCreditado = new System.Windows.Forms.TextBox();
            this.lblValorASerCreditado = new System.Windows.Forms.Label();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).BeginInit();
            this.gpbBolsista.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPeriodo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodo.Enabled = false;
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º",
            "5º",
            "6º",
            "7º",
            "8º",
            "9º",
            "10º",
            "11º",
            "12º",
            "Pós-Graduação",
            "Mestrado",
            "Doutorado",
            "Pós-Doutorado"});
            this.cbxPeriodo.Location = new System.Drawing.Point(385, 413);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(120, 24);
            this.cbxPeriodo.TabIndex = 6;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
            // 
            // mtxtFone
            // 
            this.mtxtFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFone.Location = new System.Drawing.Point(385, 452);
            this.mtxtFone.Mask = "(00)0000-0000";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.ReadOnly = true;
            this.mtxtFone.Size = new System.Drawing.Size(100, 22);
            this.mtxtFone.TabIndex = 13;
            // 
            // lblFormCadastro
            // 
            this.lblFormCadastro.AutoSize = true;
            this.lblFormCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCadastro.Location = new System.Drawing.Point(631, 98);
            this.lblFormCadastro.Name = "lblFormCadastro";
            this.lblFormCadastro.Size = new System.Drawing.Size(107, 24);
            this.lblFormCadastro.TabIndex = 0;
            this.lblFormCadastro.Text = "Creditador";
            // 
            // cbxCurso
            // 
            this.cbxCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCurso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurso.Enabled = false;
            this.cbxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Administração",
            "Administração UAST",
            "Agronomia",
            "Agronomia UAG",
            "Agronomia UAST",
            "Bacharelado em Ciência da Computação",
            "Bacharelado em Ciência da Computação UAG",
            "Bacharelado em Ciências Biológicas",
            "Bacharelado em Ciências Biológicas UAST",
            "Bacharelado em Ciências Econômicas",
            "Bacharelado em Ciências Econômicas UAST",
            "Bacharelado em Ciências Sociais",
            "Bacharelado em Gastronomia e Segurança Alimentar",
            "Bacharelado em Sistemas de Informação",
            "Bacharelado em Sistemas de Informação UAST",
            "Economia Doméstica",
            "Engenharia Agrícola e Ambiental",
            "Engenharia de Alimentos UAG",
            "Engenharia de Pesca",
            "Engenharia de Pesca UAST",
            "Engenharia Florestal",
            "Licenciatura em Ciências Agrícolas",
            "Licenciatura em Computação",
            "Licenciatura em Educação Física",
            "Licenciatura em Física",
            "Licenciatura em História",
            "Licenciatura em Letras (Português e Espanhol)",
            "Licenciatura em Letras Português/Inglês UAG",
            "Licenciatura em Letras UAST",
            "Licenciatura em Matemática",
            "Licenciatura em Pedagogia",
            "Licenciatura em Pedagogia UAG",
            "Licenciatura em Química",
            "Licenciatura em Química UAST",
            "Licenciatura Plena em Ciências Biológicas",
            "Medicina Veterinária",
            "Medicina Veterinária UAG",
            "Zootecnia",
            "Zootecnia UAG",
            "Zootecnia UAST"});
            this.cbxCurso.Location = new System.Drawing.Point(385, 377);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(353, 24);
            this.cbxCurso.TabIndex = 5;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(385, 338);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(448, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(385, 298);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblFoto
            // 
            this.lblFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.Black;
            this.lblFoto.Location = new System.Drawing.Point(77, 343);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(90, 22);
            this.lblFoto.TabIndex = 14;
            this.lblFoto.Text = "Foto";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(295, 300);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblFone
            // 
            this.lblFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFone.BackColor = System.Drawing.Color.Transparent;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.ForeColor = System.Drawing.Color.Black;
            this.lblFone.Location = new System.Drawing.Point(295, 453);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(90, 22);
            this.lblFone.TabIndex = 13;
            this.lblFone.Text = "Fone:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodo.Location = new System.Drawing.Point(295, 416);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(90, 22);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Período:";
            this.lblPeriodo.Click += new System.EventHandler(this.lblPeriodo_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(295, 378);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(90, 22);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Click += new System.EventHandler(this.lblCurso_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(295, 340);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastro,
            this.msMenuImprimir});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMenu.Size = new System.Drawing.Size(1370, 24);
            this.msMenu.TabIndex = 61;
            this.msMenu.Text = "Menu";
            // 
            // msMenuCadastro
            // 
            this.msMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastroVisualizar,
            this.msMenuCadastroAlterar,
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(58, 20);
            this.msMenuCadastro.Text = "&Crédito";
            // 
            // msMenuCadastroVisualizar
            // 
            this.msMenuCadastroVisualizar.Name = "msMenuCadastroVisualizar";
            this.msMenuCadastroVisualizar.Size = new System.Drawing.Size(190, 22);
            this.msMenuCadastroVisualizar.Text = "&Visualizar Outro Saldo";
            this.msMenuCadastroVisualizar.Click += new System.EventHandler(this.msMenuCadastroVisualizar_Click);
            // 
            // msMenuCadastroAlterar
            // 
            this.msMenuCadastroAlterar.Name = "msMenuCadastroAlterar";
            this.msMenuCadastroAlterar.Size = new System.Drawing.Size(213, 22);
            this.msMenuCadastroAlterar.Text = "&Creditar em Outro Usuário";
            this.msMenuCadastroAlterar.Click += new System.EventHandler(this.msMenuCadastroAlterar_Click);
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(190, 22);
            this.msMenuCadastroSair.Text = "&Fechar";
            this.msMenuCadastroSair.Click += new System.EventHandler(this.msMenuCadastroSair_Click);
            // 
            // msMenuImprimir
            // 
            this.msMenuImprimir.Name = "msMenuImprimir";
            this.msMenuImprimir.Size = new System.Drawing.Size(65, 20);
            this.msMenuImprimir.Text = "&Imprimir";
            // 
            // pctbRU
            // 
            this.pctbRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbRU.BackColor = System.Drawing.Color.Transparent;
            this.pctbRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbRU.BackgroundImage")));
            this.pctbRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbRU.Location = new System.Drawing.Point(1168, 27);
            this.pctbRU.Name = "pctbRU";
            this.pctbRU.Size = new System.Drawing.Size(180, 194);
            this.pctbRU.TabIndex = 62;
            this.pctbRU.TabStop = false;
            // 
            // pctbFoto
            // 
            this.pctbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbFoto.BackgroundImage")));
            this.pctbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctbFoto.Location = new System.Drawing.Point(66, 195);
            this.pctbFoto.Name = "pctbFoto";
            this.pctbFoto.Size = new System.Drawing.Size(118, 150);
            this.pctbFoto.TabIndex = 63;
            this.pctbFoto.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(1157, 729);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 64;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // gpbBolsista
            // 
            this.gpbBolsista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbBolsista.BackColor = System.Drawing.Color.Transparent;
            this.gpbBolsista.Controls.Add(this.rbtnNao);
            this.gpbBolsista.Controls.Add(this.rbtnSim);
            this.gpbBolsista.Enabled = false;
            this.gpbBolsista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBolsista.Location = new System.Drawing.Point(66, 395);
            this.gpbBolsista.Name = "gpbBolsista";
            this.gpbBolsista.Size = new System.Drawing.Size(115, 88);
            this.gpbBolsista.TabIndex = 65;
            this.gpbBolsista.TabStop = false;
            this.gpbBolsista.Text = "Gratuidade";
            // 
            // rbtnNao
            // 
            this.rbtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(3, 54);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(51, 19);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(3, 29);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(50, 19);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(385, 491);
            this.txtSaldo.MaxLength = 3;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(120, 22);
            this.txtSaldo.TabIndex = 67;
            this.txtSaldo.FontChanged += new System.EventHandler(this.txtSaldo_FontChanged);
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(295, 493);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(90, 22);
            this.lblSaldo.TabIndex = 66;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtValorASerCreditado
            // 
            this.txtValorASerCreditado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorASerCreditado.BackColor = System.Drawing.Color.White;
            this.txtValorASerCreditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorASerCreditado.Location = new System.Drawing.Point(648, 184);
            this.txtValorASerCreditado.MaxLength = 3;
            this.txtValorASerCreditado.Name = "txtValorASerCreditado";
            this.txtValorASerCreditado.Size = new System.Drawing.Size(120, 22);
            this.txtValorASerCreditado.TabIndex = 69;
            // 
            // lblValorASerCreditado
            // 
            this.lblValorASerCreditado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorASerCreditado.BackColor = System.Drawing.Color.Transparent;
            this.lblValorASerCreditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorASerCreditado.ForeColor = System.Drawing.Color.Black;
            this.lblValorASerCreditado.Location = new System.Drawing.Point(478, 186);
            this.lblValorASerCreditado.Name = "lblValorASerCreditado";
            this.lblValorASerCreditado.Size = new System.Drawing.Size(164, 22);
            this.lblValorASerCreditado.TabIndex = 68;
            this.lblValorASerCreditado.Text = "Valor a ser creditado:";
            // 
            // btnCreditar
            // 
            this.btnCreditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreditar.Location = new System.Drawing.Point(813, 183);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(75, 23);
            this.btnCreditar.TabIndex = 70;
            this.btnCreditar.Text = "&Creditar";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
            // 
            // fCreditoCreditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.btnCreditar);
            this.Controls.Add(this.txtValorASerCreditado);
            this.Controls.Add(this.lblValorASerCreditado);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.gpbBolsista);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pctbFoto);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.lblFormCadastro);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCreditoCreditar";
            this.Text = "Operador de Crédito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCadastro_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).EndInit();
            this.gpbBolsista.ResumeLayout(false);
            this.gpbBolsista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.Label lblFormCadastro;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroAlterar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroVisualizar;
        private System.Windows.Forms.ToolStripMenuItem msMenuImprimir;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.PictureBox pctbRU;
        private System.Windows.Forms.PictureBox pctbFoto;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox gpbBolsista;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtValorASerCreditado;
        private System.Windows.Forms.Label lblValorASerCreditado;
        private System.Windows.Forms.Button btnCreditar;
    }
}