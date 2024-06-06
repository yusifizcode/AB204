using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using PustokAB204.Business.DTOs.BookDTOs;
using PustokAB204.Business.Exceptions;
using PustokAB204.Business.Extensions;
using PustokAB204.Business.Services.Abstracts;
using PustokAB204.Core.Models;
using PustokAB204.Core.RepositoryAbstracts;
using PustokAB204.Data.DAL;

namespace PustokAB204.Business.Services.Concretes;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IWebHostEnvironment _env;
    private readonly IGenreRepository _genreRepository;
    private readonly IMapper _mapper;
    private readonly AppDbContext _appDbContext;
    public BookService(IBookRepository bookRepository, IWebHostEnvironment env, IGenreRepository genreRepository, IMapper mapper, AppDbContext appDbContext)
    {
        _bookRepository = bookRepository;
        _env = env;
        _genreRepository = genreRepository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }


    public async Task AddAsync(BookCreateDTO createDTO)
    {
        if (createDTO.ImageFile == null) throw new Exceptions.FileNotFoundException("file not found!");
        var existGenre = _genreRepository.Get(x => x.Id == createDTO.GenreId);
        if (existGenre == null)
            throw new EntityNotFoundException("genre not found!");
        //Book book = new Book
        //{
        //    Name = createDTO.Name,
        //    Description = createDTO.Description,
        //    DiscountPercent = createDTO.DiscountPercent,
        //    Price = createDTO.Price,
        //    GenreId = createDTO.GenreId,
        //};







        Book book = _mapper.Map<Book>(createDTO);

        if (createDTO.TagIds != null)
        {
            foreach (var tagId in createDTO.TagIds)
            {
                if (!_appDbContext.Tags.Any(x => x.Id == tagId))
                    throw new EntityNotFoundException("bele bir tag yoxdur!");
            }

            foreach (var tagId in createDTO.TagIds)
            {
                BookTag bookTag = new BookTag
                {
                    TagId = tagId,
                    Book = book,
                    CreatedDate = DateTime.UtcNow.AddHours(4),
                };
                _appDbContext.BookTags.Add(bookTag);
            }
        }


        book.ImageUrl = Helper.SaveFile(_env.WebRootPath, @"uploads/books", createDTO.ImageFile);
        await _bookRepository.AddAsync(book);
        await _bookRepository.CommitAsync();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public BookGetDTO Get(Func<Book, bool>? func = null)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BookGetDTO> GetAll(Func<Book, bool>? func = null)
    {
        var books = _bookRepository.GetAll(func, "Genre");
        IEnumerable<BookGetDTO> booksDto = _mapper.Map<IEnumerable<BookGetDTO>>(books);

        return booksDto;
    }

    public void Update(BookUpdateDTO updateDTO)
    {
        throw new NotImplementedException();
    }
}
