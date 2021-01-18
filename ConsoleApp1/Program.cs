using System;

namespace Lab_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            Console.WriteLine("Welcome to The Room Calculator!");
            do
            {
                Console.Write("Please enter the width of your room: ");
                var WidthInput = Console.ReadLine();
                var InputW = double.Parse(WidthInput);

                Console.Write("Please enter the length of your room: ");
                var LengthInput = Console.ReadLine();
                var InputL = double.Parse(LengthInput);

                var ResultA = InputL * InputW;
                var ResultP = 2 * InputL + 2 * InputW;
                Console.WriteLine("The area of your room is " + ResultA + " and the perimeter of your room is " + ResultP + "\nWould you like to continue (y/n)?");
                answer = Console.ReadLine();
            } while (answer=="y");
            Console.WriteLine("Thank you for using The Room Calculator! Goodbye.");
                


        
        }
    }
}
