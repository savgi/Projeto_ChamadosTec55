using Data;
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
    public partial class frmAdicionarTecnico : Form
    {
        // Chamaaa a conexão 
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarTecnico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            if (string.IsNullOrEmpty(txbNOME.Text) || string.IsNullOrEmpty(txbESPECIALIDADE.Text) || string.IsNullOrEmpty(txbEMAIL.Text) || string.IsNullOrEmpty(txbSENHA.Text) || string.IsNullOrEmpty(txbOBS.Text))
            {
                MessageBox.Show("CADE OS DADOSSS??");
            }
            else
            {
                try
                {
                    
                    tecnico.Nome = txbNOME.Text;
                    tecnico.Especialidade = txbESPECIALIDADE.Text;
                    tecnico.Email = txbEMAIL.Text;
                    tecnico.Senha = txbSENHA.Text;
                    tecnico.Obs = txbOBS.Text;
                    
                    tecnicoDao.IncluiTecnico(tecnico);
                    MessageBox.Show("Cadastrado com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txbSENHA.Clear();
            txbEMAIL.Clear();
            txbESPECIALIDADE.Clear();
            txbNOME.Clear();
            txbOBS.Clear();
        }

        private void frmAdicionarTecnico_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
} 
