using FirstApiProject.DAL;
using FirstApiProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CategoriesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_appDbContext.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var existProduct = _appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (existProduct == null)
                return NotFound();
            return Ok(existProduct);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Category newCategory)
        {
            var existCategory = _appDbContext.Categories.FirstOrDefault(x => x.Id == newCategory.Id);
            if (existCategory == null)
                return NotFound();

            existCategory.Name = newCategory.Name;
            _appDbContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existCategory = _appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (existCategory == null)
                return NotFound();

            _appDbContext.Categories.Remove(existCategory);
            _appDbContext.SaveChanges();
            return NoContent();
        }

    }
}
