﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

namespace System_Biblioteca.Views.Pages
{
    /// <summary>
    /// Interação lógica para GenLeitorFormPage.xam
    /// </summary>
    public partial class GenLeitorFormPage : Page
    {
        public GenLeitorFormPage()
        {
            InitializeComponent();
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

        private void btnListaLeitor_Click(object sender, RoutedEventArgs e)
        {
            ListLeitorFormWindow view = new ListLeitorFormWindow();
            view.ShowDialog();
        }
    }
}
