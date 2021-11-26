using BookWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(int id);
        Task<Book> CreateBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
