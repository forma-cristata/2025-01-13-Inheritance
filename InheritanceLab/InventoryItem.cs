using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public abstract class InventoryItem
    {
        //TODO: The other common properties go here!
        public ProductTypes ProductType { get; private set; }
        public String Brand { get; private set; }
        public String Title { get; private set; }
        public int QuantityOnHand { get; private set; } 
        public float Price { get; }//Can only be assigned to in a constructor in this class

        public InventoryItem(ProductTypes productType, String brand, String title, int quantityOnHand, float price)
        {
            ProductType = productType;
            Brand = brand;
            Title = title;
            QuantityOnHand = quantityOnHand;
            Price = price;
        }

        public virtual void DisplayItem()
        {
            //TODO: Implement the DisplayItem method
            Console.WriteLine($"Product Type: {ProductType}, Brand: {Brand}, Title: {Title}, Quantity on Hand: {QuantityOnHand}, Price {Price}");
                               
        }
    }
}
