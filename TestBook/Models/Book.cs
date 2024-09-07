using System.ComponentModel.DataAnnotations;

namespace TestBook.Models;

public class Book
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    [Required]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Автор
    /// </summary>
    [Required]
    public string Author { get; set; } = string.Empty;

    /// <summary>
    /// Дата публикации
    /// </summary>
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }

    /// <summary>
    /// Доступность
    /// </summary>
    public bool IsAvailable { get; set; }

}
