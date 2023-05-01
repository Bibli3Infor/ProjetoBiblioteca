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
using System.IO;
using Microsoft.Win32;

namespace System_Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para CadFuncionario.xaml
    /// </summary>
    public partial class CadFuncionario : Window
    {
        public CadFuncionario()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

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
            this.Close();
        }
    }
}
