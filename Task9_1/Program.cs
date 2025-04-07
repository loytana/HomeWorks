namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Мастер и Маргарита", "М. Булгаков", 1928, 160);
            Console.WriteLine(book.GetInfo());
            book.Year = 1929;
            book.Pages = 180;
            Console.WriteLine(book.GetInfo());
        }
    }
    public class Book
    {
        private string _title;
        private string _author;
        
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }
        public string GetInfo()
        {
            return $"{_title}, {_author}, {Year}, {Pages} стр.";
        }
    }
}
