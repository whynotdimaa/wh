using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int price = 8;
        string productName = "Чай";

        Console.WriteLine("Продукт: " + productName);
        Console.WriteLine("Ціна: " + price + " грн");
    }
}
