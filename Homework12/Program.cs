using System;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static Product CreateDairyProduct()
        {
            Console.Write("Mehsulun adi: ");
            string name = Console.ReadLine();

            string priceStr;
            double price;
            do
            {
                Console.Write("Price: ");
                priceStr = Console.ReadLine();
                if (!double.TryParse(priceStr, out price))
                    Console.WriteLine("Yalnis price, yeniden daxil edin\n");
            } while (!double.TryParse(priceStr, out price));

            Console.Write("FatPercent: ");
            string fatPercentStr = Console.ReadLine();
            double fatPercent = Convert.ToDouble(fatPercentStr);

            Dairy dairy = new Dairy
            {
                Name = name,
                Price = price,
                FatPercent = fatPercent
            };

            return dairy;
        }
        static Product CreateDrinkProduct()
        {
            Console.Write("Mehsulun adi: ");
            string name = Console.ReadLine();

            string priceStr;
            double price;
            do
            {
                Console.Write("Price: ");
                priceStr = Console.ReadLine();
                if (!double.TryParse(priceStr, out price))
                    Console.WriteLine("Yalnis price, yeniden daxil edin\n");
            } while (!double.TryParse(priceStr, out price));

            Console.Write("AlcoholPercent: ");
            string alcoholPercentStr = Console.ReadLine();
            double alcoholPercent = Convert.ToDouble(alcoholPercentStr);

            Drink drink = new Drink
            {
                Name = name,
                Price = price,
                AlcoholPercent = alcoholPercent
            };

            return drink;
        }
        static void ShowList()
        {
            Console.WriteLine("      ____________    ");
            Console.WriteLine("     |    MENU    |   ");
            Console.WriteLine("      ------------    ");

            Console.WriteLine("1. Drink product elave et");
            Console.WriteLine("2. Dairy product elave et");
            Console.WriteLine("3. Butun productlara bax");
            Console.WriteLine("4. Verilmish nomreli producta bax");
            Console.WriteLine("5. Drink productlara bax");
            Console.WriteLine("6. Dairy productlara bax");
            Console.WriteLine("7. Ada gore axtarish et");
            Console.WriteLine("8. Qiymet araligina gore axtarish et");
            Console.WriteLine("9. Siyahidan mehsul sil");
            Console.WriteLine("0. Cix");
        }
        static void ShowMenu()
        {
            Bravo market1 = new Bravo();            

            string option;
            do
            {
                ShowList();

                Console.WriteLine("\nSeciminizi edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var drinkPr = CreateDrinkProduct();
                        market1.AddProduct(drinkPr);
                        break;
                    case "2":
                        var dairyPr = CreateDairyProduct();
                        market1.AddProduct(dairyPr);
                        break;
                    case "3":
                        foreach (Product item in market1.Products)
                        {
                            item.ShowInfo();
                        }                       
                        break;
                    case "4":
                        Console.Write("No: ");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        try
                        {
                            var wantedProduct = market1.GetProductByNo(no);
                            wantedProduct.ShowInfo();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{no} nomreli mehsul yoxdur\n");

                        }
                        break;
                    case "5":
                        foreach (var item in market1.Products)
                        {
                            if (item is Drink)
                                item.ShowInfo();
                        }
                        break;
                    case "6":
                        foreach (var item in market1.Products)
                        {
                            if (item is Dairy)
                                item.ShowInfo();
                        }
                        break;
                    case "7":
                        Console.Write("Ad daxil edin: ");
                        string word = Console.ReadLine();
                        foreach (var item in market1.Products)
                        {
                            if (item.Name.Contains(word))
                                item.ShowInfo();
                        }
                        break;
                    case "8":
                        Console.Write("Minimum Price: ");
                        string minPriceStr = Console.ReadLine();
                        double minPrice = Convert.ToDouble(minPriceStr);
                        Console.Write("Maximum Price: ");
                        string maxPriceStr = Console.ReadLine();
                        double maxPrice = Convert.ToDouble(maxPriceStr);

                        bool hasPrice = false;
                        foreach (var item in market1.Products)
                        {
                            if (item.Price >= minPrice && item.Price <= maxPrice)
                            {
                                item.ShowInfo();
                                hasPrice = true;
                            }
                        }
                        if (!hasPrice)
                            Console.WriteLine("\nBu qiymet araliginda bir mehsul yoxdur");                       
                        break;
                    case "9":
                        Console.Write("No: ");
                        string selectedNoStr = Console.ReadLine();
                        int selectedNo = Convert.ToInt32(selectedNoStr);
                        market1.RemoveProduct(selectedNo);
                        break;
                    case "0":
                        Console.WriteLine("Program bitdi");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim, yeniden cehd edin");
                        break;
                }
            } while (option != "0");
        }
    }
}
