using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    static public class Manager
    {
        static public void TakeBook(Book Book, Student Student)
        {
            if (Book.Be == true)
            {
                Student.Book = Book;
                Book.Be = false;
                Book.Date = new DateTime(2016,12,12);
            }
            else 
                throw new Exception("Книги нет в наличии");
        }
        static public void Dolzhniki(List<Student> Stud)
        {
            foreach(Student Student in Stud)
            {
                if (Student.Book != null && Student.Book.Date < DateTime.Now) Console.Write(Student.Name + " должник\n");
            }
        }
        static public void WriteBooks(List<Book> Books)
        {
            foreach (Book Book in Books)
            {
                Console.Write("{0} {1} ", Book.Autor, Book.Name);
                if (Book.Be == true) Console.Write("в наличии\n");
                else Console.Write("нет в наличии\n");
            }
        }
    }
}
