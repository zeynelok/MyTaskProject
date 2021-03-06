// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(MyTaskProjectDbContext))]
    partial class MyTaskProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 266, DateTimeKind.Local).AddTicks(4903),
                            Description = "Kitap Kategorisi Açıklaması",
                            Name = "Kitap"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 269, DateTimeKind.Local).AddTicks(6670),
                            Description = "Beyaz Eşya Kategorisi Açıklaması",
                            Name = "Beyaz Eşya"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 269, DateTimeKind.Local).AddTicks(6827),
                            Description = "Giyim Kategorisi Açıklaması",
                            Name = "Giyim"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(5714),
                            Description = "Yüzüğün Büyüsü",
                            Name = "Yüzüklerin Efendisi",
                            Price = 15m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8371),
                            Description = "Ejderhanın Hazinesi",
                            Name = "Hobbit",
                            Price = 15m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8434),
                            Description = "Alice'in Maceraları",
                            Name = "Alice Harikalar Diyarında",
                            Price = 15m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8441),
                            Description = "Çift Kapılı",
                            Name = "Buz Dolabı",
                            Price = 10000m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8447),
                            Description = "9 Kg Kapasiteli",
                            Name = "Çamaşır Makinesi",
                            Price = 7000m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8454),
                            Description = "Su Tasarruflu",
                            Name = "Bulaşık Makinesi",
                            Price = 5000m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8458),
                            Description = "Desenli",
                            Name = "Tişört",
                            Price = 20m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8462),
                            Description = "%100 Yün",
                            Name = "Kazak",
                            Price = 100m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreateDate = new DateTime(2021, 4, 3, 23, 49, 31, 276, DateTimeKind.Local).AddTicks(8469),
                            Description = "Oduncu Gömleği",
                            Name = "Gömlek",
                            Price = 60m
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
