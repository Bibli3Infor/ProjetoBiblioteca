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
    /// Interação lógica para CadAutorFormPage.xam
    /// </summary>
    public partial class CadAutorFormPage : Page
    {

        private Autor _autor = new Autor();

        public CadAutorFormPage()
        {
            InitializeComponent();
        }

        private void btnCancelarFun_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSalvarAutor_Click(object sender, RoutedEventArgs e)
        {
            _autor.NomeAutor = txtNomeAutor.Text;
            _autor.NacionalidadeAutor = txtNacionalidadeAutor.Text;
            _autor.EmailAutor = txtEmailAutor.Text;
            if (_autor.SexoAutor == "Feminino")
            {
                rdbtFemininoAutor.IsChecked = true;
            }
            else
            {
                rdbtMasculinoAutor.IsChecked = true;
            }
            _autor.ContatoAutor = txtContatoAutor.Text;
            _autor.DataNascimentoAutor = dtpDataNascAutor.SelectedDate;

            try
            {
                var dao = new AutorDAO();

                dao.Insert(_autor);
                MessageBox.Show("Registro Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
