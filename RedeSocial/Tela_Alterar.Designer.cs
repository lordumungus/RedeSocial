﻿
namespace RedeSocial
{
    partial class Tela_Alterar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Nome_Alterar = new System.Windows.Forms.TextBox();
            this.textBox_data_alterar = new System.Windows.Forms.TextBox();
            this.textBox_Email_alterar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_senha_alterar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_confirmar_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Nome_Alterar
            // 
            this.textBox_Nome_Alterar.Location = new System.Drawing.Point(114, 34);
            this.textBox_Nome_Alterar.Name = "textBox_Nome_Alterar";
            this.textBox_Nome_Alterar.Size = new System.Drawing.Size(179, 20);
            this.textBox_Nome_Alterar.TabIndex = 2;
            // 
            // textBox_data_alterar
            // 
            this.textBox_data_alterar.Location = new System.Drawing.Point(158, 118);
            this.textBox_data_alterar.Name = "textBox_data_alterar";
            this.textBox_data_alterar.Size = new System.Drawing.Size(135, 20);
            this.textBox_data_alterar.TabIndex = 3;
            // 
            // textBox_Email_alterar
            // 
            this.textBox_Email_alterar.Location = new System.Drawing.Point(114, 76);
            this.textBox_Email_alterar.Name = "textBox_Email_alterar";
            this.textBox_Email_alterar.Size = new System.Drawing.Size(179, 20);
            this.textBox_Email_alterar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // textBox_senha_alterar
            // 
            this.textBox_senha_alterar.Location = new System.Drawing.Point(114, 152);
            this.textBox_senha_alterar.Name = "textBox_senha_alterar";
            this.textBox_senha_alterar.Size = new System.Drawing.Size(179, 20);
            this.textBox_senha_alterar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Senha";
            // 
            // textBox_confirmar_senha
            // 
            this.textBox_confirmar_senha.Location = new System.Drawing.Point(114, 187);
            this.textBox_confirmar_senha.Name = "textBox_confirmar_senha";
            this.textBox_confirmar_senha.Size = new System.Drawing.Size(179, 20);
            this.textBox_confirmar_senha.TabIndex = 11;
            // 
            // Tela_Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 301);
            this.Controls.Add(this.textBox_confirmar_senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_senha_alterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Email_alterar);
            this.Controls.Add(this.textBox_data_alterar);
            this.Controls.Add(this.textBox_Nome_Alterar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tela_Alterar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tela Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Nome_Alterar;
        private System.Windows.Forms.TextBox textBox_data_alterar;
        private System.Windows.Forms.TextBox textBox_Email_alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_senha_alterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_confirmar_senha;
    }
}