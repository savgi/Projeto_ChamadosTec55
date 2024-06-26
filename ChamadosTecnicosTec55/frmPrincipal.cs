﻿using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msBox = MessageBox.Show("Oh, vai mesmo sair?","Sistema de Chamados",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(msBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://sp.senac.br",
                UseShellExecute = true,
            });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcliente = new frmAdicionarCliente();
            // Define o Formulario pai
            formcliente.MdiParent = this;
            formcliente.Show();

        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtecnico = new frmTecnicoAdicionar();
            formtecnico.MdiParent = this;
            formtecnico.Show();
        }

        private void gestorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formgerirtecnico = new frmGerirClientes();
            formgerirtecnico.MdiParent = this;
            formgerirtecnico.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestorDeChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formgerirtecnico = new frmGerirTecnicos();
            formgerirtecnico.MdiParent = this;
            formgerirtecnico.Show();
        }
    }
}
