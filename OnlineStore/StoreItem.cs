using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokviumska
{
    public class StoreItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public StoreItem(string iD, string name, int price, int quantity)
        {
            ID = iD;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2} x {3} = {4}", ID, Name, Price, Quantity, Price * Quantity);
        }
    }
}
