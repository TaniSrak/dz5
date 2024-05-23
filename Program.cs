namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingList readingList = new ReadingList();

            //второе задание сделанов домашке 2, задание 4
        }
    }

    public class Book
    {
        public string Title { get; set; } // название книги
        public string Author { get; set; } // автор книги

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString() //чтобы красиво выводилось
        {
            return $"{Title} by {Author}";
        }

        //перегружаем для сравнения
        public static bool operator ==(Book b1, Book b2)
        {
            if (ReferenceEquals(b1, null) || ReferenceEquals(b2, null))
            {
                return ReferenceEquals(b1, b2);
            }
            return b1.Title == b2.Title && b1.Author == b2.Author;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }

    }

    public class ReadingList // список книг
    {
        private List<Book> books = new List<Book>();


        public void AddBook(Book book) //добавляем книги
        {
            books.Add(book);
        }

        public void RemoveBook(string title) //кдаляем книги
        {
            books.RemoveAll(b => b.Title == title);
        }

        public bool Contains(string title) //проверка наличия книги по названию
        {
            return books.Exists(b => b.Title == title);
        }

        public Book this[int index] //доступ по индексу
        {
            get { return books[index]; }
        }

        public void PrintAllBooks() //вывод всех книг
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
