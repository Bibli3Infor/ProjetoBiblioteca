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
    /// Lógica interna para ListFuncionarioFormWindow.xaml
    /// </summary>
    public partial class ListFuncionarioFormWindow : Window
    {
        public ListFuncionarioFormWindow()
        {
            Loaded += ListFuncionarioFormWindow_Loaded;
        }

        private void ListFuncionarioFormWindow_Loaded(object sender, RoutedEventArgs e)
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
    }
}
