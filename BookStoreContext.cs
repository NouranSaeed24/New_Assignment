using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment
{
    internal class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = BookStore ; Trusted_Connection = true ; Trust server certificate = true");


        }
            DbSet<Books> books { get; set; }
            DbSet<Authors> authors { get; set; }
            DbSet<Categories> categories { get; set; }
    }
}
