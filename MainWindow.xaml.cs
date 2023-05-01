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
using System_Biblioteca.Views;

namespace System_Biblioteca
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadFuncionario view = new CadFuncionario();
            view.ShowDialog();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            SideNavBarFormWindow view = new SideNavBarFormWindow();
            view.ShowDialog();
        }
    }
}
