public class Book
{
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }
    public string BookNumber { get; set; }
    public int NumberOfCopies { get; set; }

    public Book(string author, decimal price, string title, string bookNumber, int numberOfCopies)
    {
        Author = author;
        Price = price;
        Title = title;
        BookNumber = bookNumber;
        NumberOfCopies = numberOfCopies;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} (Book No: {BookNumber}, {NumberOfCopies} copies) - Price: {Price:C}";
    }
}
