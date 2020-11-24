using System;

namespace ConsoleApp1.Lab2
{
    public class GadgetzanCoTest
    {
        public static void Main(string[] args)
        {
            GadgetzanCo gadgetzanCo = new GadgetzanCo();
            Console.WriteLine("Default:\n ");
            gadgetzanCo.DisplayCost();
            
            //Getting information from the user
            int productNum;
            Console.Write("\nProduct Number: ");
            productNum = Convert.ToInt32(Console.ReadLine());
            gadgetzanCo.ProductNum = productNum;
            
            string productName;
            Console.Write("Product Name: ");
            productName = Console.ReadLine();
            gadgetzanCo.ProductName = productName;
            
            int quantity;
            Console.Write("Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            gadgetzanCo.Quantity = quantity;
            
            double unitPrice;
            Console.Write("Unit Price: ");
            unitPrice = Convert.ToDouble(Console.ReadLine());
            gadgetzanCo.UnitPrice = unitPrice;
            
            Console.WriteLine("\nExecuting Information...\n");
            gadgetzanCo.DisplayCost();


        }
    }
}