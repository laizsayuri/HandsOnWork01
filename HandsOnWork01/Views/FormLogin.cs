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
    public partial class FormLogin : Form
    {
        public bool TemPermissao { get; set; }

        public bool Admin { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            comboBoxTipoAcesso.SelectedIndex = 0;
        }

        private void buttonAcesso_Click(object sender, EventArgs e)
        {
            if(comboBoxTipoAcesso.SelectedIndex == 1)
            {
                FormSenha formSenha = new FormSenha();
                formSenha.ShowDialog();

                if (formSenha.SenhaCorreta)
                {
                    Admin = true;
                    LiberarAcesso();                    
                }
            }
            else
            {
                LiberarAcesso();
            }
        }

        private void LiberarAcesso()
        {
            TemPermissao = true;
            Close();
        }
    }
}
