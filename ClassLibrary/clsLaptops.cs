using System;

namespace ClassLibrary
{
    public class clsLaptops
    {
        // Private data members to store the laptop information
        private string mLaptopModel;             // Stores the model of the laptop
        private string mLaptopManufacturer;      // Stores the manufacturer of the laptop
        private int mLaptopQuantity;             // Stores the quantity of this type of laptop in stock
        private double mLaptopPrice;             // Stores the price of the laptop
        private bool mLaptopReorder;             // Indicates whether an automatic reorder is setup for this laptop type
        private DateTime mLaptopReorderDate;     // Stores the date of the next reorder for this laptop type
        private Int32 mLaptopID;                 // Stores the ID of the laptop

        // Public property to access and modify the laptop model
        public string LaptopModel
        {
            get { return mLaptopModel; }        // Getter returns the laptop model
            set { mLaptopModel = value; }       // Setter sets the laptop model
        }

        // Public property to access and modify the laptop manufacturer
        public string LaptopManufacturer
        {
            get { return mLaptopManufacturer; } // Getter returns the laptop manufacturer
            set { mLaptopManufacturer = value; }// Setter sets the laptop manufacturer
        }

        // Public property to access and modify the quantity of laptops in stock
        public int LaptopQuantity
        {
            get { return mLaptopQuantity; }     // Getter returns the laptop quantity
            set { mLaptopQuantity = value; }    // Setter sets the laptop quantity
        }

        // Public property to access and modify the price of the laptop
        public double LaptopPrice
        {
            get { return mLaptopPrice; }        // Getter returns the laptop price
            set { mLaptopPrice = value; }       // Setter sets the laptop price
        }

        // Public property to access and modify the reorder status of the laptop
        public bool LaptopReorder
        {
            get { return mLaptopReorder; }      // Getter returns the reorder status
            set { mLaptopReorder = value; }     // Setter sets the reorder status
        }

        // Public property to access and modify the date of the next reorder
        public DateTime LaptopReorderDate
        {
            get { return mLaptopReorderDate; }  // Getter returns the reorder date
            set { mLaptopReorderDate = value; } // Setter sets the reorder date
        }
  
        //addressID public property
        public Int32 LaptopID 
        {
            get { return mLaptopID; }           // Getter returns the laptops ID
            set { mLaptopID = value; }          // Setter sets the laptops ID
        }

        public bool Find(int laptopID)
        {
            mLaptopID = 1;
            mLaptopModel = "G1o45";
            mLaptopManufacturer = "Asus";
            mLaptopQuantity = 10;
            mLaptopPrice = 599.99;
            mLaptopReorder = false;
            mLaptopReorderDate = Convert.ToDateTime("17/05/2024");
            return true;
        }
    }

}