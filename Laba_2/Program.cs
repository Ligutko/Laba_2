using System;

namespace Laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  завдання
            Console.WriteLine("Task First");
            Console.Write("Enter value x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = 1.5;
            double y;

            if (x < 1.3)
            {
                y = Math.PI * Math.Pow(x, 2) - 7 / Math.Pow(x, 2);
            }
            else if (x == 1.3)
            {
                y = a * Math.Pow(x, 3) + 7 / Math.Sqrt(x);
            }
            else
            {
                y = Math.Tan(x + 7 * Math.Sqrt(x));
            }

            Console.WriteLine("Result y: " + y);

            // Друге завдання
            Console.WriteLine("Task Second");
            Console.Write("Enter the purchase price (грн): ");
            decimal purchaseAmount = decimal.Parse(Console.ReadLine());

            decimal discount = 0;

            if (purchaseAmount > 1000)
            {
                discount = 0.05m; 
            }
            else if (purchaseAmount > 500)
            {
                discount = 0.03m; 
            }

            decimal discountAmount = purchaseAmount * discount;
            decimal finalAmount = purchaseAmount - discountAmount;

            Console.WriteLine($"Знижка: {discount * 100}%");
            Console.WriteLine($"Сума знижки: {discountAmount} грн");
            Console.WriteLine($"Підсумкова вартість: {finalAmount} грн");

            // Третє завдання
            Console.WriteLine("Task Third");
            Console.Write("Enter the height h, dropped to the hypotenuse: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose what to calculate for the triangle:");
            Console.WriteLine("1 - Length of the hypotenuse (c)");
            Console.WriteLine("2 - Length of the leg (a)");
            Console.WriteLine("3 - Area of the triangle (S)");

            int choice = Convert.ToInt32(Console.ReadLine());

            double result;

            switch (choice)
            {
                case 1:
                    result = h * Math.Sqrt(2); 
                    Console.WriteLine($"Length of the hypotenuse: {result}");
                    break;

                case 2:
                    result = (h * Math.Sqrt(2)) / 2; 
                    Console.WriteLine($"Length of the leg: {result}");
                    break;

                case 3:
                    result = (Math.Pow(h, 2)) / 2; 
                    Console.WriteLine($"Area of the triangle: {result}");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}