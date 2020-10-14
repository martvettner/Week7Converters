using System;
using System.Security.Cryptography.X509Certificates;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want convert celcius into farenheit type A");
            Console.WriteLine("If you want convert farenheit into celcius type B");
            string UserChoise = Console.ReadLine().ToLower();

            if(UserChoise == "a")
            {
                FarenheitCal();
            }
            else if (UserChoise == "b")
            {
                CelciusCal();
            }
            else
            {
                Console.WriteLine("sa oled loll");
            }
        }
        public static void FarenheitCal()
        {
            Console.WriteLine("Enter celcius: ");
            double UserInput = Int32.Parse(Console.ReadLine());
            double celResult = (UserInput * 9) / 5 + 32;
            Console.WriteLine($"{UserInput} in celcius is {celResult} farenheith");
        }
        public static void CelciusCal()
        {
            Console.WriteLine("Enter farenheit: ");
            double userInput = Double.Parse(Console.ReadLine());
            double farResult = (userInput - 32) * 5 / 9;
            Console.WriteLine($"{userInput} in farenheit is {farResult} celcius");
        }
        
    }
}
