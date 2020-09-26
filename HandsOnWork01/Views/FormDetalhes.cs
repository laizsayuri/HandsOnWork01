using HandsOnWork01.Controllers;
using HandsOnWork01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOnWork01
{
    public partial class FormDetalhes : Form
    {
        private GerenciadorBulas gerenciadorBulas;
        private Bula bula;
        public bool DeveAtualizar { get; private set; }
        private bool admin;

        public FormDetalhes(Bula bula, bool admin)
        {
            InitializeComponent();
            gerenciadorBulas = new GerenciadorBulas();
            this.bula = bula;
            this.admin = admin;
            CarregarBula();
        }


        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(bula);
            formCadastro.ShowDialog();

            if (formCadastro.DeveAtualizar)
            {
                DeveAtualizar = true;
                Close();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Você deseja realmente remover essa bula?",
                                     "Remover Bula",
                                     MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                gerenciadorBulas.RemoverBula(bula.Id);
                DeveAtualizar = true;
                Close();
            }            
        }

        private void CarregarBula()
        {
            textBoxNome.Text = bula.Nome;
            textBoxApresentacao.Text = bula.Apresentacao;
            textBoxComposicao.Text = bula.Composicao;
            textBoxIndicacao.Text = bula.Indicacao;
            textBoxUso.Text = bula.Uso;

            buttonAlterar.Enabled = admin;
            buttonRemover.Enabled = admin;
        }
    }
}
