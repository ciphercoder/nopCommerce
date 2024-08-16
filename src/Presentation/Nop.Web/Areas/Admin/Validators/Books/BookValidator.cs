using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using LinqToDB.DataProvider;
using Nop.Core.Domain.Book;
using Nop.Data;
using Nop.Services;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Books;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Book
{
    public partial class BookValidator :  BaseNopValidator<BookModel>
    {
        public BookValidator(IBookService bookService,            
            INopDataProvider dataProvider )
        {
            RuleFor(x => x.Name)
           .NotEmpty()
           .WithMessage("Valid Name is required for Book to be Stored");
           
            SetDatabaseValidationRules<Books>(dataProvider);

        }
    }
}
