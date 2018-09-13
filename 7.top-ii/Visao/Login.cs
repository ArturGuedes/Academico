using Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visao;

namespace Visao
{
    public partial class Login : UI.wForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (CtrlLogin.log)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CtrlLogin.Login(txtbUser.Text, txtbPass.Text);
            if (CtrlLogin.log)
            {
                UI.wAlert.Show("Login efetuado!", 1000);
                this.Close();
            }
            else
            {
                UI.wAlert.Show("ATENÇÃO: Usuário ou senha incorretos!", 1000);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
