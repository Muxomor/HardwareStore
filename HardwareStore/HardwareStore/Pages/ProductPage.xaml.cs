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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            var products = App.bd.Product.ToList();
            var review = App.bd.Feedback.ToList();
            
            foreach(var item in products)
            {
                ProductsWP.Children.Add(new ProductControl(item.Title,item.Feedback.Select(x=>x.Evaluation).Average(),item.Feedback.Count, Convert.ToDouble(item.CostDiscount), Convert.ToDouble(item.Cost),item.CostVisibility,item.DiscoutPercent));
            }
            
        }
    }
}
