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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        #region Variaveis Publicas

        public int Codigo = 0;
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string Sexo;
        public bool Ativo;
        public DateTime DataCadastro;

        #endregion

        //Método para ser chamado dentro do evento Click
        #region
        private void Atualizar(int IdCliente, string Nome, string Endereco, string Telefone, string Sexo, bool Ativo)
        {
            try
            {
                Dados objDados = new Dados();
                objDados.Atualizar(IdCliente, Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                
            }

        }
        private void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo)
        {

            try
            {
                Dados objDados = new Dados();
                objDados.Gravar(Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
                MessageBox.Show("Dados Gravados com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }


        }
        
        #endregion
        //Evento click
        private void btnGravar_Click(object sender, EventArgs e)
        {       
            if(!String.IsNullOrEmpty(txtBoxNome.Text) && 
                !String.IsNullOrEmpty(mTxtBoxTelefone.Text))
            {
                string strSexo = string.Empty;
                bool blnAtivo = false;

                if(radioBtnMasculino.Checked)                
                    strSexo = "M";                
                else
                    strSexo = "F";
                if(radioBtnAtivo.Checked)
                    blnAtivo = true;
                else
                    blnAtivo = false;

                if (Codigo == 0)
                    Gravar(txtBoxNome.Text, txtBoxEndereco.Text, mTxtBoxTelefone.Text, strSexo, blnAtivo);
                else
                    Atualizar(Codigo, txtBoxNome.Text, txtBoxEndereco.Text, mTxtBoxTelefone.Text, strSexo, blnAtivo);
             }
            else
            {
                if (String.IsNullOrEmpty(txtBoxNome.Text))
                    MessageBox.Show("Informe o Nome");

                if (String.IsNullOrEmpty(txtBoxEndereco.Text))
                    MessageBox.Show("Informe o Endereço");
            }

           
         }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if(Codigo > 0)
            {
                btnGravar.Text = "Atualizar";
                txtBoxNome.Text = Nome;
                txtBoxEndereco.Text = Endereco;
                mTxtBoxTelefone.Text = Telefone;

                if (Sexo.Equals("M"))
                    radioBtnMasculino.Checked = true;
                else
                    radioBtnFeminino.Checked = true;

                if (Ativo)
                    radioBtnAtivo.Checked = true;
                else
                    radioBtnInativo.Checked = true;

                
            }
            else
            {
                btnGravar.Text = "Gravar";
            }
        }
    }
}
