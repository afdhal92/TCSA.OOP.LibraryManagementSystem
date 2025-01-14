using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TCSA.OOP.LibraryManagementSystem.Enums;

namespace TCSA.OOP.LibraryManagementSystem
{
    internal class UserInterface
    {
        private BooksController booksController = new BooksController();
        internal  void MainMenu()
        {
            while (true)
            {
                Console.Clear();

                var books = new List<string>()
                {
                    "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", "Catch-22", "The Hitchhiker's Guide to the Galaxy"
                };

                var choice = AnsiConsole.Prompt(
                        new SelectionPrompt<MenuOption>()
                        .Title("What do you want to do next?")
                        .AddChoices(Enum.GetValues<MenuOption>()));

                switch (choice)
                {
                    case MenuOption.AddBook:
                        booksController.AddBooks();
                       
                        break;
                    case MenuOption.ViewBooks:
                        booksController.ViewBooks();
                        break;
                    case MenuOption.DeleteBook:
                        booksController.DeleteBooks();
                        break;
                }

                //void ViewBooks()
                //{
                //    AnsiConsole.MarkupLine("[yellow]List of Books:[/]");

                //    foreach (var book in books)
                //    {
                //        AnsiConsole.MarkupLine($"- [cyan]{book}[/]");
                //    }

                //    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                //    Console.ReadKey();
                //}

                //void AddBooks()
                //{
                //    AnsiConsole.MarkupLine("[yellow]List of Books:[/]");

                //    // Printing each book to the console with a loop
                //    foreach (var book in books)
                //    {
                //        AnsiConsole.MarkupLine($"- [cyan]{book}[/]");
                //    }

                //    /* Having the user press a key before continuing, or the menu
                //     wouldn't be visualisable */
                //    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                //    Console.ReadKey();
                //}

                //void DeletBooks()
                //{
                //    if (books.Count == 0)
                //    {
                //        AnsiConsole.MarkupLine("[red]No books available to delete.[/]");
                //        Console.ReadKey();
                //        return;
                //    }

                //    /* showing a list of books and letting the user choose with arrows 
                //     using SelectionPrompt, similarly to what we do with the menu */
                //    var bookToDelete = AnsiConsole.Prompt(
                //        new SelectionPrompt<string>()
                //        .Title("Select a [red]book[/] to delete:")
                //        .AddChoices(books));

                //    /* Using the Remove method to delete a book. This method returns a boolean
                //      that we can use to present a message in case of success or failure.*/
                //    if (books.Remove(bookToDelete))
                //    {
                //        AnsiConsole.MarkupLine("[red]Book deleted successfully![/]");
                //    }
                //    else
                //    {
                //        AnsiConsole.MarkupLine("[red]Book not found.[/]");
                //    }

                //    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                //    Console.ReadKey();
                //}

            }
        }
    }
}
