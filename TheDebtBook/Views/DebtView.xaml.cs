using TheDebtBook.ViewModels;
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

namespace TheDebtBook.Views
{
    /// <summary>
    /// Interaction logic for DebtView.xaml
    /// </summary>
    public partial class DebtView : Window
    {
        public DebtView()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as DebtViewModel;
            if (vm.IsValid)
                DialogResult = true;
        }

    }
}
