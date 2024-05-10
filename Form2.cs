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
            new frmBanner().Show();
            Hide();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            new frmGaleria().Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = variaveis.usuario;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
