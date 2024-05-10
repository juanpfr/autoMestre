using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        //------------------------INICIO MÉTODOS----------------------

        private void InserirCliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "insert into tbl_cliente(nomeCliente, enderecoCliente, telefoneCliente, emailCliente, senhaCliente, fotoCliente, altCliente, statusCliente) values(@nome, @endereco, @telefone, @email, @senha, @foto, @alt, @status);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);

                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoCliente);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneCliente);
                cmd.Parameters.AddWithValue("@email", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoCliente);
                cmd.Parameters.AddWithValue("@alt", variaveis.altCliente);
                cmd.Parameters.AddWithValue("@status", variaveis.statusCliente);
                //fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso.", "CADASTRO DE CLIENTE");
                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao inserir cliente.\n\n" + erro);
            }
        }

        private void CarregarDadosCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "select * from tbl_cliente where idCliente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeCliente = dr.GetString(1);
                    variaveis.enderecoCliente = dr.GetString(2);
                    variaveis.telefoneCliente = dr.GetString(3);
                    variaveis.emailCliente = dr.GetString(4);
                    variaveis.senhaCliente = dr.GetString(5);
                    variaveis.fotoCliente = dr.GetString(6);
                    variaveis.fotoCliente = variaveis.fotoCliente.Remove(0, 8); //a partir da posição 0, remover 8 caracteres
                    variaveis.altCliente = dr.GetString(7);
                    variaveis.statusCliente = dr.GetString(8);
                    variaveis.dataCadCliente = dr.GetDateTime(9);

                    txtNome.Text = variaveis.nomeCliente;
                    txtEndereco.Text = variaveis.enderecoCliente;
                    txtTelefone.Text = variaveis.telefoneCliente;
                    txtEmail.Text = variaveis.emailCliente;
                    txtSenha.Text = variaveis.senhaCliente;
                    MessageBox.Show(variaveis.fotoCliente);
                    cmbStatus.Text = variaveis.statusCliente;
                }
                banco.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar dados do cliente.\n\n" + erro);
            }
        }

        private void AlterarCliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "update tbl_cliente set nomeCliente = @nome, enderecoCliente = @endereco, telefoneCliente = @telefone, emailCliente = @email, senhaCliente = @senha, altCliente = @alt, statusCliente = @status where idCLiente = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);

                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoCliente);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneCliente);
                cmd.Parameters.AddWithValue("@email", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@alt", variaveis.altCliente);
                cmd.Parameters.AddWithValue("@status", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codigoCliente);
                //fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso.", "ALTERAR CLIENTE");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar cliente.\n\n" + erro);
            }
        }

        //--------------------------FIM MÉTODOS-----------------------

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            cmbStatus.SelectedIndex = -1;
            txtEmail.Clear();
            txtSenha.Clear();
            pctFoto.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.FromArgb(216, 233, 240);
            lblEndereco.ForeColor = Color.FromArgb(216, 233, 240);
            lblTelefone.ForeColor = Color.FromArgb(216, 233, 240);
            lblStatus.ForeColor = Color.FromArgb(216, 233, 240);
            lblEmail.ForeColor = Color.FromArgb(216, 233, 240);
            lblSenha.ForeColor = Color.FromArgb(216, 233, 240);

            if(txtNome.Text == "")
            {
                MessageBox.Show("Preencher o nome do cliente");
                lblNome.ForeColor = Color.FromArgb(197, 82, 26);
                txtNome.Focus();
            }
            else if(txtEndereco.Text == "")
            {
                MessageBox.Show("Preencher o endereço do cliente");
                lblEndereco.ForeColor = Color.FromArgb(197, 82, 26);
                txtEndereco.Focus();
            }
            else if(txtTelefone.MaskCompleted == false)
            {
                MessageBox.Show("Preencher o telefone do cliente");
                lblTelefone.ForeColor = Color.FromArgb(197, 82, 26);
                txtTelefone.Focus();
            }
            else if(cmbStatus.Text == "")
            {
                MessageBox.Show("Preencher o status do cliente");
                lblStatus.ForeColor = Color.FromArgb(197, 82, 26);
                cmbStatus.Focus();
            }
            else if(txtEmail.Text == "")
            {
                MessageBox.Show("Preencher o email do cliente");
                lblEmail.ForeColor = Color.FromArgb(197, 82, 26);
                txtEmail.Focus();
            }
            else if(txtSenha.Text == "")
            {
                MessageBox.Show("Preencher a senha do cliente");
                lblSenha.ForeColor = Color.FromArgb(197, 82, 26);
                txtSenha.Focus();
            }
            else
            {
                variaveis.nomeCliente = txtNome.Text;
                variaveis.enderecoCliente = txtEndereco.Text;
                variaveis.telefoneCliente = txtTelefone.Text;
                variaveis.emailCliente = txtEmail.Text;
                variaveis.senhaCliente = txtSenha.Text;
                variaveis.fotoCliente = "cliente/"+txtNome.Text.ToLower().Replace(" ","")+".png";
                variaveis.altCliente = "foto" + txtNome.Text;
                variaveis.statusCliente = cmbStatus.Text;

                if(variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                    btnSair.PerformClick();
                }
                else if(variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                }

                MessageBox.Show("Cadastrar");
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            if(variaveis.funcao == "CADASTRAR")
            {
                lblCadastro.Text = "CADASTRAR";
            }
            else if(variaveis.funcao == "ALTERAR")
            {
                lblCadastro.Text = "ALTERAR";
                CarregarDadosCliente(); 
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }
    }
}
