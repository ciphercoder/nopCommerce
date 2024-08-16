using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Book
{
    public partial class Books1 : BaseEntity
    {
        //public Books()
        //{
        //    BooksGuid = Guid.NewGuid();
        //}
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        //public Guid BooksGuid { get; set; }

    }
}

