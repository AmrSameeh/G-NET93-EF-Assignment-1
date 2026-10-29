using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Context;

namespace ReadMoreBooks
{
    internal class Program
    {
        static void Main(string[] args) { 
        using (BookstoreContext context = new BookstoreContext())
            {
                try
                {
                    context.Database.Migrate();

                    bool isConnected = context.Database.CanConnect();

                    if (isConnected)
                    {
                        Console.WriteLine(
                            "Database created successfully!");

                        Console.WriteLine(
                            $"Database Name: {context.Database.GetDbConnection().Database}");

                        Console.WriteLine(
                            $"Books Table: {context.Books.Count()}");

                        Console.WriteLine(
                            $"Authors Table: {context.Authors.Count()}");

                        Console.WriteLine(
                            $"Categories Table: {context.Categories.Count()}");
                    }
                    else
{
    Console.WriteLine(
        "Failed to connect to the database.");
}
                }
                catch (Exception ex)
                {
    Console.WriteLine(
        "An error occurred while creating the database.");

    Console.WriteLine(ex.Message);
}
            }

            Console.ReadKey();
        }
    }
}