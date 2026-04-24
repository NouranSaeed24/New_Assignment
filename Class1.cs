using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Books
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime PuplicationYear { get; set; }
        public bool IsInStock { get; set; }

        public int AuthorsId { get; set; }
        public int CategoryId { get; set; }
        public Authors authors { get; set; }
        public Categories categories { get; set; }
        
    }
}
