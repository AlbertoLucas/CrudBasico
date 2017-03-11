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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            CarregarListView();            
        }



        //Método para Carregar o Grid View com as informações do banco de dados
        #region Métodos

        private void CarregarListView()
    {
        //instancio a classe de dados para poder buscar o que está gravado no banco
        Dados objDados = new Dados();
        //carregando a lista de clientes
        List<Dados.Clientes> listaClientes = new List<Dados.Clientes>();
        //A minha lista de clientes recebe o que o método retorna
        listaClientes = objDados.Consultar();

        
       

        // Comando para poder varrer os itens
        foreach (var itemLista in listaClientes)
        {
                // Criando um objeto para fazer a varredura e incluir na lista
                ListViewItem objListViewItem = new ListViewItem();

            objListViewItem.Text = itemLista.IdCLiente.ToString();
            objListViewItem.SubItems.Add(itemLista.Nome);
            objListViewItem.SubItems.Add(itemLista.Endereco);
            objListViewItem.SubItems.Add(itemLista.Telefone);
            objListViewItem.SubItems.Add(itemLista.Sexo);

            // comando que verifica se o campo ativo está como true ou false
            if (itemLista.Ativo)
                objListViewItem.SubItems.Add("Sim");
            else
                objListViewItem.SubItems.Add("Não");

            //
            objListViewItem.SubItems.Add(itemLista.DataCadastro.ToShortDateString());
            lstClientes.Items.Add(objListViewItem);



        }
    }
        
        private void ExcluirRegistro()
        {
            int Codigo = 0;

            try
            {
                if (lstClientes.SelectedItems.Count > 0)
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);

                Dados objDados = new Dados();

                if (Codigo > 0)
                {
                    objDados.Excluir(Codigo);
                    MessageBox.Show("Excluído! ");
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                throw;
            }

        }

        private void EditarRegistro()
        {
            int Codigo;
            string Nome;
            string Endereco;
            string Telefone;
            string Sexo;
            bool Ativo;
            DateTime DataCadastro;

            try
            {
                if(lstClientes.SelectedItems.Count > 0)
                {
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                    Nome = lstClientes.SelectedItems[0].SubItems[1].Text;
                    Endereco = lstClientes.SelectedItems[0].SubItems[2].Text;
                    Telefone = lstClientes.SelectedItems[0].SubItems[3].Text;
                    Sexo = lstClientes.SelectedItems[0].SubItems[4].Text;

                    if (lstClientes.SelectedItems[0].SubItems[5].Text.Equals("Sim"))
                        Ativo = true;
                    else
                        Ativo = false;

                    DataCadastro = Convert.ToDateTime(lstClientes.SelectedItems[0].SubItems[6].Text);

                    frmCadastro objFrmCadastro = new frmCadastro();
                    objFrmCadastro.Codigo = Codigo;
                    objFrmCadastro.Nome = Nome;
                    objFrmCadastro.Endereco = Endereco;
                    objFrmCadastro.Telefone = Telefone;
                    objFrmCadastro.Sexo = Sexo;
                    objFrmCadastro.Ativo = Ativo;
                    objFrmCadastro.DataCadastro = DataCadastro;
                    objFrmCadastro.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguint erro: " + ex.Message);         
            }
        }

        #endregion



        //Evento Click dos Botões
        #region Evento Click
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
            
      
        }

        #endregion
    }

}
