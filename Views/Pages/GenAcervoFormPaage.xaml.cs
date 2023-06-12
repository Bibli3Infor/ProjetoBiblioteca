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
        }

        private void btnEditarLivro_Click(object sender, RoutedEventArgs e)
        {
            
            //var livroSelected = idLivro as Livro;
            //_frame.Content = new CadLivroFormPage(livroSelected, _frame);
            
        }
    }
}
