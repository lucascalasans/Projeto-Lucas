using Projeto_Lucas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Lucas.Apresentacao
{
    public partial class FCadastro : Form
    {
        public FCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FLogin log = new FLogin();
            log.Show();
        }

        private void txtCnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem =  controle.cadastrar(txtCemail.Text,txtCsenha.Text,txtsenha2.Text,txtCnome.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastrado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void FCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
