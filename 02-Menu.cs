using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoMestreJuan
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            CarregarAgenda();
        }

        //Iniciar Métodos

        private void CarregarAgenda()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idServExec, nomeServico, tbl_serv_executado.descricaoServico, nomeCliente, modeloVeiculo, placaVeiculo, nomeMecanico FROM tbl_serv_executado INNER JOIN tbl_servico ON tbl_serv_executado.idServico = tbl_servico.idServico INNER JOIN tbl_veiculo ON tbl_serv_executado.idVeiculo = tbl_veiculo.idVeiculo INNER JOIN tbl_mecanico ON tbl_serv_executado.idMecanico = tbl_mecanico.idMecanico INNER JOIN tbl_cliente ON tbl_veiculo.idCliente = tbl_cliente.idCliente WHERE tbl_serv_executado.statusServico = 'ATIVO' ORDER BY dataServico;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//adaptar ao C#
                DataTable dt = new DataTable();//criando uma estrutura de tabela
                da.Fill(dt);//pegar o comando q foi adaptado ao c# e preencher a tabela (dt)

                dgvAgenda.DataSource = dt;//coloca a tabela no DataGridView
                dgvAgenda.Columns[0].Visible = false;
                dgvAgenda.Columns[1].HeaderText = "SERVIÇO";
                dgvAgenda.Columns[2].HeaderText = "DESCRIÇÃO";
                dgvAgenda.Columns[3].HeaderText = "PROPRIETÁRIO";
                dgvAgenda.Columns[4].HeaderText = "VEÍCULO";
                dgvAgenda.Columns[5].HeaderText = "PLACA";
                dgvAgenda.Columns[6].HeaderText = "MECÂNICO";

                dgvAgenda.ClearSelection();//Não ficar nada selecionado
                banco.Desconectar();//fechar o banco
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar a AGENDA. \n\n" + erro);
            }
        }

        private void CarregarAgendaNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idServExec, nomeServico, tbl_serv_executado.descricaoServico, nomeCliente, modeloVeiculo, placaVeiculo, nomeMecanico FROM tbl_serv_executado INNER JOIN tbl_servico ON tbl_serv_executado.idServico = tbl_servico.idServico INNER JOIN tbl_veiculo ON tbl_serv_executado.idVeiculo = tbl_veiculo.idVeiculo INNER JOIN tbl_mecanico ON tbl_serv_executado.idMecanico = tbl_mecanico.idMecanico INNER JOIN tbl_cliente ON tbl_veiculo.idCliente = tbl_cliente.idCliente WHERE tbl_serv_executado.statusServico = 'ATIVO' LIKE'%" + txtCliente.Text + "%' ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//adaptar ao C#
                DataTable dt = new DataTable();//criando uma estrutura de tabela
                da.Fill(dt);//pegar o comando q foi adaptado ao c# e preencher a tabela (dt)

                dgvAgenda.DataSource = dt;//coloca a tabela no DataGridView
                dgvAgenda.Columns[0].Visible = false;
                dgvAgenda.Columns[1].HeaderText = "SERVIÇO";
                dgvAgenda.Columns[2].HeaderText = "DESCRIÇÃO";
                dgvAgenda.Columns[3].HeaderText = "PROPRIETÁRIO";
                dgvAgenda.Columns[4].HeaderText = "VEÍCULO";
                dgvAgenda.Columns[5].HeaderText = "PLACA";
                dgvAgenda.Columns[6].HeaderText = "MECÂNICO";

                dgvAgenda.ClearSelection();//Não ficar nada selecionado
                banco.Desconectar();//fechar o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a AGENDA por CLIENTE. \n\n" + erro);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnSair.Size = new Size(50, 50);
            btnSair.Location = new Point(1135, 5);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.Size = new Size(40, 40);
            btnSair.Location = new Point(1140, 10);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja sair do sistema?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(resposta == DialogResult.No)
            {
                new frmLogin().Show();
                Close();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            new frmVeiculo().Show();
            Hide();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            new frmMecanico().Show();
            Hide();
        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            if(variaveis.especialidade != "MOTOR")
            {
                new frmBanner().Show();
                Hide();
            }
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            new frmGaleria().Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = variaveis.usuario + " - " + variaveis.especialidade;
            timer1.Start();
            dgvAgenda.ClearSelection();
            variaveis.linhaSelecionada = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "AGENDAR";
            new frmAgendarServico().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "EDITAR";
            new frmAgendarServico().Show();
            Hide();
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoCliente = Convert.ToInt32(dgvAgenda[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvAgenda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAgenda.Sort(dgvAgenda.Columns[1], ListSortDirection.Ascending);
            dgvAgenda.ClearSelection();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                CarregarAgenda();
            }
            else
            {
                CarregarAgendaNome();
            }
        }
    }
}
