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
    }
}
