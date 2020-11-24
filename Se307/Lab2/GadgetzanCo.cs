using System;

namespace ConsoleApp1.Lab2
{
    public class GadgetzanCo
    {
        private int productNum, quantity;
        private string productName;
        private double unitPrice;

        public int ProductNum
        {
            get => productNum;
            set => productNum = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public double UnitPrice
        {
            get => unitPrice;
            set => unitPrice = value;
        }

        public GadgetzanCo()
        {
            productNum = 1000;
            quantity = 0;
            productName = "item";
            unitPrice = 0;
        }
        
        // calculating cost method

        public double CalculateCost()
        {
            return quantity * unitPrice;
        }

        public void DisplayCost()
        {
            Console.WriteLine("Product Number: " +productNum);
            Console.WriteLine("Product Name: "+ productName);
            Console.WriteLine("Unit Price: " +unitPrice);
            Console.WriteLine("Quantity: " +quantity);
            Console.WriteLine("Total Cost: " +CalculateCost());
        }
    }
}