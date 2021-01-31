using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Anthony";
            int age = 26;
            string[] hobbies = { "video games", "crying", "surfing" };
            Random rand = new Random();
            int index = rand.Next(hobbies.Length);
            Console.WriteLine($"Greetings, My name is {name}, I am {age} years old and I like {hobbies[index]}");
        }
    }
}
