using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Model;

namespace WindowsFormsApp5
{
    class Controller
    {
        public string GetBookByName(string bookname)
        {
            Database db = new Database();           
            string rez = db.FindName(bookname);
          
            if(rez!=null)
            {
                return rez;
            }
            return "Книга не найдена!";
        }
        public string GetBookByAuthor(string author) {
            Database db = new Database();
            string rez = db.FindAuthor(author);
            if (rez != null)
            {
                return rez;
            }
            return "Книга не найдена!";
        }


    }
}
