using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Laptop : InventoryItem
    { 
        //TODO: Finish this class. Hint: it needs a constructor and its unique properties.
        // Screen resolution
        public String ScreenResolution { get; set; }
        // Screen size
        public String ScreenSize { get; set; }
        // Storage size
        public String StorageSize { get; set; }
        // RAM size
        public String RAMSize { get; set; }
        // CPU
        public String CPU { get; set; }

        public Laptop(ProductTypes productType, String brand, String title, int quantityOnHand, float price, 
            String screenResolution, String screenSize, String storageSize, String ramSize, String cpu) : base(productType, brand, title, quantityOnHand, price)
        {
            ScreenResolution = screenResolution;
            ScreenSize = screenSize;
            StorageSize = storageSize;
            RAMSize = ramSize;
            CPU = cpu;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.Write($", Screen Resolution: {ScreenResolution}, Screen Size: {ScreenSize}, Storage Size {StorageSize}, RAM Size {RAMSize}, CPU {CPU}.");
        }
    }

    public class Smartphone : InventoryItem
    {
        // Screen resolution
        public String ScreenResolution { get; set; }
        // Storage size
        public String StorageSize { get; set; }
        // RAM size
        public String RAMSize { get; set; }
        // CPU
        public String CPU { get; set; }
        // Camera resolution
        public String CameraResolution { get; set; }

        public Smartphone(ProductTypes productType, String brand, String title, int quantityOnHand, float price, 
            String screenResolution, String storageSize, String rAMSize, String cPU, String cameraResolution) : base(productType, brand, title, quantityOnHand, price)
        {
            ScreenResolution = screenResolution;
            StorageSize = storageSize;
            RAMSize = rAMSize;
            CPU = cPU;
            CameraResolution = cameraResolution;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.Write($", Screen Resolution: {ScreenResolution}, Storage Size: {StorageSize}. RAM Size: {RAMSize}, CPU: {CPU}, Camera Resolution: {CameraResolution}.");
        }
    }

    public class RoboticVacuum : InventoryItem
    {
        // Cleaning path width
        public String CleaningPathWidth { get; set; }
        // Bagless (yes or no)
        public String Bagless { get; set; }
        // Color
        public String ?Color { get; set; }
        // Weight
        public String Weight { get; set; }

        public RoboticVacuum(ProductTypes productType, String brand, String title, int quantityOnHand, float price, 
            String cleaningPathWidth, String bagless, String ?color, String weight) : base(productType, brand, title, quantityOnHand, price)
        {
            CleaningPathWidth = cleaningPathWidth;
            Bagless = bagless;
            Color = color;
            Weight = weight;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.Write($", Cleaning Path Width: {CleaningPathWidth}, Bagless {Bagless}, Color {Color}, Weight {Weight}.");
        }
    }

    public class Camera : InventoryItem
    {
        // Image sensor type
        public String ImageSensorType { get; set; }
        // Effective pixels
        public String EffectivePixels { get; set; }
        // Video resolution
        public String VideoResolution { get; set; }

        public Camera(ProductTypes productType, String brand, String title, int quantityOnHand, float price, 
            String imageSensorType, String effectivePixels, String videoResolution) : base(productType, brand, title, quantityOnHand, price)
        {
            ImageSensorType = imageSensorType;
            EffectivePixels = effectivePixels;
            VideoResolution = videoResolution;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.Write($"Image Sensor Type: {ImageSensorType}, Effective Pixels {EffectivePixels}, Video Resolution {VideoResolution}.");
        }
    }

    public class AirFryer: InventoryItem
    {
        // Non-stick interior (yes or no)
        public String NonStickInterior { get; set; }
        // Color
        public String Color { get; set; }
        // Functions
        public String Functions { get; set; }

        public AirFryer(ProductTypes productType, String brand, String title, int quantityOnHand, float price, 
            String nonStickInterior, String color, String functions) : base(productType, brand, title, quantityOnHand, price)
        {
            NonStickInterior = nonStickInterior;
            Color = color;
            Functions = functions;
        }

        public override void DisplayItem()
        {
            base.DisplayItem();
            Console.Write($", NonStickInterior: {NonStickInterior}, Color: {Color}, Functions {Functions}.");
        }
    }
}
