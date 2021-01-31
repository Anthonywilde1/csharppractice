using System;


    public class Person
    {
        public Person()
        {
            Name = "unknown";
            Age = 0;
        }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get;set; }
        public int Age { get;set; }

        public override string ToString()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1");
            var person1 = new Person();
            Console.WriteLine($"{person1.Name}, {person1.Age}");
            Console.WriteLine("Person 2");
            var person2 = new Person("Jeff", 21);
            Console.WriteLine($"{person2.Name}, {person2.Age}");
            Console.WriteLine("Please write a name in the field below");
            string personname = Console.ReadLine();
            Console.WriteLine("and an age please");
            int personage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Person 3 is named {personname} and is {personage} years old");
        }
    }

