using MySql.Data.MySqlClient;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            CarregarCliente();
        }

        //------------------------INICIO MÉTODOS----------------------
        private void CarregarCliente()
        {
            try
            {
                banco.Conectar();//abrir o banco de dados
                string selecionar = "select * from tbl_cliente where statusCliente <> 'DESATIVADO' order by nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//adaptar ao C#
                DataTable dt = new DataTable();//criando uma estrutura de tabela
                da.Fill(dt);//pegar o comando q foi adaptado ao c# e preencher a tabela (dt)

                dgvCliente.DataSource = dt;//coloca a tabela no DataGridView
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[3].HeaderText = "TELEFONE";
                dgvCliente.Columns[4].HeaderText = "E-MAIL";
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].HeaderText = "FOTO";
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].HeaderText = "STATUS";
                dgvCliente.Columns[9].Visible = false;

                dgvCliente.ClearSelection();//Não ficar nada selecionado
                banco.Desconectar();//fechar o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE.\n\n" + erro);
            }
        }
        private void CarregarClienteStatus()
        {
            try
            {
                banco.Conectar();//abrir o banco de dados
                string selecionar = "select * from tbl_cliente where statusCliente = @status;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//adaptar ao C#
                DataTable dt = new DataTable();//criando uma estrutura de tabela
                da.Fill(dt);//pegar o comando q foi adaptado ao c# e preencher a tabela (dt)

                dgvCliente.DataSource = dt;//coloca a tabela no DataGridView
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[3].HeaderText = "TELEFONE";
                dgvCliente.Columns[4].HeaderText = "E-MAIL";
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].HeaderText = "FOTO";
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].HeaderText = "STATUS";
                dgvCliente.Columns[9].Visible = false;

                dgvCliente.ClearSelection();//Não ficar nada selecionado
                banco.Desconectar();//fechar o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE por STATUS.\n\n" + erro);
            }
        }
        private void CarregarClienteNome()
        {
            try
            {
                banco.Conectar();//abrir o banco de dados
                string selecionar = "select * from tbl_cliente where nomeCliente LIKE '%"+txtCliente.Text+"%' order by nomeCliente asc;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@nome", txtCliente.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//adaptar ao C#
                DataTable dt = new DataTable();//criando uma estrutura de tabela
                da.Fill(dt);//pegar o comando q foi adaptado ao c# e preencher a tabela (dt)

                dgvCliente.DataSource = dt;//coloca a tabela no DataGridView
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[3].HeaderText = "TELEFONE";
                dgvCliente.Columns[4].HeaderText = "E-MAIL";
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].HeaderText = "FOTO";
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].HeaderText = "STATUS";
                dgvCliente.Columns[9].Visible = false;

                dgvCliente.ClearSelection();//Não ficar nada selecionado
                banco.Desconectar();//fechar o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o CLIENTE por NOME.\n\n" + erro);
            }
        }
        private void ExcluirCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "update tbl_cliente set statusCliente = 'DESATIVADO' where idCLiente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);

                //parametros
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);
                //fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente desativado com sucesso.", "DESATIVAR CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar cliente.\n\n" + erro);
            }
        }

        //--------------------------FIM MÉTODOS-----------------------

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione um cliente da lista.");
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.ClearSelection();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "TODOS")
            {
                CarregarCliente();
            }
            else
            {
                CarregarClienteStatus();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtCliente.Text == "")
            {
                cmbStatus.Enabled = true;
                cmbStatus.Text = "TODOS";
                CarregarCliente();
            }
            else
            {
                cmbStatus.Enabled = false;
                CarregarClienteNome();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if(variaveis.linhaSelecionada >= 0)
            {
                variaveis.codigoCliente = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending);
            dgvCliente.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja mesmo excluir o cliente?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resposta == DialogResult.Yes)
                {
                    var resposta2 = MessageBox.Show("Tem certeza? Essa ação não poderá ser desfeita", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
                    if(resposta2 == DialogResult.Yes)
                    {
                        ExcluirCliente();
                        CarregarCliente();
                    }
                }
            }
        }
    }
}
