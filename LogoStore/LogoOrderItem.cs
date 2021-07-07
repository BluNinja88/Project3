using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoStore
{
    class LogoOrderItem
    {
        //Variable and Array Declerations & Intializations

        // Has Logo
        private bool HasLogo;
        public bool GetHasLogo()
        {
            return HasLogo;
        }
        public void SetHasLogo(bool hasLogo)
        {
            this.HasLogo = hasLogo;
            Calc();
        }

        //Item Type
        private string ItemType;
        public string GetItemType()
        {
            return ItemType;
        }
        public void SetItemType(string itemType)
        {
            this.ItemType = itemType;
            Calc();
        }

        //Number of Colors for Logo
        private int NumColors;
        public int GetNumColors()
        {
            return NumColors;
        }
        public void SetNumColors(int numColors)
        {
            this.NumColors = numColors;
            Calc();
        }

        //Number of Items
        private int NumItems;
        public int GetNumItems()
        {
            return NumItems;
        }
        public void SetNumItems(int numItems)
        {
            this.NumItems = numItems;
            Calc();
        }

        //Engraved text to print
        private string Text;
        public string GetText()
        {
            return Text;
        }
        public void SetText(string text)
        {
            this.Text = text;
            Calc();
        }

        //Total price for items
        private readonly decimal TotalPrice;
        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }

        public int ItemID { get; set; }

        // Constructors

        //Default Constructor
        public LogoOrderItem()
            : this(-1, false, "Mug", 0, 0, "")
        {
        }

        //Constructor for Order with only logo and text
        public LogoOrderItem(bool hasLogo, string text)
        : this(-1, hasLogo, "Mug", 0, 0, text)
        {
        }

        //Constructor for Order with all items
        public LogoOrderItem(int id, bool hasLogo, string itemType, int numColors, 
            int numItems, string text)
        {
            this.ItemID = id;
            this.HasLogo = hasLogo;
            this.ItemType = itemType;
            this.NumColors = numColors;
            this.NumItems = numItems;
            this.Text = text;
        }

        //Calculation Method
        private void Calc()
        {
            decimal engraveText = 0.05M * NumItems;
            decimal hasLogo = 0.10M * NumItems;
            decimal hasColor = 0.03M * NumColors;
        }

        //Get Order Summary
        public string GetOrderSummary()
        {
            //Variable Decleration
            int id = ItemID;
            string itemType = ItemType;
            int numItems = NumItems;
            bool hasLogo = HasLogo;
            int numColors = NumColors;
            string text = Text;
            decimal totalPrice = TotalPrice;

            //Display Order results
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("--------------");
            Console.WriteLine("Order Number: " + id);
            Console.WriteLine("Item Type: " + itemType);
            Console.WriteLine("Number of Items: " + numItems);
            Console.WriteLine("Logo: " + hasLogo);
            Console.WriteLine("Number of Colors: " + numColors);
            Console.WriteLine("Engraved Text: " + text);
            Console.WriteLine("________________________________");
            Console.WriteLine("Total Price: $" + totalPrice);
        }
    }
}
