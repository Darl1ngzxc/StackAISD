
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        Library library = new Library(5);

        // Добавление книг в библиотеку
        library.AddBook(new Book("Мёртвые души", "Николай Гоголь", 1835));
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1863));
        library.AddBook(new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997));

        // Отображение доступных книг
        library.DisplayBooks();

        // Взятие книги
        Book borrowedBook = library.BorrowBook();

        // Отображение доступных книг после взятия
        library.DisplayBooks();

        string BookTitle1 = "Мёртвые души";
        string BookTitle2 = "Гарри Поттер и философский камень";
        library.FindBookByTitle(BookTitle2);
        library.FindBookByTitle(BookTitle1);
    }
}
