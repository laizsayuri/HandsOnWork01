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
    public partial class FormCadastro : Form
    {
        private GerenciadorBulas gerenciadorBulas;
        public bool DeveAtualizar { get; set; }
        private Bula bulaEditada;

        public FormCadastro(Bula bula)
        {
            InitializeComponent();
            gerenciadorBulas = new GerenciadorBulas();
            bulaEditada = bula;
            CarregarBula();
        }

        public FormCadastro()
        {
            InitializeComponent();
            gerenciadorBulas = new GerenciadorBulas();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if(bulaEditada == null)
            {
                if (gerenciadorBulas.JaExiste(textBoxNome.Text))
                {
                    MessageBox.Show("Erro! Já existe uma bula cadastrada com esse nome!", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (bulaEditada.Nome != textBoxNome.Text && gerenciadorBulas.JaExiste(textBoxNome.Text))
                {
                    MessageBox.Show("Erro! Já existe uma bula cadastrada com esse nome!", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Bula bula = new Bula();
            bula.Nome = textBoxNome.Text;
            bula.Apresentacao = textBoxApresentacao.Text;
            bula.Composicao = textBoxComposicao.Text;
            bula.Uso = textBoxUso.Text;
            bula.Indicacao = textBoxIndicacao.Text;

            if(bulaEditada != null)
            {
                bula.Id = bulaEditada.Id;
            }

            if (bula.Validar())
            {
                if(bulaEditada != null)
                {
                    gerenciadorBulas.EditarBula(bula);
                }
                else
                {
                    gerenciadorBulas.CriarBula(bula);                    
                }
                DeveAtualizar = true;
                Close();
            }
            else
            {
                MessageBox.Show("Erro! Preencha todos os campos!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CarregarBula()
        {
            textBoxNome.Text = bulaEditada.Nome;
            textBoxApresentacao.Text = bulaEditada.Apresentacao;
            textBoxComposicao.Text = bulaEditada.Composicao;
            textBoxIndicacao.Text = bulaEditada.Indicacao;
            textBoxUso.Text = bulaEditada.Uso;
        }
    }
}
