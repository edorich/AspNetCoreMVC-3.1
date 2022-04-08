using edo.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edo.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Eddo", Description="This is the description for MVC book", Category="Programming", Language="English", TotalPages=137},
                new BookModel(){Id=2, Title="Java", Author="Eddi", Description="This is the description for Java book", Category="Programming", Language="English", TotalPages=150},
                new BookModel(){Id=3, Title="Python", Author="Eddu", Description="This is the description for Python book", Category="Programming", Language="English", TotalPages=189},
                new BookModel(){Id=4, Title="C++", Author="Edde", Description="This is the description for C++ book", Category="Programming", Language="English", TotalPages=200},
                new BookModel(){Id=5, Title="C#", Author="Edda", Description="This is the description for C# book", Category="Programming", Language="English", TotalPages=56},
                new BookModel(){Id=6, Title="Azure Devops", Author="Edward", Description="This is the description for Azure Devops book", Category="Programming", Language="English", TotalPages=234}
            };
        }
    }
}
