using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSqlPrincipal.Modelo;

namespace TesteSqlPrincipal
{
    public partial class Login_adm : Form
    {
        public Login_adm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(textUsuario.Text, textSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ApresentarDados apresentarDados = new ApresentarDados();
                    apresentarDados.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Login não encontrado, Verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
