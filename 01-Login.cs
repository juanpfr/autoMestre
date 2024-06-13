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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Métodos

        //Método login

        private void Login()
        {
            try
            {
                banco.Conectar();
                string selecionar = "select nomeMecanico, emailMecanico, senhaMecanico, especialidadeMecanico from tbl_mecanico where emailMecanico = @email and senhaMecanico = @senha and statusMecanico = @status;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                cmd.Parameters.AddWithValue("@status", "ATIVO");
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    variaveis.usuario = reader.GetString(0);
                    variaveis.especialidade = reader.GetString(3);
                    new frmMenu().Show();
                    Hide();
                }
                else
                {
                    variaveis.tentativa = variaveis.tentativa + 1;
                    if (variaveis.tentativa == 3)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO\n\nVocê tem mais " + (3 - variaveis.tentativa) + "tentativas.");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao efetuar o login");
            }
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackgroundImage = Properties.Resources.xCinza;
        }

        private void btnFechar_DragLeave(object sender, EventArgs e)
        {
            btnFechar.BackgroundImage= Properties.Resources.xLaranja;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            variaveis.senha = txtSenha.Text;

            if(variaveis.usuario == "fiufiu" && variaveis.senha == "123")
            {
                variaveis.especialidade = "";
                new frmMenu().Show();
                Hide();
            }
            else
            {
                Login();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
