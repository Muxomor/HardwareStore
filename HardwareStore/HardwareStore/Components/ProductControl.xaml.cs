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
        Product product;
        public ProductControl(Product _product)
        {
            product = _product;
            InitializeComponent();
            ProductNameTB.Text = product.Title;
            RatingTB.Text = product.ProductRating.ToString(".00");
            ReviewsTB.Text = product.ReviewCount.ToString();
            PriceTB.Text=product.CostDiscount.ToString();
            PriceWithoutDiscountTB.Text = product.Cost.ToString("00");
            PriceWithoutDiscountTB.Visibility=product.CostVisibility;
            DiscountTB.Text = product.DiscoutPercent;
            DiscountTB.Visibility=product.CostVisibility;
        }
    }
}
