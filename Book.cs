using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSA.OOP.LibraryManagementSystem
{
    internal class Book:LibraryItem
    {
        internal string Author { get; set; }
        internal string Category { get; set; }
        internal int Pages { get; set; }

        internal Book(int id, string name, string author, string category, string location, int pages)
            : base(id, name, location)
        {
            Author = author;
            Category = category;
            Pages = pages;
        }

        public override void DisplayDetails()
        {
            var panel = new Panel(new Markup($"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]") +
                                  $"\n[bold]Pages:[/] {Pages}" +
                                  $"\n[bold]Category:[/] [green]{Category}[/]" +
                                  $"\n[bold]Location:[/] [blue]{Location}[/]")
            {
                Border = BoxBorder.Rounded
            };

            AnsiConsole.Write(panel);
        }

        //string Name;
        //int Pages;

        //public string Name { get; set; } = "Unknown";
        //public int Pages { get; set; } = 0;

        //internal Book()
        //{
        //    Name = "Unknown";
        //    Pages = 0;
        //    Console.WriteLine($"Name: {Name}, Pages = {Pages}");
        //}

        //internal Book(int pages)
        //{
        //    Name = "Unknown";
        //    Pages = pages;
        //    Console.WriteLine($"Name: {Name}, Pages = {Pages}");
        //}

        //internal Book(string name, int pages)
        //{
        //    Name = name;
        //    Pages = pages;
        //    Console.WriteLine($"Name: {Name}, Pages = {Pages}");
        //}
    }
}
