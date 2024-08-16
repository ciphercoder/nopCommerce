using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Book;
using Nop.Data;
using System.Globalization;
using System.Linq;



namespace Nop.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Books> _booksRepository;

        public BookService(
            IRepository<Books> booksRepository            
            )
        {
                 _booksRepository = booksRepository;
        }

        public IEnumerable<Books> GetAllBooks()
        {
            return _booksRepository.Table.ToList().AsEnumerable();
        }

        public virtual Books GetBookByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var query = from c in _booksRepository.Table                        
                        where c.Name == name                        
                        select c;
            var book = query.FirstOrDefault();
            return book;
        }

    }
}
