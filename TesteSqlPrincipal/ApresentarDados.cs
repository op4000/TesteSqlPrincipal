using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSqlPrincipal.Apresentação;

namespace TesteSqlPrincipal
{
    public partial class ApresentarDados : Form
    {
        public ApresentarDados()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testePrincipalDataSet);

        }

        private void ApresentarDados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testePrincipalDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.testePrincipalDataSet.Table);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cadastro_adm cadastro_Adm = new Cadastro_adm();
            cadastro_Adm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
