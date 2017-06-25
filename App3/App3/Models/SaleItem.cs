using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Models
{
    class SaleItem
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Price { get; private set; }

        public string OldPrice { get; private set; }

        public string Seller { get; private set; }

        public string Location { get; private set; }

        public SaleItem(string title, string description, string price, string oldprice, string seller, string location)
        {
            Title = title;
            Description = description;
            Price = Price;
            OldPrice = OldPrice;
            Seller = Seller;
            Location = location;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
