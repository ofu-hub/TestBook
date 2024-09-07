using Microsoft.EntityFrameworkCore;
using TestBook.Models;

namespace TestBook;

/// <summary>
/// Класс для настройки контекста базы данных
/// </summary>
public class DatabaseContext : DbContext
{
    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    /// <param name="options">Базовые настройки бд</param>
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    /// <summary>
    /// Коллекция книг
    /// </summary>
    public DbSet<Book> Books { get; set; }
}
