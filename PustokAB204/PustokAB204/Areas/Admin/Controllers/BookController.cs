using Microsoft.AspNetCore.Mvc;
using PustokAB204.Business.DTOs.BookDTOs;
using PustokAB204.Business.Services.Abstracts;

namespace PustokAB204.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        public BookController(IBookService bookService, IGenreService genreService)
        {
            _bookService = bookService;
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAll();

            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.Genres = _genreService.GetAllGenres();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCreateDTO bookCreateDTO)
        {
            ViewBag.Genres = _genreService.GetAllGenres();

            if (!ModelState.IsValid)
            {
                return View();
            }
            await _bookService.AddAsync(bookCreateDTO);
            return RedirectToAction("Index");
        }
    }
}
