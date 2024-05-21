using System;

public class Library
{
    private Book[] books;
    private int top;
    private int capacity;

    public Library(int size)
    {
        capacity = size;
        books = new Book[capacity];
        top = -1;
    }

    public void AddBook(Book book)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Библиотека заполнена. Невозможно добавить больше книг.");
            return;
        }
        books[++top] = book;
        Console.WriteLine($"Добавлена книга: {book}");
        Console.WriteLine();
    }

    public Book BorrowBook()
    {
        if (top == -1)
        {
            Console.WriteLine("Нет доступных книг в библиотеке.");
            return null;
        }

        Book borrowedBook = books[top];
        books[top--] = null;
        Console.WriteLine($"Взята книга: {borrowedBook}");
        Console.WriteLine();
        return borrowedBook;
    }

    public void DisplayBooks()
    {
        if (top == -1)
        {
            Console.WriteLine("Библиотека пуста.");
            return;
        }

        Console.WriteLine("Доступные книги в библиотеке:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(books[i]);
        }
        Console.WriteLine();
    }

    public Book FindBookByTitle(string title)
    {
        for (int i = top; i >= 0; i--)
        {
            if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Найдена книга по названию \"{title}\": {books[i]}\n");
                return books[i];
            }
        }

        Console.WriteLine($"Книга с названием \"{title}\" не найдена в библиотеке.");
        Console.WriteLine();
        return null;
    }
}