using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product(string productName, double productPrice, int productAmount)
        {
            _name = productName;
            _price = productPrice;
            _amount = productAmount;
        }

        public string PrintProduct()
        {
            return $"{_name}, price {_price}EUR, amount {_amount}";
        }

        public int ChangeAmount(int newAmount)
        {
            _amount = newAmount;
            return _amount;
        }
        public double ChangePrice(double newPrice)
        {
            _price = newPrice;
            return _price;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Choose product");
            Console.WriteLine("1. Logitech mouse");
            Console.WriteLine("2. iPhone 5s");
            Console.WriteLine("3. Epson EB-U05");
            Console.WriteLine("4. Exit");
        }

        public static void Main()
        {
            Product firstProduct = new Product("Logitech mouse", 70.00, 14);
            Product secondProduct = new Product("iPhone 5s", 999.99, 3);
            Product thirdProduct = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(firstProduct.PrintProduct());
            Console.WriteLine(secondProduct.PrintProduct());
            Console.WriteLine(thirdProduct.PrintProduct());

            Console.WriteLine("Choose option");
            Console.WriteLine("1. Change product amount");
            Console.WriteLine("2. Change product price");
            Console.WriteLine("3. Exit");

            int input = int.Parse(Console.ReadLine());

            while (input < 0 || input > 3)
            {
                Console.WriteLine("Wrong input. Try again: ");
                input = int.Parse(Console.ReadLine());
            }

            if (input == 1)
            {
                PrintMenu();

                int inputProduct = int.Parse(Console.ReadLine());

                while (inputProduct < 1 || inputProduct > 4)
                {
                    Console.WriteLine("Wrong input. Try again: ");
                    inputProduct = int.Parse(Console.ReadLine());
                }

                if (inputProduct == 1)
                {
                    Console.WriteLine("Enter new amount of " + firstProduct._name);
                    int newAmountFirstProduct = int.Parse(Console.ReadLine());
                    firstProduct.ChangeAmount(newAmountFirstProduct);
                }
                else if (inputProduct == 2)
                {
                    Console.WriteLine("Enter new amount of " + secondProduct._name);
                    int newAmountSecondProduct = int.Parse(Console.ReadLine());
                    secondProduct.ChangeAmount(newAmountSecondProduct);
                }
                else if (inputProduct == 3)
                {
                    Console.WriteLine("Enter new amount of " + thirdProduct._name);
                    int newAmountThirdProduct = int.Parse(Console.ReadLine());
                    thirdProduct.ChangeAmount(newAmountThirdProduct);
                }
                else if (inputProduct == 4)
                {
                    Console.WriteLine("Bye!");
                }
            }
            else if (input == 2)
            {
                PrintMenu();

                int inputProduct = int.Parse(Console.ReadLine());

                while (inputProduct < 1 || inputProduct > 4)
                {
                    Console.WriteLine("Wrong input. Try again: ");
                    inputProduct = int.Parse(Console.ReadLine());
                }

                if (inputProduct == 1)
                {
                    Console.WriteLine("Enter new price of " + firstProduct._name);
                    double newPriceFirstProduct = double.Parse(Console.ReadLine());
                    firstProduct.ChangePrice(newPriceFirstProduct);
                }
                else if (inputProduct == 2)
                {
                    Console.WriteLine("Enter new price of " + secondProduct._name);
                    double newPriceSecondProduct = double.Parse(Console.ReadLine());
                    secondProduct.ChangePrice(newPriceSecondProduct);
                }
                else if (inputProduct == 3)
                {
                    Console.WriteLine("Enter new price of " + thirdProduct._name);
                    double newPriceThirdProduct = double.Parse(Console.ReadLine());
                    thirdProduct.ChangePrice(newPriceThirdProduct);
                }
                else if (inputProduct == 4)
                {
                    Console.WriteLine("Bye!");
                }

            }
            else if (input == 3)
            {
                Console.WriteLine("Bye!");
            }

            Console.WriteLine("Your new store: ");

            Console.WriteLine(firstProduct.PrintProduct());
            Console.WriteLine(secondProduct.PrintProduct());
            Console.WriteLine(thirdProduct.PrintProduct());
            Console.ReadKey();
        }
    }
}