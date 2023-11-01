using HardwareStore.Components;
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

namespace HardwareStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrRedactPage.xaml
    /// </summary>
    public partial class AddOrRedactPage : Page
    {
        private Product product;
        public AddOrRedactPage(Product _product)
        {
            InitializeComponent();
            product = _product;
            this.DataContext = product;
        }

        private void ChangeImgBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveChangesBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
