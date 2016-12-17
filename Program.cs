using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BibliotekaIKIT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            List<Book> Books = new List<Book>();

            Books.Add(new Book("Приступление и наказание", "Достоевский", true));
            Books.Add(new Book("Желтая стрела", "Пелевин", true));

            Students.Add(new Student("Василий"));
            Students.Add(new Student("Борис"));
            Manager.TakeBook(Books[0], Students[0]);
            Manager.Dolzhniki(Students);
            Manager.WriteBooks(Books);
            Console.ReadKey();
        }
    }
}
