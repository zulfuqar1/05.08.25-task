using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._08._25_Task.Models
{
    internal class Product
    {

        private string _brandName;
        public string BrandName
        {
            get { return _brandName; }
            set
            {
                if (value != "" || value != " ")
                {
                    value = value.Trim();
                    _brandName = value;
                }
                else
                {
                    throw new ArgumentException("Brand name cannot be empty or null.");
                }
            }
        }


        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (value != "" || value != " ")
                {
                    value = value.Trim();
                    _model = value;
                }
                else
                {
                    throw new ArgumentException("Model cannot be empty or null.");
                }
            }
        }

        private double _cost;
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentException("Cost must be greater than zero.");
                }
            }
        }
        
        private double _price;
        public double Price
        {
            get { return _price; }
            set 
            { 
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be greater than zero.");
                }
            }
        }
        
        private double _income;
        public double Income
        {
            get { return _income; }
            set 
            { 
                if (value >= 0)
                {
                    _income = value;
                }
                else
                {
                    throw new ArgumentException("Income cannot be negative.");
                }
            }
        }
        


        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
                else
                {
                    throw new ArgumentException("Count cannot be negative.");
                }
            }
        }




        //Constructor 
        public Product(string brandName, string model, double cost, double price, int count)
        {
            BrandName = brandName;

            Model = model;

            Cost = cost;

            Price = price;

            if (count < 0)
            {
                count = 0;
            }



            Count = count;
        }
        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {BrandName}, Model: {Model}, Cost: {Cost}, Price: {Price}, Income {Income}, Count: {Count}");
        }





        public void Sale(int SaleCount)
        {
            if (Count > SaleCount)
            {
                Count = Count - SaleCount;

                Income = SaleCount * (Price - Cost);


                Console.WriteLine($"Product sold. Remaining count: {Count}, Total income: {Income}");
            }
            else if (Count < SaleCount && Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("We do not have the number of products at the given value.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"insufficient number of products = {SaleCount - Count}");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product is out of stock.");
                Console.ResetColor();
            }
        }


        public void Refill(int addedProductCount)
        {
            Count += addedProductCount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{addedProductCount}:items added");
            Console.ResetColor();
            Console.WriteLine($"Product count {Count}");
        }

        //Optional

        public void GetProfit()
        {
            if (Income > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Total profit: {Income}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("No profit yet.");
            }
        }
    }
}
