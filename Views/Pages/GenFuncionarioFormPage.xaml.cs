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
using System_Biblioteca.Views;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views.Pages
{
    /// <summary>
    /// Interação lógica para GenFuncionarioFormPage.xam
    /// </summary>
    public partial class GenFuncionarioFormPage : Page
    {
        public GenFuncionarioFormPage()
        {
            InitializeComponent();
            Loaded += GenFuncionarioFormPage_Loaded;
        }

        private void GenFuncionarioFormPage_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }


        private void CarregarListagem()
        {
            try
            {
                var dao = new FuncionarioDAO();
                List<Funcionario> listaFuncionario = dao.List();
                dataGridFuncionario.ItemsSource = listaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirFuncionario_Click(object sender, RoutedEventArgs e)
        {
            var funcionarioSelected = dataGridFuncionario.SelectedItem as Funcionario;

            var result = MessageBox.Show($"Deseja realmente excluir o Funcionario '{funcionarioSelected.NomeFuncionario}'?", "Confirmação de Exclusão",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (result == MessageBoxResult.Yes)
                {
                    var dao2 = new FuncionarioDAO();
                    dao2.Delete(funcionarioSelected);
                    CarregarListagem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
