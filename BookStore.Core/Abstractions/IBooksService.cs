using BookStore.Core.Models;

namespace BookStore.Core.Abstractions;

public interface IBookService
{
    Task<Guid> CreateBook(Book book);
    Task<Guid> DeleteBook(Guid id);
    Task<List<Book>> GetAllBooks();
    
    Task<Guid> UpdateBooks(Guid id, string title, string description, decimal price);
}
