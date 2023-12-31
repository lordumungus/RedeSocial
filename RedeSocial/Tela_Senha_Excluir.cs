﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RedeSocial
{
    
    public partial class Tela_Senha_Excluir : Form
    {
        

        
        public Tela_Senha_Excluir()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            InicializarBordasArredondadas();


        }

        public void InicializarBordasArredondadas()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 30;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }


        private void ConfirmarExclusao()
        {
            string prov_email;
            string prov_senha;
            prov_email = caixa_email.Text;
            prov_senha = caixa_senha.Text;
            if(prov_email == Login.email[Convert.ToInt32(Login.user)] && prov_senha == Login.senha[Convert.ToInt32(Login.user)])
            {
                MessageBox.Show("Senha Correta");
                Tela_Perfil novo = new Tela_Perfil();
                novo.ExcluirConta();
            }
            else
            {
                MessageBox.Show("Senha Incorreta ou E-mail Incorretos");
            }
        }

        private void caixa_text_Click(object sender, EventArgs e)
        {
            ConfirmarExclusao();
        }

        private void Tela_Senha_Excluir_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
