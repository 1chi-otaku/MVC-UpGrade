using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Model
{
    class Database
    {
        public Database()
        {
        }
        public string FindName(string searchKey)
        {
            List<Book> books = new List<Book>();
            using (StreamReader reader = new StreamReader("database.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split('|');
                    if (arr[0].ToLower().Contains(searchKey.ToLower()))
                    {
                        books.Add(new Book(arr[0], arr[1]));
                    }
                }
            }
            if (books.Count > 0)
            {
                string booklist = "";
                foreach (var item in books)
                {
                    booklist += item.ToString() + "\n";
                }
                return booklist;
            }
            return null;
        }

        public string FindAuthor(string searchKey)
        {
            List<Book> books = new List<Book>();
            using (StreamReader reader = new StreamReader("database.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split('|');
                    if (arr[1].ToLower().Contains(searchKey.ToLower()))
                    {
                        books.Add(new Book(arr[0], arr[1]));
                    }
                }
            }
            if (books.Count > 0)
            {
                string booklist = "";
                foreach (var item in books)
                {
                    booklist += item.ToString() + "\n";
                }
                return booklist;
            }
            return null;
        }
    }
}

