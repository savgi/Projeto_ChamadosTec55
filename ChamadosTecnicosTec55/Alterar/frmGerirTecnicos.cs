using ChamadosTecnicosTec55.Adicionar;
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

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirTecnicos : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmGerirTecnicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvGerirTecnico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvGerirTecnico.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    TecnicoDao tecnicoDao = new TecnicoDao(_conexao);
                    tecnicoDao.Excluirtecnico(codigo);
                    ListarTecnico();
                }
            }
            else
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha está selecionada no DGV
            if (dgvGerirTecnico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvGerirTecnico.CurrentRow.Cells[0].Value);

                var frmAlterarTecnico = new frmAlterarTecnico(codigo);
                frmAlterarTecnico.ShowDialog();

                //Listar Tecnico apos fechar tela
                ListarTecnico();
            }

            else
            {
                MessageBox.Show("Selecione um registro para alteração");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frmaddTecnico = new frmAdicionarTecnico();
            frmaddTecnico.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txbBuscar.Text != "")
            {
                ListarTecnico();
            }
            else
            {
                MessageBox.Show("Digite algo para buscar");
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvGerirCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGerirTecnicos_Load(object sender, EventArgs e)
        {
            ListarTecnico();
        }

        public void ListarTecnico()
        {
            //  Chama o Tecnico DAO
           TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            // Captura o valor digitado na barra de texto TXB
            string busca = txbBuscar.Text.ToString();

            // Chama o Metodo BuscarTecnico do objeto
            DataSet ds = new DataSet();
            ds = tecnicoDao.BuscaTecnico(busca);

            // Defini o DataSource do DataGridView
            dgvGerirTecnico.DataSource = ds;

            // Defini o membro do DataSet
            dgvGerirTecnico.DataMember = "Tecnicos";
        }
    }
}
