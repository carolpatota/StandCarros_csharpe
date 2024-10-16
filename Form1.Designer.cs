using System.Drawing.Printing;
using System.Windows.Forms;

namespace Agenda_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gp_box_dados = new System.Windows.Forms.GroupBox();
            this.msk_b_km = new System.Windows.Forms.MaskedTextBox();
            this.msk_b_matricula = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dados_matricula = new System.Windows.Forms.Label();
            this.lbl_dados_km = new System.Windows.Forms.Label();
            this.lbl_dados_modelo = new System.Windows.Forms.Label();
            this.lbl_dados_marca = new System.Windows.Forms.Label();
            this.txb_modelo = new System.Windows.Forms.TextBox();
            this.txb_marca = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.gp_box_listas = new System.Windows.Forms.GroupBox();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.list_km = new System.Windows.Forms.ListBox();
            this.list_matricula = new System.Windows.Forms.ListBox();
            this.list_modelo = new System.Windows.Forms.ListBox();
            this.list_marca = new System.Windows.Forms.ListBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.gp_box_dados.SuspendLayout();
            this.gp_box_listas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_box_dados
            // 
            this.gp_box_dados.Controls.Add(this.msk_b_km);
            this.gp_box_dados.Controls.Add(this.msk_b_matricula);
            this.gp_box_dados.Controls.Add(this.lbl_dados_matricula);
            this.gp_box_dados.Controls.Add(this.lbl_dados_km);
            this.gp_box_dados.Controls.Add(this.lbl_dados_modelo);
            this.gp_box_dados.Controls.Add(this.lbl_dados_marca);
            this.gp_box_dados.Controls.Add(this.txb_modelo);
            this.gp_box_dados.Controls.Add(this.txb_marca);
            this.gp_box_dados.Controls.Add(this.btn_limpar);
            this.gp_box_dados.Controls.Add(this.btn_adicionar);
            this.gp_box_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_box_dados.ForeColor = System.Drawing.Color.Navy;
            this.gp_box_dados.Location = new System.Drawing.Point(16, 12);
            this.gp_box_dados.Name = "gp_box_dados";
            this.gp_box_dados.Size = new System.Drawing.Size(203, 426);
            this.gp_box_dados.TabIndex = 0;
            this.gp_box_dados.TabStop = false;
            this.gp_box_dados.Text = "DADOS";
            // 
            // msk_b_km
            // 
            this.msk_b_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_b_km.Location = new System.Drawing.Point(17, 299);
            this.msk_b_km.Mask = "999.990";
            this.msk_b_km.Name = "msk_b_km";
            this.msk_b_km.Size = new System.Drawing.Size(76, 22);
            this.msk_b_km.TabIndex = 15;
            this.msk_b_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msk_b_matricula
            // 
            this.msk_b_matricula.Location = new System.Drawing.Point(17, 222);
            this.msk_b_matricula.Mask = "AA-AA-AA";
            this.msk_b_matricula.Name = "msk_b_matricula";
            this.msk_b_matricula.Size = new System.Drawing.Size(76, 22);
            this.msk_b_matricula.TabIndex = 14;
            this.msk_b_matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_b_matricula.TextChanged += new System.EventHandler(this.msk_b_matricula_TextChanged);
            // 
            // lbl_dados_matricula
            // 
            this.lbl_dados_matricula.AutoSize = true;
            this.lbl_dados_matricula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dados_matricula.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_matricula.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dados_matricula.Location = new System.Drawing.Point(17, 196);
            this.lbl_dados_matricula.Name = "lbl_dados_matricula";
            this.lbl_dados_matricula.Size = new System.Drawing.Size(58, 16);
            this.lbl_dados_matricula.TabIndex = 13;
            this.lbl_dados_matricula.Text = "Matricula";
            // 
            // lbl_dados_km
            // 
            this.lbl_dados_km.AutoSize = true;
            this.lbl_dados_km.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dados_km.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_km.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dados_km.Location = new System.Drawing.Point(17, 267);
            this.lbl_dados_km.Name = "lbl_dados_km";
            this.lbl_dados_km.Size = new System.Drawing.Size(62, 16);
            this.lbl_dados_km.TabIndex = 12;
            this.lbl_dados_km.Text = "Km Atuais";
            // 
            // lbl_dados_modelo
            // 
            this.lbl_dados_modelo.AutoSize = true;
            this.lbl_dados_modelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dados_modelo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_modelo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dados_modelo.Location = new System.Drawing.Point(17, 120);
            this.lbl_dados_modelo.Name = "lbl_dados_modelo";
            this.lbl_dados_modelo.Size = new System.Drawing.Size(50, 16);
            this.lbl_dados_modelo.TabIndex = 11;
            this.lbl_dados_modelo.Text = "Modelo";
            // 
            // lbl_dados_marca
            // 
            this.lbl_dados_marca.AutoSize = true;
            this.lbl_dados_marca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dados_marca.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados_marca.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dados_marca.Location = new System.Drawing.Point(17, 47);
            this.lbl_dados_marca.Name = "lbl_dados_marca";
            this.lbl_dados_marca.Size = new System.Drawing.Size(41, 16);
            this.lbl_dados_marca.TabIndex = 8;
            this.lbl_dados_marca.Text = "Marca";
            // 
            // txb_modelo
            // 
            this.txb_modelo.Location = new System.Drawing.Point(17, 149);
            this.txb_modelo.Name = "txb_modelo";
            this.txb_modelo.Size = new System.Drawing.Size(147, 22);
            this.txb_modelo.TabIndex = 9;
            this.txb_modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_marca
            // 
            this.txb_marca.Location = new System.Drawing.Point(17, 73);
            this.txb_marca.Name = "txb_marca";
            this.txb_marca.Size = new System.Drawing.Size(147, 22);
            this.txb_marca.TabIndex = 8;
            this.txb_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Olive;
            this.btn_limpar.Location = new System.Drawing.Point(42, 385);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(104, 28);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.Olive;
            this.btn_adicionar.Location = new System.Drawing.Point(42, 345);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(104, 28);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // gp_box_listas
            // 
            this.gp_box_listas.Controls.Add(this.lbl_km);
            this.gp_box_listas.Controls.Add(this.lbl_matricula);
            this.gp_box_listas.Controls.Add(this.lbl_modelo);
            this.gp_box_listas.Controls.Add(this.lbl_marca);
            this.gp_box_listas.Controls.Add(this.list_km);
            this.gp_box_listas.Controls.Add(this.list_matricula);
            this.gp_box_listas.Controls.Add(this.list_modelo);
            this.gp_box_listas.Controls.Add(this.list_marca);
            this.gp_box_listas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_box_listas.ForeColor = System.Drawing.Color.Navy;
            this.gp_box_listas.Location = new System.Drawing.Point(245, 12);
            this.gp_box_listas.Name = "gp_box_listas";
            this.gp_box_listas.Size = new System.Drawing.Size(543, 373);
            this.gp_box_listas.TabIndex = 1;
            this.gp_box_listas.TabStop = false;
            this.gp_box_listas.Text = "LISTAS";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_km.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_km.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_km.Location = new System.Drawing.Point(429, 29);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(69, 16);
            this.lbl_km.TabIndex = 7;
            this.lbl_km.Text = "KM ATUAIS";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_matricula.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_matricula.Location = new System.Drawing.Point(301, 29);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(73, 16);
            this.lbl_matricula.TabIndex = 6;
            this.lbl_matricula.Text = "MATRICULA";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_modelo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_modelo.Location = new System.Drawing.Point(179, 29);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(56, 16);
            this.lbl_modelo.TabIndex = 5;
            this.lbl_modelo.Text = "MODELO";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_marca.Location = new System.Drawing.Point(49, 29);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(50, 16);
            this.lbl_marca.TabIndex = 4;
            this.lbl_marca.Text = "MARCA";
            // 
            // list_km
            // 
            this.list_km.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_km.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_km.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.list_km.FormattingEnabled = true;
            this.list_km.ItemHeight = 18;
            this.list_km.Location = new System.Drawing.Point(406, 60);
            this.list_km.Name = "list_km";
            this.list_km.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_km.Size = new System.Drawing.Size(120, 292);
            this.list_km.TabIndex = 3;
            this.list_km.SelectedIndexChanged += new System.EventHandler(this.list_km_SelectedIndexChanged);
            // 
            // list_matricula
            // 
            this.list_matricula.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_matricula.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_matricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.list_matricula.FormattingEnabled = true;
            this.list_matricula.ItemHeight = 18;
            this.list_matricula.Location = new System.Drawing.Point(277, 60);
            this.list_matricula.Name = "list_matricula";
            this.list_matricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_matricula.Size = new System.Drawing.Size(120, 292);
            this.list_matricula.TabIndex = 2;
            this.list_matricula.SelectedIndexChanged += new System.EventHandler(this.list_matricula_SelectedIndexChanged);
            // 
            // list_modelo
            // 
            this.list_modelo.BackColor = System.Drawing.SystemColors.Menu;
            this.list_modelo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.list_modelo.FormattingEnabled = true;
            this.list_modelo.ItemHeight = 18;
            this.list_modelo.Location = new System.Drawing.Point(148, 60);
            this.list_modelo.Name = "list_modelo";
            this.list_modelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_modelo.Size = new System.Drawing.Size(120, 292);
            this.list_modelo.TabIndex = 1;
            this.list_modelo.SelectedIndexChanged += new System.EventHandler(this.list_modelo_SelectedIndexChanged);
            // 
            // list_marca
            // 
            this.list_marca.BackColor = System.Drawing.SystemColors.Menu;
            this.list_marca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.list_marca.FormattingEnabled = true;
            this.list_marca.ItemHeight = 18;
            this.list_marca.Location = new System.Drawing.Point(16, 59);
            this.list_marca.Name = "list_marca";
            this.list_marca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_marca.Size = new System.Drawing.Size(121, 292);
            this.list_marca.TabIndex = 2;
            this.list_marca.SelectedIndexChanged += new System.EventHandler(this.list_marca_SelectedIndexChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Navy;
            this.btn_imprimir.Location = new System.Drawing.Point(245, 402);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(72, 23);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.Navy;
            this.btn_alterar.Location = new System.Drawing.Point(335, 402);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(72, 23);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Navy;
            this.btn_eliminar.Location = new System.Drawing.Point(424, 402);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(72, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Navy;
            this.btn_sair.Location = new System.Drawing.Point(699, 402);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(72, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_importar
            // 
            this.btn_importar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar.ForeColor = System.Drawing.Color.Navy;
            this.btn_importar.Location = new System.Drawing.Point(517, 402);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(72, 23);
            this.btn_importar.TabIndex = 6;
            this.btn_importar.Text = "Importar";
            this.btn_importar.UseVisualStyleBackColor = false;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.Navy;
            this.btn_exportar.Location = new System.Drawing.Point(608, 402);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(72, 23);
            this.btn_exportar.TabIndex = 7;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.gp_box_listas);
            this.Controls.Add(this.gp_box_dados);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Stand AGUIAR, Ltda";
            this.gp_box_dados.ResumeLayout(false);
            this.gp_box_dados.PerformLayout();
            this.gp_box_listas.ResumeLayout(false);
            this.gp_box_listas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_box_dados;
        private System.Windows.Forms.GroupBox gp_box_listas;
        private System.Windows.Forms.ListBox list_marca;
        private System.Windows.Forms.ListBox list_km;
        private System.Windows.Forms.ListBox list_matricula;
        private System.Windows.Forms.ListBox list_modelo;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_sair;
        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.MaskedTextBox msk_b_matricula;
        private System.Windows.Forms.Label lbl_dados_matricula;
        private System.Windows.Forms.Label lbl_dados_km;
        private System.Windows.Forms.Label lbl_dados_modelo;
        private System.Windows.Forms.Label lbl_dados_marca;
        private System.Windows.Forms.TextBox txb_modelo;
        private System.Windows.Forms.TextBox txb_marca;
        private System.Windows.Forms.MaskedTextBox msk_b_km;
        private Button btn_importar;
        private Button btn_exportar;
    }
}

