using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SocialMedia.core.Entities;

namespace SocialMedia.Api.Data
{
    public partial class SocialMediaContext : DbContext
    {
        public SocialMediaContext()
        {
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<User> User { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Like>(entity =>
            {
                entity.ToTable("Like");
                entity.HasKey(e => e.LikeId);

                entity.Property(e => e.LikeId)
                .HasColumnName("IdLike")
                .ValueGeneratedNever();
                

                entity.Property(e => e.Date)
                .HasColumnName("Fecha")
                .HasColumnType("datetime");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Publicacion");
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.Description)
                    .HasColumnName("Descripcion")
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                  .HasColumnName("Fecha")
                  .HasColumnType("datetime");

                entity.Property(e => e.Image)
                  .HasColumnName("Imagen")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.LastName)
                 .HasColumnName("Apellidos")
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                 .HasColumnName("Email")
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirth)
                 .HasColumnName("FechaNacimiento")
                .HasColumnType("date");

                entity.Property(e => e.FirstName)
                     .HasColumnName("Nombres")
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                     .HasColumnName("Telefono")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

         
        }

        
    }
}
