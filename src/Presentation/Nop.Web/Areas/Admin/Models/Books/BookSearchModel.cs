using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Books
{
    /// <summary>
    /// Represents a customer search model
    /// </summary>
    public partial class BookSearchModel : BaseSearchModel// , IAclSupportedModel
    {
        public IEnumerable<BookModel> BookList { get; set; }
        public string Name{ get; set; }
       
    }
}