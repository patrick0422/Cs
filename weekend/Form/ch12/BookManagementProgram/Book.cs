using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram
{
    class Book
    {
        int id { get; set; }
        string name { get; set; }
        string publisher { get; set; }
        int page { get; set; }

        public Book() { }
        public Book(int id, string name, string publisher)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
        }
    }
}
