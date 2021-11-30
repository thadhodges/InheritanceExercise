using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var bird = new Birds();
            bird.BeakLength = 4;
            bird.HasFur = false;
            bird.HasSharpTeeth = false;
            bird.HasTail = true;
            bird.NumberOfToes = 3;
            bird.NumLegs = 2;
            bird.PrimaryColor = "Blue";
            bird.Wingspan = 34;
            bird.Name = "Ipswitch";
            Console.WriteLine("Let's talk about birds...");
            Console.WriteLine($"This is a {bird.Name}\n" +
                $"and it has a mean beak length of {bird.BeakLength} cm.\n" +
                $"The {bird.Name} has {bird.NumLegs} legs, each of which have\n" +
                $"{bird.NumberOfToes} toes.\n" +
                $"It's wingspan stretchs up to {bird.Wingspan} cm on some varieties.");

            var reptile1 = new Reptile();
            reptile1.TongueLength = 5;
            reptile1.TailLength = 25;
            reptile1.ScaleColor = "Olive Green";
            reptile1.ToeLength = 3;
            reptile1.Name = "Salamander";

            Console.WriteLine("*********************************************");
            Console.WriteLine($"Our first Reptile in the collection is the {reptile1.Name}.\n" +
                $"It lives in the wetlands of the Southeastern US.  It has a {reptile1.TongueLength} cm\n" +
                $"tongue that it uses to interact with its environment.  The {reptile1.Name}\n" +
                $"has a dull {reptile1.ScaleColor} color that helps it blend into and hide from preditors.");



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
