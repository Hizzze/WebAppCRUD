using BookStore.Core.Models;
using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        // PrimaryKey
        builder.HasKey(x => x.Id);
        // Устанавливаем Required, и максимальноке количество символов в поле Title.
        builder.Property(b => b.Title).HasMaxLength(Book.MAX_TITLE_LENGTH).IsRequired();
        builder.Property(b => b.Description).IsRequired();
        builder.Property(b => b.Price).IsRequired();
    }
}