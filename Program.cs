using Microsoft.EntityFrameworkCore;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var dbContext = new BookStoreContext();

            dbContext.SaveChanges();
        }
    }
}
