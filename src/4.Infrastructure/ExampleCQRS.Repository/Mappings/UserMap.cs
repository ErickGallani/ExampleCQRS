namespace ExampleCQRS.Repository.Mappings
{
    using System;
    using ExampleCQRS.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

		    builder.HasKey(c => c.Id);

            builder.Property(c => c.Name.GetFirstName())
                .IsRequired()
                .HasColumnName("FirstName");

            builder.Property(c => c.Name.GetLastName())
                .IsRequired()
                .HasColumnName("LastName");

            builder.Property<string>(c => c.Email)
                .IsRequired()
                .HasColumnName("Email");
            
            builder.Property<DateTime>(c => c.BirthDate)
                .HasColumnName("BirthDate");

            builder.Property(c => c.CreatedAt)
                .HasColumnName("CreatedAt");

            builder.Property(c => c.UpdatedAt)
                .HasColumnName("UpdatedAt");
        }
    }
}