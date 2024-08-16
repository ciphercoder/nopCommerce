using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Catalog;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;


namespace Nop.Web.Areas.Admin.Models.Books
{
    public class BookModel : BaseNopEntityModel
    {
        public string Name { get; set; }
    }
}
