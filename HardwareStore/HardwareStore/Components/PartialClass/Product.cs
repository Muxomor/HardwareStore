using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HardwareStore.Components
{
    public partial class Product
    {
        public string CostDiscount
        {
            get
            {
                if (Discount == 0)
                    return Cost.ToString();
                else
                    return (Convert.ToDouble(Cost) - (Convert.ToDouble(Cost) * Discount)).ToString();
            }
        }
        public Visibility CostVisibility
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
    }
}
