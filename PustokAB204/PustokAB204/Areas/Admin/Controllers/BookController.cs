using Microsoft.AspNetCore.Mvc;
using PustokAB204.Business.DTOs.BookDTOs;
using PustokAB204.Business.Services.Abstracts;
using PustokAB204.Data.DAL;

namespace PustokAB204.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly AppDbContext _appDbContext;
        public BookController(IBookService bookService, IGenreService genreService, AppDbContext appDbContext)
        {
            _bookService = bookService;
            _genreService = genreService;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAll();

            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.Genres = _genreService.GetAllGenres();
            ViewBag.Tags = _appDbContext.Tags.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCreateDTO bookCreateDTO)
        {
            ViewBag.Tags = _appDbContext.Tags.ToList();
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
