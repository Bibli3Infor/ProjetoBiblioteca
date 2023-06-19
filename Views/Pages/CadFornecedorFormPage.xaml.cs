using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views.Pages
{
    /// <summary>
    /// Interação lógica para CadFornecedorFormPage.xam
    /// </summary>
    public partial class CadFornecedorFormPage : Page
    {

        private Fornecedor _fornecedor = new Fornecedor();

        public CadFornecedorFormPage()
        {
            InitializeComponent();
        }

        private void btnCancelarFun_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnSalvarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            _fornecedor.NomeEmpresa = txtNomeEmpresa.Text;
            _fornecedor.Telefone = txtTelefoneEmpresa.Text;
            _fornecedor.Email = txtEmailEmpresa.Text;
            _fornecedor.Cnpj = txtCnpjEmpresa.Text;
            _fornecedor.Endereco = txtEnderecoEmpresa.Text;
            _fornecedor.Descricao = txtDescEmpresa.Text;
            _fornecedor.RazaoSocial = txtRazaoEmpresa.Text;

            try
            {
                var dao = new FornecedorDAO();

                dao.Insert(_fornecedor);
                MessageBox.Show("Registro Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
