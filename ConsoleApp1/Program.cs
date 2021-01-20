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
                Console.WriteLine("The area of your room is " + ResultA + " and the perimeter of your room is " + ResultP + "\nWould you also like to know the volume of your room (y/n)?");
                answer = Console.ReadLine();
               

                if (answer == "y")
                {
                    Console.Write("Please enter the height of your room: ");
                    var HeightInput = Console.ReadLine();
                    var InputH = double.Parse(HeightInput);

                    var ResultV = InputL * InputW * InputH;

                    Console.WriteLine("The volume of your room is " + ResultV + "\nWould you like to continue using the room calculator(y/n)?");
                    answer = Console.ReadLine();

                    while (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Invalid Input. Please enter 'y' or 'n.'\nWould you like to continue (y/n)?");
                        answer = Console.ReadLine();
                    }
                }

                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Invalid Input. Please enter 'y' or 'n.'\nWould you like to continue (y/n)?");
                    answer = Console.ReadLine();
                }

            } while (answer=="y");
            Console.WriteLine("Thank you for using The Room Calculator! Goodbye.");
             
        
        }
    }
}
