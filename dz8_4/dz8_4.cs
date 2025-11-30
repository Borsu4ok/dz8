using System;

interface IPrice
{
    void SetPrice(double price);
}

interface IDiscount
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

interface IColor
{
    void SetColor(byte color);
}

interface ISize
{
    void SetSize(byte size);
}

class Book : IPrice, IDiscount
{
    public double Price { get; private set; }

    public void SetPrice(double price) => Price = price;

    public void ApplyDiscount(string discount) { }
    public void ApplyPromocode(string promocode) { }
}

class Outerwear : IPrice, IDiscount, IColor, ISize
{
    public double Price { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price) => Price = price;

    public void ApplyDiscount(string discount) { }
    public void ApplyPromocode(string promocode) { }

    public void SetColor(byte color) => Color = color;
    public void SetSize(byte size) => Size = size;
}

class Program4
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.SetPrice(200);
        book.ApplyDiscount("10%");

        Outerwear jacket = new Outerwear();
        jacket.SetPrice(1500);
        jacket.SetColor(5);
        jacket.SetSize(48);

        Console.WriteLine("Book price: " + book.Price);
        Console.WriteLine("Jacket price: " + jacket.Price);
    }
}
