using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string fruta = "";

            operador = int.Parse(txtselecione.Text);

            switch (operador)
            {
                case 1:  fruta = "Banana";
                    break;
                case 2:
                    fruta = "Maça";
                    break;
                case 3:
                    fruta = "Pera";
                    break;
                case 4:
                    fruta = "Melancia";
                    break;
                default: fruta = "Nenhuma fruta selecionada.";
                    break;
            }
            txtfrutasselecionadas.Text = fruta;

           // txtfrutasselecionadas.Focus();
           // txtfrutasselecionadas.Text = "";
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            //executar o metodo criado
            limparCampos();
        }
        //criar o método para limpar os componentes
        public void limparCampos()
        {
            txtfrutasselecionadas.Clear();
            txtselecione.Text = "";
            ltbfrutas.Items.Clear();
            cbbfrutas.Items.Clear();
            cbbfrutas.Text = "";

            txtselecione.Focus();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            ltbfrutas.Items.Clear();
            ltbfrutas.Items.Add(txtfrutasselecionadas.Text);
            cbbfrutas.Items.Clear();
            cbbfrutas.Items.Add(txtfrutasselecionadas.Text);
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            //forma de sair
            //Close();
            //this.Close();
            //Application.Exit();

            DialogResult res;

            res = MessageBox.Show("Deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }

        private void txtselecione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnselecionar.Focus();
            }
        }
    }
}
