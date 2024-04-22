﻿using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmAlterarTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlterarTecnico(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {

                Tecnico tecnico = new Tecnico();
                TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

                tecnico = tecnicoDao.ObtemTecnico(codigo);

                if (tecnico == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }

                txbCodigo.Text = tecnico.CodigoTecnico.ToString();
                txbNome.Text = tecnico.Nome.ToString();
                txbEspecialidade.Text = tecnico.Especialidade.ToString();
                txbEmail.Text = tecnico.Email.ToString();
                txbSenha.Text = tecnico.Senha.ToString();
                txbObs.Text = tecnico.Obs.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            try
            {
                tecnico.Nome = txbNome.Text;
                tecnico.Especialidade = txbEspecialidade.Text;
                tecnico.Email = txbEmail.Text;
                tecnico.Senha = txbSenha.Text;
                tecnico.Obs = txbObs.Text;

                int codigo = Convert.ToInt32(txbCodigo.Text);
                tecnico.CodigoTecnico = codigo;
                tecnicodao.AlterarTecnico(tecnico);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmAlterarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
