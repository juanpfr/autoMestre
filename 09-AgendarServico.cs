using MySql.Data.MySqlClient;
using Mysqlx;
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
    public partial class frmAgendarServico : Form
    {
        public frmAgendarServico()
        {
            InitializeComponent();
            CarregarCmbServico();
            CarregarCmbVeiculo();
        }

        //---------------------ÍNICIO MÉTODOS-----------------------

        private void CarregarCmbServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idServico, nomeServico from tbl_servico order by nomeServico";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbServico.DataSource = dt;
                cmbServico.DisplayMember = "nomeServico";
                cmbServico.ValueMember = "idServico";

                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar a lista de serviços. \n\n" + erro);
            }
        }

        private void CarregarDadosAgenda()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT nomeServico, tbl_serv_executado.descricaoServico, nomeCliente, marcaVeiculo, modeloVeiculo, placaVeiculo, dataServico, kmVeiculoServico, valorServico, tbl_serv_executado.statusServico, nomeMecanico FROM tbl_serv_executado INNER JOIN tbl_servico ON tbl_serv_executado.idServico = tbl_servico.idServico INNER JOIN tbl_veiculo ON tbl_serv_executado.idVeiculo = tbl_veiculo.idVeiculo INNER JOIN tbl_mecanico ON tbl_serv_executado.idMecanico = tbl_mecanico.idMecanico INNER JOIN tbl_cliente ON tbl_veiculo.idCliente = tbl_cliente.idCliente WHERE idServExec = @codigo;";

                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoAgenda);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeServico = dr.GetString(0);
                    variaveis.descricaoAgenda = dr.GetString(1);
                    variaveis.nomeCliente = dr.GetString(2);
                    variaveis.marcaVeiculo = dr.GetString(3);
                    variaveis.modeloVeiculo = dr.GetString(4);
                    variaveis.placaVeiculo = dr.GetString(5);
                    variaveis.dataAgenda = dr.GetDateTime(6);
                    variaveis.kmVeiculoAgenda = dr.GetInt32(7);
                    variaveis.valorServicoAgenda = dr.GetDouble(8);
                    variaveis.statusAgenda = dr.GetString(9);
                    variaveis.nomeMecanico = dr.GetString(10);


                    cmbServico.Text = variaveis.nomeServico;
                    txtDescricao.Text = variaveis.descricaoAgenda;
                    txtCliente.Text = variaveis.nomeCliente;
                    cmbVeiculo.Text = variaveis.emailCliente + " - " + variaveis.modeloVeiculo + " - " + variaveis.placaVeiculo;
                    txtData.Text = variaveis.dataAgenda.ToShortDateString();
                    mesAgenda.SelectionStart = variaveis.dataAgenda;
                    txtKm.Text = variaveis.kmVeiculoAgenda.ToString();
                    txtValor.Text = variaveis.valorServicoAgenda.ToString("N2");
                    cmbStatus.Text = variaveis.statusAgenda;
                    cmbMecanico.Text = variaveis.nomeMecanico;
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados da AGENDA. \n\n" + erro);
            }
        }

        private void CarregarCmbVeiculo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idVeiculo, marcaVeiculo, modeloVeiculo, placaVeiculo from tbl_veiculo order by marcaVeiculo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Adicionar coluna combinada ao datatable (colocar mais de uma coisa pra vc q ta lendo q é burro (eu mesmo juan))
                dt.Columns.Add("MarcaModeloPlaca", typeof(string), "marcaVeiculo +  ' - ' + modeloVeiculo +  ' - ' + placaVeiculo");

                cmbVeiculo.DataSource = dt;
                cmbVeiculo.DisplayMember = "MarcaModeloPLaca";
                cmbVeiculo.ValueMember = "idVeiculo";

                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar a lista de veículos. \n\n" + erro);
            }
        }
        private void InserirAgenda()
        {
            try
            {
                banco.Conectar();
                string inserir = "insert into tbl_serv_executado (idServico, descricaoServico, dataServico, idVeiculo) values (@codVeiculo, @km, @status, @codMecanico)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);

                //parametros
                cmd.Parameters.AddWithValue("@codServico", variaveis.codigoServico);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoAgenda);
                cmd.Parameters.AddWithValue("@data", variaveis.dataAgenda);
                cmd.Parameters.AddWithValue("@codVeiculo", variaveis.codigoVeiculo);
                cmd.Parameters.AddWithValue("@km", variaveis.kmVeiculoAgenda);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorServicoAgenda);
                cmd.Parameters.AddWithValue("@status", variaveis.statusAgenda);
                cmd.Parameters.AddWithValue("@codMecanico", variaveis.codigoMecanico);
                //fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("SERVIÇO AGENDADO com sucesso", "AGENDAR SERVIÇO");
                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao AGENDAR SERVIÇO. \n\n" + erro);
            }
        }

        private void EditarAgenda()
        {
            try
            {
                banco.Conectar();
                string inserir = "update tbl_serv_executado set idServico=@codServico, descricaoServico=@descricao, dataServico=@data, idVeiculo=@codVeiculo, kmVeiculoServico=@km, valorServico=@valor, statusServico=@status, idMecanico=@codMecanico where idServExec=@codigo;";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);

                //parametros
                cmd.Parameters.AddWithValue("@codServico", variaveis.codigoServico);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoAgenda);
                cmd.Parameters.AddWithValue("@data", variaveis.dataAgenda);
                cmd.Parameters.AddWithValue("@codVeiculo", variaveis.codigoVeiculo);
                cmd.Parameters.AddWithValue("@km", variaveis.kmVeiculoAgenda);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorServicoAgenda);
                cmd.Parameters.AddWithValue("@status", variaveis.statusAgenda);
                cmd.Parameters.AddWithValue("@codMecanico", variaveis.codigoMecanico);
                //fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("SERVIÇO AGENDADO com sucesso", "AGENDAR SERVIÇO");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao EDITAR SERVIÇO. \n\n" + erro);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmAgendarServico_Load(object sender, EventArgs e)
        {
            if(variaveis.funcao == "AGENDAR")
            {
                lblAgendar.Text = "AGENDAR";
                cmbServico.SelectedIndex = -1;
                cmbVeiculo.SelectedIndex = -1;
                cmbMecanico.SelectedIndex = -1;
            }
            else if(variaveis.funcao == "EDITAR")
            {
                lblAgendar.Text = "EDITAR";
                CarregarDadosAgenda();
            }
            txtData.Text = mesAgenda.SelectionStart.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbServico.SelectedIndex = -1;
            txtDescricao.Clear();
            cmbVeiculo.SelectedIndex = -1;
            txtCliente.Clear();
            txtKm.Clear();
            txtValor.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbMecanico.SelectedIndex = -1;
            mesAgenda.SelectionStart = DateTime.Today;
        }

        private void mesAgenda_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = mesAgenda.SelectionStart.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblServico.ForeColor = Color.FromArgb(216, 233, 240);
            lblDescricao.ForeColor = Color.FromArgb(216, 233, 240);
            lblVeiculo.ForeColor = Color.FromArgb(216, 233, 240);
            lblStatus.ForeColor = Color.FromArgb(216, 233, 240);
            lblProprietario.ForeColor = Color.FromArgb(216, 233, 240);
            lblValor.ForeColor = Color.FromArgb(216, 233, 240);
            lblKm.ForeColor = Color.FromArgb(216, 233, 240);
            cmbMecanico.ForeColor = Color.FromArgb(216, 233, 240);

            if (cmbServico.Text == "")
            {
                MessageBox.Show("Preencher o Serviço");
                lblServico.ForeColor = Color.FromArgb(197, 82, 26);
                cmbServico.Focus();
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencher a Descrição");
                lblDescricao.ForeColor = Color.FromArgb(197, 82, 26);
                txtDescricao.Focus();
            }
            else if (cmbVeiculo.Text == "")
            {
                MessageBox.Show("Preencher o Veículo");
                lblVeiculo.ForeColor = Color.FromArgb(197, 82, 26);
                cmbVeiculo.Focus();
            }
            else if (cmbStatus.Text == "")
            {
                MessageBox.Show("Preencher o Status");
                lblStatus.ForeColor = Color.FromArgb(197, 82, 26);
                cmbStatus.Focus();
            }
            else if (txtCliente.Text == "")
            {
                MessageBox.Show("Preencher o Proprietário");
                lblProprietario.ForeColor = Color.FromArgb(197, 82, 26);
                txtCliente.Focus();
            }
            else if (txtKm.Text == "")
            {
                MessageBox.Show("Preencher o KM");
                lblKm.ForeColor = Color.FromArgb(197, 82, 26);
                txtKm.Focus();
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("Preencher o Valor");
                lblValor.ForeColor = Color.FromArgb(197, 82, 26);
                txtValor.Focus();
            }
            else if (cmbMecanico.Text == "")
            {
                MessageBox.Show("Preencher o Mecânico");
                lblMecanico.ForeColor = Color.FromArgb(197, 82, 26);
                cmbMecanico.Focus();
            }
            else
            {
                variaveis.codigoServico = Convert.ToInt32(cmbServico.SelectedValue);
                variaveis.descricaoAgenda = txtDescricao.Text;
                variaveis.codigoVeiculo = Convert.ToInt32(cmbVeiculo.SelectedValue);
                variaveis.nomeCliente = txtCliente.Text;
                variaveis.kmVeiculoAgenda = int.Parse(txtKm.Text);
                variaveis.valorServicoAgenda = double.Parse(txtValor.Text);
                variaveis.dataAgenda = Convert.ToDateTime(txtData.Text);
                variaveis.statusAgenda = cmbStatus.Text;
                variaveis.codigoMecanico = Convert.ToInt32(cmbMecanico.SelectedValue);

                if(variaveis.funcao == "AGENDAR")
                {
                    InserirAgenda();
                    btnLimpar.PerformClick();
                }
                else if(variaveis.funcao == "EDITAR")
                {
                    EditarAgenda();
                    CarregarDadosAgenda();
                }
            }
        }
    }
}
