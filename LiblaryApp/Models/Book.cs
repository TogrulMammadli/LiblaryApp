using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblaryApp.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public int IdTheme { get; set; }
        public int IdCategory { get; set; }
        public int IdAutor { get; set; }
        public int IdPress { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }

        public Book()
        {
        }
    }
}
