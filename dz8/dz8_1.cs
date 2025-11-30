using System;
using System.Collections.Generic;

class Item { }

class Order
{
    private List<Item> items = new List<Item>();

    public IReadOnlyList<Item> Items => items;

    public void AddItem(Item item) => items.Add(item);
    public void DeleteItem(Item item) => items.Remove(item);

    public decimal CalculateTotalSum()
    {
        return items.Count * 10; 
    }
}


class OrderRepository
{
    public void Load(Order order) {  }
    public void Save(Order order) {  }
}

class OrderPrinter
{
    public void Print(Order order)
    {
        Console.WriteLine("Items: " + order.Items.Count);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.AddItem(new Item());
        order.AddItem(new Item());

        OrderPrinter printer = new OrderPrinter();
        printer.Print(order);

        Console.WriteLine("Total sum = " + order.CalculateTotalSum());
    }
}
