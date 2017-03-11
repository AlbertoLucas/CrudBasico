using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxLogin.Text) && (!String.IsNullOrEmpty(txtBoxSenha.Text)))
                AcessarSistema(this.txtBoxLogin.Text, this.txtBoxSenha.Text);
        }

        private void AcessarSistema(string Login, string Senha)
        {
            Dados objDados = new Dados();
            List<Dados.Acesso> lstRetorno = objDados.ConsultarAcesso(Login, Senha);

            if (lstRetorno != null && lstRetorno.Count > 0)
            {
                frmCadastro objFrmCadastro = new CrudBasico.frmCadastro();
                objFrmCadastro.ShowDialog();
            }
         
        }
    }
}
