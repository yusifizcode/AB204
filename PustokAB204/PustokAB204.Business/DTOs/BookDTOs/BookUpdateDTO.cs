using Microsoft.AspNetCore.Http;

namespace PustokAB204.Business.DTOs.BookDTOs;

public class BookUpdateDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPercent { get; set; }
    public string Description { get; set; } = null!;
    public IFormFile ImageFile { get; set; } = null!;
    public int GenreId { get; set; }
}
