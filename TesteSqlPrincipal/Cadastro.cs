using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSqlPrincipal
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testePrincipalDataSet);
            MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.testePrincipalDataSet.Table);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Login_adm login = new Login_adm();
            login.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
    }
}
