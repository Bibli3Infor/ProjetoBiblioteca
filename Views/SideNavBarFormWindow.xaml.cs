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
using System_Biblioteca.Views.Pages;

namespace System_Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para SideNavBarFormWindow.xaml
    /// </summary>
    public partial class SideNavBarFormWindow : Window
    {
        public SideNavBarFormWindow()
        {
            InitializeComponent();
            //fraPages.Content = new SideNavBarFormWindow();
        }

        private void btnCadLivro_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new CadLivroFormPage();
        }

        private void btnCadLeitor_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new CadLeitorFormPage();
        }

        private void btnCadAutor_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new CadAutorFormPage();
        }

        private void btnCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new CadFornecedorFormPage();
        }

        private void btnGenLeitor_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new GenLeitorFormPage();
        }

        private void btnGenAcervo_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new GenAcervoFormPaage();
            //fraPages.Content = new GenAcervoFormPaage(fraPages);
        }

        private void btnDevolucao_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new DevolucaoLivroFormPage();
        }

        private void btnCadFuncionario_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new CadFuncionarioFormPage();
        }

        private void btnLivrosPendentes_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new AlugarLivroFormPage();
        }

        private void btnFavoritos_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new FavoritosFormPage();
        }

        private void btnGenFuncionario_Click(object sender, RoutedEventArgs e)
        {
            fraPages.Content = new GenFuncionarioFormPage();
        }
    }
}
