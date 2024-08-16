using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Book
{
    public partial class Books : BaseEntity
    {
        // public int Id { get; set; } Getting from BaseEntity
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        

    }
}
