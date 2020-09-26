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
    public partial class FormSenha : Form
    {
        public bool SenhaCorreta { get; internal set; }

        public FormSenha()
        {
            InitializeComponent();            
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "admin")
            {
                SenhaCorreta = true;
                Close();
            }
            else
            {
                MessageBox.Show("Erro! Senha incorreta!", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
