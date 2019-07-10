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

            builder.OwnsOne(e => e.Name, name =>
            {
                name.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName");

                name.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName");
            });
            
            builder.OwnsOne(e => e.Email, name =>
            {
                name.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("Email");
            });

            builder.OwnsOne(e => e.BirthDate, name =>
            {
                name.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("BirthDate");
            });

            builder.Property(c => c.CreatedAt)
                .HasColumnName("CreatedAt");

            builder.Property(c => c.UpdatedAt)
                .HasColumnName("UpdatedAt");
        }
    }
}