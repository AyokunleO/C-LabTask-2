using System;


namespace InvoiceLabTask
{
    public class Invoice
    {
        public string Number { get; set; }
        public string Description { get; set; }

        private int itemQuantity;
        private decimal itemPrice;

        public Invoice (string number, string descr, int itemQ, decimal itemP)
        {
            Number = number;
            Description = descr;
            ItemQuantity = itemQ;
            ItemPrice = itemP;
        }
        public int ItemQuantity
        {
            get { return itemQuantity; }
            private set 
            { 
                if(value > 0){
                itemQuantity = value; 
                }
               
            }
        }

        public decimal ItemPrice
        {
            get { return itemPrice; }
            private set 
            { 
                if(value > 0){
                itemPrice = value; 
                }

            }
        }

        public decimal GetInvoiceAmount()
        {
            return Convert.ToDecimal(ItemQuantity) * Convert.ToDecimal(ItemPrice);
        }
        
    }
}