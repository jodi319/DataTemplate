using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.Models;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var saleitem = new List<SaleItem> {
                        new SaleItem ("Item 01", "This is a test 01 item", "R100.00", "R200.00", "Makro", "Ottery, Western Cape"),
                        new SaleItem ("Item 02", "This is a test 02 item", "R200.00", "R300.00", "PnP", "Fish Hoek, Western Cape"),
                        new SaleItem ("Item 03", "This is a test 03 item", "R300.00", "R400.00", "Builders Warehouse", "Ottery, Western Cape"),
                        new SaleItem ("Item 04", "This is a test 04 item", "R400.00", "R500.00", "Somerset West", "Ottery, Western Cape"),
                        new SaleItem ("Item 05", "This is a test 05 item", "R500.00", "R600.00", "Levi's", "V & A Waterfront, Western Cape"),
                        new SaleItem ("Item 06", "This is a test 06 item", "R600.00", "R700.00", "Levi's", "Menlyn, Pretoria")
        };

            listView.ItemsSource = saleitem;  
        }
    }
}