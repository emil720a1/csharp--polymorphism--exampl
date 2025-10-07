
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year {get; set; } 
    public string ISBN { get; set; }

    public Book(string title, string author, int year, string isbn)
    {
        Title = title;
        Author = author;
        Year = year;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"'{Title}' - {Author} ({Year} ISBN: {ISBN}";
    }
}

class Library()
{
  private List<Book> _books = new List<Book>();
   public void AddBook(Book book)
   {
       if (book == null)
       {
           Console.WriteLine("Book is null");
           return;
       }
       _books.Add(book);
       Console.WriteLine($"Книга добавлена: {book.Title}");
   }

   public bool RemoveBook(string title)
   {
       foreach (var book in _books)
       {
           if (book.Title == title)
           {
               _books.Remove(book);
               return true;
           }
       }
       return false;
   }

   public Book SearchBookByTitle(string title)
   {
       if (title == null)
       {
           return null;
       }

       foreach (var book in _books)
       {
           if (book.Title == title)
           {
               return book;
           }
       }

       return null;
   }
   
}
class Program()
{
    static void Main()
    {
   

    }
}
