using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public bool Be { get; set; }
        public DateTime Date { get; set; }

        public Book(string Name, string Autor, bool Be)
        {
            this.Name = Name;
            this.Autor = Autor;
            this.Be = Be;
        }
    }
}
