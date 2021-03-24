using System;

namespace InvoiceLabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("24", "Perfect Condition", 5, 100m);

            Console.WriteLine($"Number:{invoice.Number}\n Description: {invoice.Description}\n Item Quantity:{invoice.ItemQuantity}\n Item Price: {invoice.ItemPrice}\n Invoice Amount: {invoice.GetInvoiceAmount()}");
        }
    }
}
