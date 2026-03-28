using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;
 
namespace Project.Infrastructure.Persistence.Configurations;

public class NewsConfiguration : IEntityTypeConfiguration<News>
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.ToTable("News");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Caption)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(a => a.Image)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(a => a.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(a => a.FullInfo)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(a => a.CreateDate)
            .IsRequired();

        builder.Property(a => a.LastUpdate)
            .IsRequired();

        builder.Property(a => a.PublicationDate)
            .IsRequired();

        builder.Property(a => a.IsPublished)
            .IsRequired();
    }
}
