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
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public ProductControl(string productName,double rating,int reviewCount,double price, double priceWithoutDiscount, Visibility CostVisiblity,string discount)
        {
            InitializeComponent();
            ProductNameTB.Text = productName;
            RatingTB.Text = rating.ToString(".00");
            ReviewsTB.Text = reviewCount.ToString();
            PriceTB.Text=price.ToString();
            PriceWithoutDiscountTB.Text = priceWithoutDiscount.ToString("00");
            PriceWithoutDiscountTB.Visibility=CostVisiblity;
            DiscountTB.Text = discount;
            DiscountTB.Visibility=CostVisiblity;
        }
    }
}
