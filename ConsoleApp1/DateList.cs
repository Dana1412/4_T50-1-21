using System;
using System.Collections.Generic;
using System.Text;

namespace practic4
{
    class DateList
    {
        public DateTime Date { get; set; }
        public List<Page> Pages { get; set; }
        public int ActiveList { get; set; } = 0;

        public DateList(DateTime date, List<Page> pages)
        {
            Date = date;
            Pages = pages;
        }
        public void Open()
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата: {Date}");
            for (int i = 0; i < Pages.Count; i++) Console.WriteLine($"  {i + 1}. {Pages[i].Name}");
            Program.setCursor(1, ActiveList);

            ConsoleKeyInfo button = Console.ReadKey();
            Program.setBind(button.Key, Pages.Count-1, ActiveList);
            if (button.Key == ConsoleKey.Enter) Pages[ActiveList].Open(Date);
            else Program.Catalogs[Program.ActiveList].Open();
        }
    }
}
