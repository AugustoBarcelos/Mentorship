using System;
using System.IO;
using System.Text.Json;

namespace CommissionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seller ID: ");
            string sellerId = Console.ReadLine();
            string sellerName = "";
            using (StreamReader r = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB/sellerId.json")))
            {
                string json = r.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement root = doc.RootElement;
                JsonElement sellers = root.GetProperty("sellers");
                foreach (JsonElement seller in sellers.EnumerateArray())
                {
                    if (seller.GetProperty("sellerId").GetString() == sellerId)
                    {
                        sellerName = seller.GetProperty("sellerName").GetString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Seller Id");
                    }
                }
            }

            Console.Write("Enter part ID: ");
            string partId = Console.ReadLine();
            string partName = "";
            double partPrice = 0.0;
            using (StreamReader r = new StreamReader("DB/partsPrice.json"))
            {
                string json = r.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement root = doc.RootElement;
                JsonElement parts = root.GetProperty("parts");
                foreach (JsonElement part in parts.EnumerateArray())
                {
                    if (part.GetProperty("partId").GetString() == partId)
                    {
                        partName = part.GetProperty("partName").GetString();
                        partPrice = part.GetProperty("partPrice").GetDouble();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid part Id");
                    }
                }
            }

            Console.Write("Enter quantity sold: ");
            int quantitySold = int.Parse(Console.ReadLine());

            double totalSale = partPrice * quantitySold;
            double commission = totalSale * 0.05;

            Console.WriteLine("Seller name: " + sellerName);
            Console.WriteLine("Part name: " + partName);
            Console.WriteLine("Part price: " + partPrice);
            Console.WriteLine("Quantity sold: " + quantitySold);
            Console.WriteLine("Total sale: " + totalSale);
            Console.WriteLine("Commission: " + commission);
        }
    }
}