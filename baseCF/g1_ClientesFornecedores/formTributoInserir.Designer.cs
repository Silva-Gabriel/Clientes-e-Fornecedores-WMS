﻿
namespace baseCF
{
    partial class formTributoInserir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTributoInserir));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtIdTributo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.tabIdentTributo = new System.Windows.Forms.TabControl();
            this.tabIdentTributo1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.flagEditar = new System.Windows.Forms.CheckBox();
            this.cboTipoTributo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtAliquota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabIdentTributo.SuspendLayout();
            this.tabIdentTributo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1239, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1220, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.optionToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem1,
            this.permissõesToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.optionToolStripMenuItem1.Text = "Ver matrícula";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem2});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionToolStripMenuItem2
            // 
            this.optionToolStripMenuItem2.Name = "optionToolStripMenuItem2";
            this.optionToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.optionToolStripMenuItem2.Text = "Suporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1079, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário: 00000000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(436, 56);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(140, 21);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "19/05/2021, 00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1086, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FAWS WMS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Location = new System.Drawing.Point(9, 564);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1220, 59);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // txtIdTributo
            // 
            this.txtIdTributo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtIdTributo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTributo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtIdTributo.Location = new System.Drawing.Point(10, 26);
            this.txtIdTributo.Name = "txtIdTributo";
            this.txtIdTributo.ReadOnly = true;
            this.txtIdTributo.Size = new System.Drawing.Size(86, 43);
            this.txtIdTributo.TabIndex = 3;
            this.txtIdTributo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(9, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 38);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "        Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(987, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 152);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDesfazer.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfazer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesfazer.Image = ((System.Drawing.Image)(resources.GetObject("btnDesfazer.Image")));
            this.btnDesfazer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesfazer.Location = new System.Drawing.Point(879, 575);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(88, 38);
            this.btnDesfazer.TabIndex = 21;
            this.btnDesfazer.Text = "        Fechar";
            this.btnDesfazer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesfazer.UseVisualStyleBackColor = false;
            this.btnDesfazer.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabIdentTributo
            // 
            this.tabIdentTributo.Controls.Add(this.tabIdentTributo1);
            this.tabIdentTributo.Location = new System.Drawing.Point(9, 150);
            this.tabIdentTributo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabIdentTributo.Name = "tabIdentTributo";
            this.tabIdentTributo.SelectedIndex = 0;
            this.tabIdentTributo.Size = new System.Drawing.Size(962, 373);
            this.tabIdentTributo.TabIndex = 28;
            // 
            // tabIdentTributo1
            // 
            this.tabIdentTributo1.Controls.Add(this.label2);
            this.tabIdentTributo1.Controls.Add(this.chkVigente);
            this.tabIdentTributo1.Controls.Add(this.flagEditar);
            this.tabIdentTributo1.Controls.Add(this.cboTipoTributo);
            this.tabIdentTributo1.Controls.Add(this.label8);
            this.tabIdentTributo1.Controls.Add(this.cboCidade);
            this.tabIdentTributo1.Controls.Add(this.txtAliquota);
            this.tabIdentTributo1.Controls.Add(this.label11);
            this.tabIdentTributo1.Controls.Add(this.label7);
            this.tabIdentTributo1.Controls.Add(this.label6);
            this.tabIdentTributo1.Controls.Add(this.txtIdTributo);
            this.tabIdentTributo1.Location = new System.Drawing.Point(4, 22);
            this.tabIdentTributo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabIdentTributo1.Name = "tabIdentTributo1";
            this.tabIdentTributo1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabIdentTributo1.Size = new System.Drawing.Size(954, 347);
            this.tabIdentTributo1.TabIndex = 0;
            this.tabIdentTributo1.Text = "Identificação do Tributo";
            this.tabIdentTributo1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vigente";
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(646, 110);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(15, 14);
            this.chkVigente.TabIndex = 38;
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // flagEditar
            // 
            this.flagEditar.AutoSize = true;
            this.flagEditar.Location = new System.Drawing.Point(323, 26);
            this.flagEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flagEditar.Name = "flagEditar";
            this.flagEditar.Size = new System.Drawing.Size(142, 17);
            this.flagEditar.TabIndex = 37;
            this.flagEditar.Text = "FlagControleEditarSalvar";
            this.flagEditar.UseVisualStyleBackColor = true;
            this.flagEditar.Visible = false;
            // 
            // cboTipoTributo
            // 
            this.cboTipoTributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTributo.FormattingEnabled = true;
            this.cboTipoTributo.Location = new System.Drawing.Point(205, 107);
            this.cboTipoTributo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoTributo.Name = "cboTipoTributo";
            this.cboTipoTributo.Size = new System.Drawing.Size(179, 21);
            this.cboTipoTributo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tipo de Tributo";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(12, 107);
            this.cboCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(179, 21);
            this.cboCidade.TabIndex = 34;
            // 
            // txtAliquota
            // 
            this.txtAliquota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquota.Location = new System.Drawing.Point(401, 107);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(217, 23);
            this.txtAliquota.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Alíquota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cidade";
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Enabled = true;
            this.tmrDataHora.Interval = 1;
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(426, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "FATEC Warehouse System";
            // 
            // formTributoInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1220, 624);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabIdentTributo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimumSize = new System.Drawing.Size(1022, 630);
            this.Name = "formTributoInserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAWS WMS - Cadastro de Tributo";
            this.Load += new System.EventHandler(this.formTributoInserir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabIdentTributo.ResumeLayout(false);
            this.tabIdentTributo1.ResumeLayout(false);
            this.tabIdentTributo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabIdentTributo;
        private System.Windows.Forms.TabPage tabIdentTributo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tmrDataHora;
        public System.Windows.Forms.ComboBox cboCidade;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtAliquota;
        public System.Windows.Forms.Button btnDesfazer;
        public System.Windows.Forms.ComboBox cboTipoTributo;
        public System.Windows.Forms.TextBox txtIdTributo;
        public System.Windows.Forms.CheckBox flagEditar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Label label3;
    }
}

