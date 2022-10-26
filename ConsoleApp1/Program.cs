using System;
using System.Collections.Generic;

namespace practic4
{
    class Program
    {
        public static List<DateList> Catalogs = new List<DateList>() {
            new DateList(new DateTime(2022, 7, 10), new List<Page>() {
                new Page("Прити на пары", "Описание: с 1 по 5 пару"),
                new Page("Забрать студак", "Описание: кабинет 105 с 8 до 16")
            }),
            new DateList(new DateTime(2022, 8, 10), new List<Page>() {
                new Page("Проверить практические", "Описание: Группа Т50-1-21")
            }),
            new DateList(new DateTime(2022, 9, 10), new List<Page>() {
                new Page("Забрать справку", "Описание: кабинет 109 с 8 до 16")
            })
        };
        public static int ActiveList = 0;

        static void Main(string[] args)
        {
            Catalogs[ActiveList].Open();
        }
        public static void setCursor(int start, int next)
        {
            Console.SetCursorPosition(0, start + next);
            Console.WriteLine("->");
        }
        public static void setBind(ConsoleKey button, int max, int next)
        {
            if (button == ConsoleKey.UpArrow)
            {
                if (next == 0) Catalogs[ActiveList].ActiveList = max;
                else Catalogs[ActiveList].ActiveList -= 1;
            }
            else if (button == ConsoleKey.DownArrow)
            {
                if (next == max) Catalogs[ActiveList].ActiveList = 0;
                else Catalogs[ActiveList].ActiveList += 1;
            }
            else if (button == ConsoleKey.LeftArrow)
            {
                max = Catalogs.Count - 1;
                if (ActiveList == 0) ActiveList = max;
                else ActiveList--;
            }
            else if (button == ConsoleKey.RightArrow)
            {
                max = Catalogs.Count - 1;
                if (ActiveList == max) ActiveList = 0;
                else ActiveList++;
            }
        }
    }
}
