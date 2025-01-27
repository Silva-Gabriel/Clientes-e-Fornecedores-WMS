﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace baseCF
{
    public partial class formMenuCadastro : Form
    {
        public formMenuCadastro()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            formCliente abrirformCliente = new formCliente();

            abrirformCliente.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }



        private void button12_Click(object sender, EventArgs e)
        {

            formTributo frmTipo = new formTributo();

            frmTipo.Show();

        }



        private void btnTipoTributoAbrir_Click(object sender, EventArgs e)
        {
            formTipoTributo abrirFormTipoTributo = new formTipoTributo();

            abrirFormTipoTributo.ShowDialog();


        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            FormCadastroBancos abrirBanco = new FormCadastroBancos();
            abrirBanco.ShowDialog();

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            CadastroFornecedores abrirFornecedores = new CadastroFornecedores();
            abrirFornecedores.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            FormStatusCadastro abrir = new FormStatusCadastro();
            abrir.ShowDialog();

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            formEstado abrir = new formEstado();
            abrir.ShowDialog();
        }

        private void btnCIdade_Click(object sender, EventArgs e)
        {
            formCidade abrir = new formCidade();
            abrir.ShowDialog();
        }

        private void btnBairro_Click(object sender, EventArgs e)
        {
            formBairro abrir = new formBairro();
            abrir.ShowDialog();
        }
    
    }
}
