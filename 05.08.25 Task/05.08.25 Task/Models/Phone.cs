using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _05._08._25_Task.Models
{
    internal class Phone : Product
    {
        private int _ram;
        public int Ram
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    _ram = value;
                }

            }
            get
            {
                return _ram;
            }
        }

      private string _color;
        public string Color
        {
            set
            {
                if (value != "")
                {
                    _color = value;
                }
            }
            get
            {
                return _color;
            }
        }





        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Balance cannot be negative.");
                    Console.ResetColor();
                }
            }
        }

        public Phone(string brandName, string model, double cost, double price, int count, int ram) : base(brandName, model, cost, price, count)
        {

            _ram = ram;
            _color = "Black";
        }


        public Phone(string brandName, string model, string colour, double cost, double price, int count, int ram) : this(brandName, model, cost, price, count, ram)
        {
            _color = colour;
        }

        // Methods
        public void AddBalance(double money)
        {
            if (money > 0)
            {
                _balance += money;
                Console.WriteLine($"Balance added: {_balance}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Balance must be greater than zero.");
                Console.ResetColor();
            }
        }

        public void Call(int seconds)
        {
            seconds /= 10;

            if (_balance >= seconds)
            {
                _balance -= seconds;
                Console.WriteLine($"Zeng edildi. balans = {_balance}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur.");
                Console.ResetColor();
            }

       
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {BrandName}, Model: {Model}, Cost: {Cost}, Price: {Price}, Income {Income}, Count: {Count}, Ram {Ram} , Colour {Color}, balance {Balance}");

        }
    }
}
