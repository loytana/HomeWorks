using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] booksOne = new Book<string, int>[]
            {
                new Book<string, int> ("A-1234", "My Roman", 1989, "Roman"),
                new Book<string, int> ("F-1234", "Goblin", 1889, "Elf")
            };
            Book<int, string>[] booksTwo = new Book<int, string>[]
            {
                new Book<int, string> (32, "Your Roman", "Modern era", "Oman"),
                new Book<int, string> (42, "Romeo and Juliet", "Modern era", "Shakespeare")
            };
            var foundBook1 = FindBook(booksOne, "F-1234");
            var foundBook2 = FindBook(booksTwo, 42);
            Console.WriteLine(foundBook1?.ToString() ?? "Книга не найдена");
            Console.WriteLine(foundBook2?.ToString() ?? "Книга не найдена");

            var notFoundBook = FindBook(booksOne, "X-9999");    //дополнительно сделал
            Console.WriteLine(notFoundBook?.ToString() ?? "Книга не найдена");

        }
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
                    
            }
            return null;
        }
    }

    public class Book<T, U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }

        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
