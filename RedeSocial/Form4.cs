﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Tela_Cadastro : Form
    {
       
        

        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            for (Login.i = Login.j; Login.i < Login.n; Login.i++)
            {
                Login.nomes [Login.i] = caixa_nome.Text;
                Login.senha [Login.i] = caixa_senha.Text;
            }
            Login.j++;
            Login.n++;
            if (caixa_nome.Text.Equals(""))
            {
                Tela_Erro novo = new Tela_Erro();
                novo.Show();
                
            }else
            {
                Aviso_Cadastro novo = new Aviso_Cadastro();
                novo.Show();
            }
        }
    }
}