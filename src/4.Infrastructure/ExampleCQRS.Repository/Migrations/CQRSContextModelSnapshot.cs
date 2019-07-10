﻿// <auto-generated />
using System;
using ExampleCQRS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExampleCQRS.Repository.Migrations
{
    [DbContext(typeof(CQRSContext))]
    partial class CQRSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExampleCQRS.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ExampleCQRS.Domain.Entities.User", b =>
                {
                    b.OwnsOne("ExampleCQRS.Domain.ValueObjects.BirthDate", "BirthDate", b1 =>
                        {
                            b1.Property<Guid>("UserId");

                            b1.Property<DateTime>("DateOfBirth")
                                .HasColumnName("BirthDate");

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.HasOne("ExampleCQRS.Domain.Entities.User")
                                .WithOne("BirthDate")
                                .HasForeignKey("ExampleCQRS.Domain.ValueObjects.BirthDate", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("ExampleCQRS.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UserId");

                            b1.Property<string>("EmailValue")
                                .IsRequired()
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.HasOne("ExampleCQRS.Domain.Entities.User")
                                .WithOne("Email")
                                .HasForeignKey("ExampleCQRS.Domain.ValueObjects.Email", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("ExampleCQRS.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("UserId");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnName("LastName");

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.HasOne("ExampleCQRS.Domain.Entities.User")
                                .WithOne("Name")
                                .HasForeignKey("ExampleCQRS.Domain.ValueObjects.Name", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
