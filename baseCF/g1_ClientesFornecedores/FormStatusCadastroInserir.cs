﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace baseCF
{
    public partial class FormStatusCadastroInserir : Form
    {
        public FormStatusCadastroInserir()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open(); ;

                string SQL;
                SQL = "Insert Into g1_tblStatusCadastro (descStatusCadastro) Values";
                SQL += "('" + Status.Text + "')";

                OleDbCommand comando = new OleDbCommand(SQL, con);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso!");

                Status.Clear();
                
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Status.Clear();       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();
                string SQL;

                SQL = "UPDATE g1_tblStatusCadastro SET descStatusCadastro = '" + Status.Text + "' ";
                SQL += "WHERE idStatusCadastro = " + codigo.Text;

                OleDbCommand comando = new OleDbCommand(SQL, con);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");

                Status.Clear();
                
                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            this.Close();
        }

        private void Status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
