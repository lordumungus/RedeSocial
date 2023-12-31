﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace RedeSocial
{
    public partial class Tela_Comunidade : Form
    {

        public Tela_Comunidade()
        {

            InitializeComponent();            
            MostrarIntegrantes();

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

        public void MostrarIntegrantes()
        {
            Label_Nome_Comunidade.Text = Comunidade.nome_comunidades[Tela_Principal.comunidades_Tela];
            Label_Descricao.Text = Comunidade.descricao_comunidades[Tela_Principal.comunidades_Tela];
            Foto_Comunidade.SizeMode = PictureBoxSizeMode.Zoom;
            Foto_Comunidade.ImageLocation = Comunidade.foto_comunidades[Tela_Principal.comunidades_Tela];
            for (int i = 0; i < 50; i++)
            {
                if (Comunidade.adim_comunidade[Tela_Principal.comunidades_Tela] == Login.nomes[i])
                {
                    user0.ImageLocation = Login.foto_perfil[i];

                }
            }
            int[] prov_nomes_comu = new int[50];
            for (int i = 0; i < 50; i++)
            {
                if (Comunidade.nome_comunidades_geral[i] == Convert.ToString(Tela_Principal.comunidades_Tela))
                {
                    for(int j = 0; j < 50; j++)
                    {
                        if(Comunidade.integrantes_comunidade[i] == Login.nomes[j])
                        prov_nomes_comu[i] = j;
                    }
                    
                }
            }


            if (prov_nomes_comu[1] == 0)
            {
                user1.Hide();
            }
            else{
                user1.ImageLocation = Login.foto_perfil[prov_nomes_comu[1]];
            }
            if (prov_nomes_comu[2] == 0)
            {
                user2.Hide();
            }
            else
            {
                user2.ImageLocation = Login.foto_perfil[prov_nomes_comu[2]];
            }
            if (prov_nomes_comu[3] == 0)
            {
                user3.Hide();
            }
            else
            {
                user3.ImageLocation = Login.foto_perfil[prov_nomes_comu[3]];
            }
            if (prov_nomes_comu[4] == 0)
            {
                user4.Hide();
            }
            else
            {
                user4.ImageLocation = Login.foto_perfil[prov_nomes_comu[4]];
            }
        }
       
        private void Tela_Comunidade_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Foto_Comunidade_Click(object sender, EventArgs e)
        {

        }

        private void bt_convite_comunidade_Click(object sender, EventArgs e)
        {
            ConviteComunidades();            
            
            
        }
        //Convite para entrar na Comunidade
        public bool prov = false;
        public void ConviteComunidades()
        {
            
            
               
                    for (int i = Login.cont_cad; i < Login.contador_de_Pessoas; i++)
                    {
                        for (int j = 0; j < Login.contador_de_Pessoas; j++)
                        {
                            if (Comunidade.adim_comunidade[j] == Login.nomes[Convert.ToInt32(Login.user)] || Comunidade.nome_comunidades_geral[j] == Convert.ToString(Tela_Principal.comunidades_Tela)
                                && Comunidade.integrantes_comunidade[j] == Login.nomes[Convert.ToInt32(Login.user)])
                            {
                                prov = true;
                            }
                        }
                        if (prov == false)
                        {

                            Comunidade.nome_comunidades_geral[Login.contador_de_Pessoas] = Convert.ToString(Tela_Principal.comunidades_Tela);
                            Comunidade.integrantes_comunidade[Login.contador_de_Pessoas] = Login.nomes[Convert.ToInt32(Login.user)];
                            Login.ondeEqualComunidade[Login.contador_de_Pessoas] = Login.contador_de_Pessoas;
                            this.Close();
                            Tela_Comunidade novo = new Tela_Comunidade();
                            novo.Show();


                            MessageBox.Show("Cadastro Feito");

                        }
                        else
                        {
                            MessageBox.Show("Já é Cadastrado");
                        }


                    }
                Login.contador_de_Pessoas++;
                Login.cont_cad++;
            

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
