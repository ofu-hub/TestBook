using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestBook;
using TestBook.Models;

namespace TestBook.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly TestBook.DatabaseContext _context;

        public IndexModel(TestBook.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get;set; } = default!;

        // Параметры для поиска
        [BindProperty(SupportsGet = true)]
        public string? SearchTitle { get; set; }

        // Параметры для сортировки
        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                // Запрос для получения всех книг
                IQueryable<Book> booksQuery = _context.Books;

                // Применение фильтра по названию
                if (!string.IsNullOrEmpty(SearchTitle))
                {
                    booksQuery = booksQuery.Where(b => b.Title.Contains(SearchTitle));
                }

                // Применение сортировки
                booksQuery = SortOrder switch
                {
                    "author" => booksQuery.OrderBy(b => b.Author),
                    "date" => booksQuery.OrderBy(b => b.PublishedDate),
                    "date_desc" => booksQuery.OrderByDescending(b => b.PublishedDate),
                    _ => booksQuery.OrderBy(b => b.Title), // сортировка по умолчанию
                };

                Books = await booksQuery.ToListAsync();
            }
        }
    }
}
