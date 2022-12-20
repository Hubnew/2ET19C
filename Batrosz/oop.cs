using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library_Managment_System
    {
        public int UserType;
        public string UserName;
        private int Password;
        public void login()
        {
            Console.WriteLine("login");
        }
        private void Register()
        {
            Console.WriteLine("register");
        }
        public void Logout()
        {
            Console.WriteLine("logout");
        }
    }
    class Book
    {
        public string Title;
        public string Author;
        private int ISBN;
        public int Publication;
        public Librarian librarian;
        public Library_Managment_System management;
        public void Show_duedt()
        {
            Console.WriteLine("show duedt");
        }
        private void Reservation_status()
        {
            Console.WriteLine("reservation status");
        }
        private void Feedback()
        {
            Console.WriteLine("feedback");
        }
        public void Book_request()
        {
            Console.WriteLine("book request");
        }
        public void Renw_info()
        {
            Console.WriteLine("renw info");
        }
    }
    class Librarian
    {
        public string Name;
        public int ID;
        public int Password;
        public int SearchString;
        public library_database library;
        public Library_Managment_System System;
        public List<Book> listOfRentedBooks;
        public void Verify_librarian()
        {
            Console.WriteLine("verify librarian");
        }
        public void Search()
        {
            Console.WriteLine("search");
        }
        public void RentBook(int book_id)
        {
            library_database dv = new library_database();
            Book ksiazka = new Book();
            dv.Search();
            listOfRentedBooks.Add(ksiazka);
            Console.WriteLine("co?");
        }
    }
    class User
    {
        public string name;
        public int id;
        public void verify()
        {
            Console.WriteLine("nie");
        }
        public void CheckAccount()
        {
            Console.WriteLine("idk");
        }
        public void get_book_info()
        {
            Console.WriteLine("https://www.youtube.com/watch?v=dHsnzxg51NM");
        }
    }
    class account
    {
        public string no_borrowed_books;
        public string no_reserved_books;
        public string no_returned_books;
        public string no_lost_books;
        public int fine_amount;
        public void Calculate_fine()
        {
            Console.WriteLine("za drogo jak na polskę");
        }
    }
    class library_database
    {
        public string List_of_books;
        public void Add()
        {
            Console.WriteLine("add");
        }
        private void Delete()
        {
            Console.WriteLine("delete");
        }
        public void Update()
        {
            Console.WriteLine("update");
        }
        private void Display()
        {
            Console.WriteLine("display");
        }
        public void Search()
        {
            Console.WriteLine("search");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Title = "tytul";
            book.Author = "autor";
            book.Book_request();
            book.Renw_info();

            Librarian libek = new Librarian();
            libek.Name = "Andrzej";
            libek.ID = 116;
            libek.Verify_librarian();
            List<Book> lista = new List<Book>();
            lista.Add(book1);
            libek.listofRentedBooks = lista;6

            book.librarian = new Librarian();
            book.librarian.Name = "imie";
            book.librarian.Password = 1;
            book.librarian.Search();

            Librarian librarian = new Librarian();

            librarian.library = new library_database();

            librarian.library.List_of_books = "lista";
            librarian.library.Add();
            librarian.library.Update();
            librarian.library.Search();


            book.management = new Library_Managment_System();
            book.management.login();
            book.management.Logout();

            librarian.System = new Library_Managment_System();
            librarian.System.login();
            librarian.System.Logout();

            Console.ReadKey();
        }
    }
}
