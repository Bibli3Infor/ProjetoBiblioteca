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
    /// Interação lógica para CadLeitorFormPage.xam
    /// </summary>
    public partial class CadLeitorFormPage : Page
    {

        private Leitor _leitor = new Leitor();
        public CadLeitorFormPage()
        {
            InitializeComponent();
        }

        private void btnCancelarFun_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnSalvarLeitor_Click(object sender, RoutedEventArgs e)
        {
            _leitor.CodigoAcesso = txtCodAcessLei.Text;
            _leitor.NomeLeitor = txtNomeLei.Text;
            _leitor.EmailLeitor = txtEmailLei.Text;
            _leitor.Endereco = txtEnderecoLei.Text;
            _leitor.CpfLeitor = txtCpfLei.Text;
            _leitor.RgLeitor = txtRgLei.Text;
            _leitor.TelefoneLeitor = txtTelefoneLei.Text;
            if (_leitor.SexoLeitor == "Feminino")
            {
                rdbtFemininoLei.IsChecked = true;
            }
            else
            {
                rdbtMasculinoLei.IsChecked = true;
            }
            _leitor.DataNascimentoLeitor = dtpDataNascLei.SelectedDate;

            try
            {
                var dao = new LeitorDAO();

                dao.Insert(_leitor);
                MessageBox.Show("Registro Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
