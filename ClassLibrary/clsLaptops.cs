using System;

namespace ClassLibrary
{
    public class clsLaptops
    {
        // Private data members to store the laptop information
        private string mLaptopModel;             // Stores the model of the laptop
        private string mLaptopManufacturer;      // Stores the manufacturer of the laptop
        private Int32 mLaptopQuantity;             // Stores the quantity of this type of laptop in stock
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
        public Int32 LaptopQuantity
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

        public bool Find(Int32 laptopID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the laptop id to search for
            DB.AddParameter("@LaptopId", laptopID);
            //execute the stored procedure
            DB.Execute("sproc_tblLaptops_filterByLaptopID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mLaptopID = Convert.ToInt32(DB.DataTable.Rows[0]["LaptopID"]);
                mLaptopModel = Convert.ToString(DB.DataTable.Rows[0]["LaptopModel"]);
                mLaptopManufacturer = Convert.ToString(DB.DataTable.Rows[0]["LaptopManufacturer"]);
                mLaptopQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["LaptopQuantity"]);
                mLaptopPrice = Convert.ToDouble(DB.DataTable.Rows[0]["LaptopPrice"]);
                mLaptopReorder = Convert.ToBoolean(DB.DataTable.Rows[0]["LaptopReorder"]);
                mLaptopReorderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["LaptopReorderDate"]);
                //return that everything worked OK
                return true;
            } 
            //if no record found
            else
            {
                //return false indicating there was a problem
                return false;
            }
            
        }
    }

}