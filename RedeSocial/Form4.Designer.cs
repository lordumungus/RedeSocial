﻿
namespace RedeSocial
{
    partial class Tela_Cadastro
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
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.Location = new System.Drawing.Point(171, 164);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(315, 22);
            this.caixa_nome.TabIndex = 0;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.Location = new System.Drawing.Point(171, 226);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(313, 22);
            this.caixa_senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Novo Usuário";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Location = new System.Drawing.Point(247, 283);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(156, 30);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 327);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_nome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cadastrar;
    }
}