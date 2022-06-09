using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public string DisplayDinosaur()
        {
            return $"We have a {Name} that is a {Diet} that we  {WhenAcquired}. It weighs {Weight} and is enclosure {EnclosureNumber}";
        }

    }
    class Program
    {
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }
        static void Main(string[] args)
        {

            //create a list of dinosaurs
            var dinoList = new List<Dinosaur>();

            var keepGoing = true;

            // create a menu with (V)iew (A)dd (R)emove (T)ransfer (S)ummary (Q)uit
            Console.WriteLine();
            Console.WriteLine("Welcome to the Dinosaur Park!");
            Console.WriteLine();
            while (keepGoing)
            {
                Console.WriteLine("What would you like to do?\n\n (V)iew a list of the dinosaurs\n (A)dd a dinosaur to the park\n (R)emove a dinosaur from the park\n (T)ransfer a dinosaur\n (S)ummarize the dinosaurs in the park\n (Q)uit");

                var choice = Console.ReadLine().ToUpper();
                if (choice == "Q")
                {
                    keepGoing = false;
                }
                else if (choice == "V")
                {
                    // Create View method that takes a name or enclosure number and return a list of matching dinosaurs
                    PromptForString("Would you like to view the dinosaurs in order of (N)ame or (E)nclosure number?");
                    var nameOrEnclosure = Console.ReadLine().ToUpper();
                    if (nameOrEnclosure == "N")
                    {
                        var sortedByName = dinoList.OrderBy(dino => dino.Name);
                        foreach (var name in sortedByName)
                        {
                            Console.WriteLine(name.DisplayDinosaur());
                        };
                    }
                    else if (nameOrEnclosure == "E")
                    {
                        var sortedByEnclosure = dinoList.OrderBy(dino => dino.EnclosureNumber);
                        foreach (var enclosure in sortedByEnclosure)
                        {
                            Console.WriteLine(enclosure.DisplayDinosaur());
                        };
                    }
                    else
                    {
                        Console.WriteLine("That's not an valid option.");
                        //Add something to loop this back to the beginning of if statement
                    }

                }
                else if (choice == "A")
                {
                    // Create method that asks for the values of the dinosaur and adds them to list
                    var dino = new Dinosaur();
                    dino.Name = PromptForString("What is the name of this dinosaur? ");
                    dino.Diet = PromptForString("Is the dinosaur a carnivore or herbivore?");
                    //Figure out date acquired
                    dino.Weight = PromptForInteger("What does this dinosaur weight? ");
                    dino.EnclosureNumber = PromptForInteger("Which enclosure would you like to put this dinosaur? ");
                    dinoList.Add(dino);
                }
            }
        }
    }
}

// Create a method that asks which dinosaur they want to remove, and remove from list
// Create method that asks which dinosaur they want to transfer. Then asks where they want to move it to. Change the EnclosureNumber to their selection
// Create a method that displays the number of carnivores and the number of herbivores
// Create a function that quits the program 


