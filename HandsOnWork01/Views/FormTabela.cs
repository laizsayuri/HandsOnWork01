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
    public partial class FormTabela : Form
    {
        private GerenciadorBulas gerenciadorBulas;

        private bool admin;

        private List<Bula> bulas;

        public FormTabela()
        {
            InitializeComponent();
            gerenciadorBulas = new GerenciadorBulas();
            bulas = new List<Bula>();
        }

        private void buttonAddBula_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();

            if (formCadastro.DeveAtualizar)
            {
                CarregarDados();                
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Bula bula = bulas.First(b => b.Id == id);

                FormDetalhes formDetalhes = new FormDetalhes(bula, admin);
                formDetalhes.ShowDialog();

                if (formDetalhes.DeveAtualizar)
                {
                    CarregarDados();
                }
            }
        }

        private void FormTabela_Shown(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if(formLogin.TemPermissao == false)
            {
                Close();
            }

            admin = formLogin.Admin;
            CarregarDados();
        }

        private void CarregarDados()
        {
            dataGridView1.Enabled = false;
            labelCarregando.Visible = true;
            buttonAddBula.Enabled = false;
            textBoxSearch.Enabled = false;

            bulas.Clear();
            bulas = gerenciadorBulas.PegarBulas();

            dataGridView1.Rows.Clear();

            foreach(Bula bula in bulas)
            {
                dataGridView1.Rows.Add(bula.Id, bula.Nome, bula.Apresentacao);
            }

            dataGridView1.Enabled = true;
            labelCarregando.Visible = false;
            buttonAddBula.Enabled = admin;
            textBoxSearch.Enabled = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Bula> bulasPesquisa = bulas.Where(b => b.Nome.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();

            dataGridView1.Rows.Clear();            

            foreach (Bula bula in bulasPesquisa)
            {
                dataGridView1.Rows.Add(bula.Id, bula.Nome, bula.Apresentacao);
            }
        }
    }
}
