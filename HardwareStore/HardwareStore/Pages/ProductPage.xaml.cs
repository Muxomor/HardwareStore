﻿using HardwareStore.Components;
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
            
            Refresh();
            
        }
        private void Refresh()
        {
            IEnumerable<Product> products = App.bd.Product;
            if(CostSortCB.SelectedIndex!=0)
            {
                if (CostSortCB.SelectedIndex == 1)
                    products = products.OrderBy(x => x.TotalCost);
                else if (CostSortCB.SelectedIndex == 2)
                    products = products.OrderByDescending(x => x.TotalCost);
               
            }
            if(ReviewSortCB.SelectedIndex!=0)
            {
                if (ReviewSortCB.SelectedIndex == 1)
                    products = products.OrderByDescending(x => x.ProductRating);
                else if (ReviewSortCB.SelectedIndex == 2)
                    products= products.OrderBy(x => x.ReviewCount);
            }
            if(SearchTB.Text!="")
            {
                products = products.Where(x => x.Title.ToLower().Contains(SearchTB.Text.ToLower()) || x.Description.Contains(SearchTB.Text.ToLower()));
            }
                ProductsWP.Children.Clear();
                foreach (var item in products)
                {
                    ProductsWP.Children.Add(new ProductControl(item));
                }
            
        }

        private void CostSortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void ReviewSortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        
    }
}
