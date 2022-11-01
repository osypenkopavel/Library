namespace Library2022;
public class Book 
{   
    private int year;
    private string title;
    private double price;

    public Book(int Year, string Title, double Price)
    {        
        year = Year;
        title = Title;
        price = Price;
    }
    static void Main(string[] args)
    {
        Book book1 = new Book(1992, "Mega Book", 9.99);
        Book book2 = new Book(2005, "Big Book", 29.99);

        Author authors1 = new Author("Dickson");
        Author authors2 = new Author("Jefferson");
        
        Publisher publisher = new Publisher();

        Console.WriteLine("There is a new author" + " " + authors2 
            + " " + "with his new masterpiece" + " " 
            + book1.title +" "+ "from" +" "+publisher.cascade);

        Customer corey = new Customer(0978908765, "Corey Springler", "Second street 456");

        Console.WriteLine(corey.name + " " + "have to return" + " " + book1.title);
    }
}
