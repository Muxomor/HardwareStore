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

namespace HardwareStore.Components
{
    /// <summary>
    /// Логика взаимодействия для CardProductsControl.xaml
    /// </summary>
    public partial class CardProductsControl : UserControl
    {
        Product product;
        public CardProductsControl(Product _product)
        {
            InitializeComponent();
            this.DataContext = _product;
        }
    }
}
