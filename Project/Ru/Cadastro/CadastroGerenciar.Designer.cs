﻿namespace Ru
{
    partial class fCadastroGerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadastroGerenciar));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pctbBoasVindas = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBoasVindas)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastro,
            this.statusToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            this.msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMenu_ItemClicked);
            // 
            // msMenuCadastro
            // 
            this.msMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastroNovo,
            this.msMenuCadastroVisualizar,
            this.msMenuCadastroAlterar,
            this.msMenuCadastroExcluir,
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.msMenuCadastro.Text = "&Cadastro";
            // 
            // msMenuCadastroNovo
            // 
            this.msMenuCadastroNovo.Name = "msMenuCadastroNovo";
            this.msMenuCadastroNovo.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroNovo.Text = "&Novo";
            this.msMenuCadastroNovo.Click += new System.EventHandler(this.msMenuCadastroNovo_Click);
            // 
            // msMenuCadastroVisualizar
            // 
            this.msMenuCadastroVisualizar.Name = "msMenuCadastroVisualizar";
            this.msMenuCadastroVisualizar.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroVisualizar.Text = "&Visualizar";
            this.msMenuCadastroVisualizar.Click += new System.EventHandler(this.msMenuCadastroVisualizar_Click);
            // 
            // msMenuCadastroAlterar
            // 
            this.msMenuCadastroAlterar.Name = "msMenuCadastroAlterar";
            this.msMenuCadastroAlterar.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroAlterar.Text = "&Alterar";
            this.msMenuCadastroAlterar.Click += new System.EventHandler(this.msMenuCadastroAlterar_Click);
            // 
            // msMenuCadastroExcluir
            // 
            this.msMenuCadastroExcluir.Name = "msMenuCadastroExcluir";
            this.msMenuCadastroExcluir.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroExcluir.Text = "&Excluir";
            this.msMenuCadastroExcluir.Click += new System.EventHandler(this.msMenuCadastroExcluir_Click);
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroSair.Text = "&Encerrar Sessão";
            this.msMenuCadastroSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloquearTodosToolStripMenuItem,
            this.desbloquearTodosToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "&Status";
            // 
            // bloquearTodosToolStripMenuItem
            // 
            this.bloquearTodosToolStripMenuItem.Name = "bloquearTodosToolStripMenuItem";
            this.bloquearTodosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bloquearTodosToolStripMenuItem.Text = "&Bloquear Todos";
            this.bloquearTodosToolStripMenuItem.Click += new System.EventHandler(this.bloquearTodosToolStripMenuItem_Click);
            // 
            // desbloquearTodosToolStripMenuItem
            // 
            this.desbloquearTodosToolStripMenuItem.Name = "desbloquearTodosToolStripMenuItem";
            this.desbloquearTodosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.desbloquearTodosToolStripMenuItem.Text = "&Desbloquear Todos";
            this.desbloquearTodosToolStripMenuItem.Click += new System.EventHandler(this.desbloquearTodosToolStripMenuItem_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBemVindo.Location = new System.Drawing.Point(74, 24);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(606, 27);
            this.lblBemVindo.TabIndex = 4;
            this.lblBemVindo.Text = "Olá Operador de Cadastro! Bem vindo ao sistema RU!";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(587, 579);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 18;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // pctbBoasVindas
            // 
            this.pctbBoasVindas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.pctbBoasVindas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbBoasVindas.BackgroundImage")));
            this.pctbBoasVindas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbBoasVindas.Location = new System.Drawing.Point(132, 104);
            this.pctbBoasVindas.Name = "pctbBoasVindas";
            this.pctbBoasVindas.Size = new System.Drawing.Size(465, 375);
            this.pctbBoasVindas.TabIndex = 64;
            this.pctbBoasVindas.TabStop = false;
            // 
            // fCadastroGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pctbBoasVindas);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.msMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMenu;
            this.Name = "fCadastroGerenciar";
            this.Text = "Gerenciador de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCadastroGerenciar_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBoasVindas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroNovo;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroAlterar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroVisualizar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroExcluir;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pctbBoasVindas;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearTodosToolStripMenuItem;





    }
}