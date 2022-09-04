﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Persistence.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.SomeFeatureEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("Id");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("Name");

                b.HasKey("Id");

                b.ToTable("SomeFeatureEntities", (string)null);

                b.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Test 1"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Test 2"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
