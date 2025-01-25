/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Categorizer
    {
        //Add inventory items here after they are created
        public static List<InventoryItem> InventoryItems { get; private set; } = [];

        public static void Creator(ProductTypes productType, String brand, String title, int quantityOnHand, float price, List<String> miscAttributes)
        {
            //TODO: Create new objects based on the productType and store them in the InventoryItems list
            // Use a switch to call the correct constructor and then create the items based on the parameters

            switch(productType)
            {
                case ProductTypes.Laptop:
                    InventoryItems.Add(new Laptop(productType, brand, title, quantityOnHand, price, miscAttributes[0], miscAttributes[1], miscAttributes[2], miscAttributes[3], miscAttributes[4]));
                    break;
                case ProductTypes.Smartphone:
                    InventoryItems.Add(new Smartphone(productType, brand, title, quantityOnHand, price, miscAttributes[0], miscAttributes[1], miscAttributes[2], miscAttributes[3], miscAttributes[4]));
                    break;
                case ProductTypes.RoboticVacuum:
                    InventoryItems.Add(new RoboticVacuum(productType, brand, title, quantityOnHand, price, miscAttributes[0], miscAttributes[1], miscAttributes[2], miscAttributes[3]));
                    break;
                case ProductTypes.Camera:
                    InventoryItems.Add(new Camera(productType, brand, title, quantityOnHand, price, miscAttributes[0], miscAttributes[1], miscAttributes[2]));
                    break;
                default:
                    InventoryItems.Add(new AirFryer(productType, brand, title, quantityOnHand, price, miscAttributes[0], miscAttributes[1], miscAttributes[2]));
                    break;
            }
        }
    }
}
