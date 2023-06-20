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
        }

        private void btnListaFuncionario_Click(object sender, RoutedEventArgs e)
        {
            ListLivroFormWindow view = new ListLivroFormWindow();
            view.ShowDialog();
        }
    }
}
