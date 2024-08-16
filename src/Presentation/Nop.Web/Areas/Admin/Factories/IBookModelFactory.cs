using Nop.Core.Domain.Common;
using Nop.Web.Areas.Admin.Models.Books;

namespace Nop.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the book model factory
    /// </summary>
    public partial interface IBookModelFactory
    {
       
        BookSearchModel PrepareBookSearchModel(BookSearchModel searchModel);

        /// <summary>
        /// Prepare paged book list model
        /// </summary>
        /// <param name="searchModel">book search model</param>
        /// <returns>Book list model</returns>
        BookListModel PrepareBookListModel(BookSearchModel searchModel);

      
        BookModel PrepareBookModel(BookModel model);

        

    }
}