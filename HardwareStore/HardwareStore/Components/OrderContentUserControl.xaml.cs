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
    /// Логика взаимодействия для OrderContentUserControl.xaml
    /// </summary>
    public partial class OrderContentUserControl : UserControl
    {
        Order order;
        public OrderContentUserControl(Order _order)
        { 
            InitializeComponent();
            order = _order;
            OrderIdTB.Text = $"номер заказа {order.id}";
            OrderDateTB.Text = $"дата заказа {order.date}";
            ContentLV.ItemsSource=App.bd.Sostav.Where(x=>x.Order_id==order.id).ToList();

        }
    }
}
