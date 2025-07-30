using System;

class Customer
{
    public int customer_no;
    public string name;
    public string address;
    public int itemno;
    public int quantity;
    public double price;

    public double TotalPrice()
    {
        return quantity * price;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of customers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Customer[] customers = new Customer[n];
        double grandTotal = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Customer {i + 1}:");
            customers[i] = new Customer();

            Console.Write("Customer No: ");
            customers[i].customer_no = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            customers[i].name = Console.ReadLine();

            Console.Write("Address: ");
            customers[i].address = Console.ReadLine();

            Console.Write("Item No: ");
            customers[i].itemno = int.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            customers[i].quantity = int.Parse(Console.ReadLine());

            Console.Write("Price per item: ");
            customers[i].price = double.Parse(Console.ReadLine());

            grandTotal += customers[i].TotalPrice();
        }

        // Display details
        Console.WriteLine("\n--- Customer Details ---");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nCustomer {i + 1} Details:");
            Console.WriteLine($"Customer No: {customers[i].customer_no}");
            Console.WriteLine($"Name       : {customers[i].name}");
            Console.WriteLine($"Address    : {customers[i].address}");
            Console.WriteLine($"Item No    : {customers[i].itemno}");
            Console.WriteLine($"Quantity   : {customers[i].quantity}");
            Console.WriteLine($"Price      : {customers[i].price}");
            Console.WriteLine($"Total Price: {customers[i].TotalPrice()}");
        }

        Console.WriteLine($"\nGrand Total Price of All Items: {grandTotal}");
        Console.ReadLine();
    }
}
