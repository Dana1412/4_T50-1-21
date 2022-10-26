using System;
using System.Collections.Generic;
using System.Text;

namespace practic4
{
    class Page
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Page(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void Open(DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"{Name}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"Дата: {date}");

            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.Enter) Program.Catalogs[Program.ActiveList].Open();
            else Open(date);
        }
    }
}
