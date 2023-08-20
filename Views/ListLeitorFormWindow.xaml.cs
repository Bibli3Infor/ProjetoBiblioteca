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
using System.Windows.Shapes;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para ListLeitorFormWindow.xaml
    /// </summary>
    public partial class ListLeitorFormWindow : Window
    {
        public ListLeitorFormWindow()
        {
            InitializeComponent();
            Loaded += ListLeitorFormWindow_Loaded;
        }

        private void ListLeitorFormWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }
        private void CarregarListagem()
        {
            try
            {
                var dao = new LeitorDAO();
                List<Leitor> listaLeitor = dao.List();
                dataGridLeitor.ItemsSource = listaLeitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirLeitor_Click(object sender, RoutedEventArgs e)
        {
            var leitorSelected = dataGridLeitor.SelectedItem as Leitor;

            var result = MessageBox.Show($"Deseja realmente excluir o leitor '{leitorSelected.NomeLeitor}'?", "Confirmação de Exclusão",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (result == MessageBoxResult.Yes)
                {
                    var dao2 = new LeitorDAO();
                    dao2.Delete(leitorSelected);
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
