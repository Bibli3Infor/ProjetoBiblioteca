using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views.Pages
{
    /// <summary>
    /// Interação lógica para CadLivroFormPage.xam
    /// </summary>
    public partial class CadLivroFormPage : Page
    {
        private Livro _livro = new Livro();
        public CadLivroFormPage()
        {
            InitializeComponent();
            
        }

        private void btnSalvarLivro_Click(object sender, RoutedEventArgs e)
        {
            _livro.CodigoLivro = txtCodLivro.Text;
            _livro.TituloLivro = txtTituloLivro.Text;
            _livro.SinopseLivro = txtSinopiseLivro.Text;
            _livro.LocalizaoLivro = txtLocalLivro.Text;
            _livro.DataPublicacaoLivro = dtpDataPubliLivro.SelectedDate;
            _livro.Edicao = txtEdicaoLivro.Text;

            try
            {
                var dao = new LivroDAO();

                dao.Insert(_livro);
                MessageBox.Show("Registro Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnInserirImg_Click(object sender, RoutedEventArgs e)
        {
            //var dao = new FuncionarioDAO();
            string saida = Directory.GetCurrentDirectory();
            string imgOriginal = saida.Substring(0, saida.Length - 9) + @"Imagens/avatar.jpg";
            // saida = saida.Substring(0, saida.Length - 9) + @"Funcionarios/" + VrsGlobais.nomeLogado + "/";

            string sourcePath = "", fileName = "";

            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == true)
            {
                sourcePath = opf.FileName;
                fileName = opf.SafeFileName;

                if (sourcePath != "")
                {

                }
            }
        }

        private void btnCancelarFun_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}
