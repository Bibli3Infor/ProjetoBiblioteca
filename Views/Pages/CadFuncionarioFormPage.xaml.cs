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
using Microsoft.Win32;
using System.IO;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views.Pages
{
    /// <summary>
    /// Interação lógica para CadFuncionarioFormPage.xam
    /// </summary>
    public partial class CadFuncionarioFormPage : Page
    {
        private Funcionario _funcionario = new Funcionario();

        public CadFuncionarioFormPage()
        {
            InitializeComponent();    
        }

        private void btnSalvarFun_Click(object sender, RoutedEventArgs e)
        {
            _funcionario.NomeFuncionario = txtNome.Text;
            _funcionario.EmailFuncionario = txtEmail.Text;
            _funcionario.CpfFuncionario = txtCpf.Text;
            _funcionario.RgFuncionario = txtRg.Text;
            _funcionario.EnderecoFuncionario = txtEndereco.Text;
            _funcionario.TelefoneFuncionario = txtTelefone.Text;
            _funcionario.Turno = cmbTurnoFuncionario.Text;
            if (_funcionario.SexoFuncinario == "Feminino")
            {
                rdbtFeminino.IsChecked = true;
            }
            else
            {
                rdbtMasculino.IsChecked = true;
            }
            _funcionario.DataNascimentoFuncionario = dtpDataNascFuncionario.SelectedDate;

            try
            {
                var dao = new FuncionarioDAO();

                dao.Insert(_funcionario);
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
    }
}
