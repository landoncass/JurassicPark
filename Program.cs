using System;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
        }
    }
}
