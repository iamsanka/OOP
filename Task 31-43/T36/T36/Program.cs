using System;
using System.Collections.Generic;

class InvoiceItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double Total => Price * Quantity;

    public override string ToString()
    {
        return $"{Name} {Price:C} {Quantity} pieces {Total:C} total";
    }
}

class Invoice
{
    public string Customer { get; set; }
    public List<InvoiceItem> Items { get; set; }

    public int ItemsCount => Items.Count;

    public int ItemsTogether
    {
        get
        {
            int total = 0;
            foreach (var item in Items)
            {
                total += item.Quantity;
            }
            return total;
        }
    }

    public double CountTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Total;
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an invoice and add items to it
        Invoice invoice = new Invoice
        {
            Customer = "Kirsi Kernel",
            Items = new List<InvoiceItem>
            {
                new InvoiceItem { Name = "Milk", Price = 1.75, Quantity = 1 },
                new InvoiceItem { Name = "Beer", Price = 5.25, Quantity = 1 },
                new InvoiceItem { Name = "Butter", Price = 2.50, Quantity = 2 },
            }
        };

        // Print the invoice
        PrintInvoice(invoice);
    }

    private static void PrintInvoice(Invoice invoice)
    {
        Console.WriteLine($"Customer {invoice.Customer}'s invoice:");
        Console.WriteLine("=================================");
        foreach (var item in invoice.Items)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("=================================");
        Console.WriteLine($"Total: {invoice.ItemsTogether} pieces {invoice.CountTotal():C} euros");
    }
}
