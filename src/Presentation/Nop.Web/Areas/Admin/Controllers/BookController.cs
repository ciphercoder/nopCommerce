using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nop.Services;
using Nop.Services.Customers;
using Nop.Services.Security;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Models.Books;
using Nop.Web.Areas.Admin.Models.Catalog;
using Nop.Web.Areas.Admin.Models.Customers;
using Nop.Web.Framework.Controllers;

namespace Nop.Web.Areas.Admin.Controllers
{
    public partial class BookController : BaseAdminController
    {
        private readonly IBookService _bookService;
        private readonly IBookModelFactory _bookModelFactory;

        public BookController(IBookService bookService, IBookModelFactory bookModelFactory)
        {
            _bookService = bookService;
            _bookModelFactory = bookModelFactory;
        }
        // GET: BookController
        public virtual IActionResult Index()
        {
            //var model = _bookService.GetAllBooks();
            var model = _bookModelFactory.PrepareBookSearchModel(new BookSearchModel());

            return View("List",model);
        }

        [HttpPost]
        public virtual IActionResult BookList(string name)
        {
           
            //prepare model
            
            var model = _bookService.GetBookByName(name);
            return Json(model);
        }

    }

}
