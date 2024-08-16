using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Book;
using Nop.Core.Domain.Customers;

namespace Nop.Services
{
    public partial interface IBookService
    {
        Books GetBookByName(string name);

        IEnumerable<Books> GetAllBooks(); 

    }
}
