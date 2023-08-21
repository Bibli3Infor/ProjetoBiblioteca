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
    /// Interação lógica para GenAcervoFormPaage.xam
    /// </summary>
    public partial class GenAcervoFormPaage : Page
    {
        private Frame _frame;

        public GenAcervoFormPaage(/*Frame fraPages*/)
        {
            InitializeComponent();
            Loaded += ListLivroFormPage_Loaded;
        }

        private void ListLivroFormPage_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }

        private void CarregarListagem()
        {
            try
            {
                var dao = new LivroDAO();
                List<Livro> listaLivros = dao.List();

                dataGridLivros.ItemsSource = listaLivros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarLivro_Click(object sender, RoutedEventArgs e)
        {

            //var livroSelected = idLivro as Livro;
            //_frame.Content = new CadLivroFormPage(livroSelected, _frame);

        }

        private void btnListaFuncionario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListaFornecedor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListaAutores_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExcluirLivro_Click(object sender, RoutedEventArgs e)
        {
            Livro livroSelecionado = (Livro)dataGridLivros.SelectedItem;



            if (dataGridLivros.SelectedItem != null)
            {
                var result = MessageBox.Show($"Deseja realmente excluir o livro ${livroSelecionado.TituloLivro} ?", "Confirmação de Exclusão",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);

                try
                {
                    if (result == MessageBoxResult.Yes)
                    {
                        var dao2 = new LivroDAO();
                        dao2.Delete(livroSelecionado);
                        CarregarListagem();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro", "Exceção", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}