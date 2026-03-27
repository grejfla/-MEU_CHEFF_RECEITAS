using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMeuChef
{
    public partial class frmTelaLoginSecundaria : Form
    {
        public frmTelaLoginSecundaria()
        {
            InitializeComponent();
        }

        private void btnEntreAqui_Click(object sender, EventArgs e)
        {
            string NomeFuncionario = txtNomeFuncionario.Text;
            string SenhaFuncionario = txtSenhaFuncionario.Text;
            string Funcao = cbFuncionarios.Text;

            CredenciaisFuncionarios cf = new CredenciaisFuncionarios(NomeFuncionario, SenhaFuncionario, Funcao);

            if (cf.CredenciaisAjudante())
            {
                frmTelaLogin ftl = new frmTelaLogin();
                ftl.Show();
                this.Visible = false;//fecha a tela
            }
            else if (cf.CredenciaisCozinheiro1 ())
            {
                frmTelaLogin ftl = new frmTelaLogin();
                ftl.Show();
                this.Visible = false;//fecha a tela
            }
            else if (cf.CredenciaisCozinheiro2())
            {
                frmTelaLogin ftl = new frmTelaLogin();
                ftl.Show();
                this.Visible = false;//fecha a tela
            }
            else
            {
                MessageBox.Show("Credenciais incorretas. Tente novamente");
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
