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

namespace Restaurant
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        double bill;
        public Page3()
        {
            InitializeComponent();
            if (Page1.plate)
            {
                bill = (20 + (20 * (5 / 100)) + (20 * (10 / 100)));
                billTextBlock.Text +=" In Dollars $"+ bill.ToString();
                bill = bill * 1500;
                billTextBlock.Text += " In Lebanese : " + bill.ToString() + " L.L.";
            }
            else
            {
                bill = (10 + (10 * (5 / 100)) + (10 * (10 / 100)));
                billTextBlock.Text +=" In Dollars: $" + bill.ToString();
                bill = bill * 1500;
                billTextBlock.Text += " In Lebanese : " + bill.ToString()+" L.L.";
            }
            

        }
    }
}
