using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoLibreria.Models.DataModels;

#nullable disable

namespace ProyectoLibreria.DataAccess
{
    public partial class LibreriaDBContext : DbContext
    {
        public LibreriaDBContext()
        {

        }
        public LibreriaDBContext(DbContextOptions<LibreriaDBContext> options)
            : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Lenguaje> Lenguajes { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Opinion> Opiniones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<sp_menoresTop> sp_menoresTop { get; set; }
        public DbSet<sp_mayoresTop> sp_mayoresTop { get; set; }
        public DbSet<sp_letraCategoria> sp_letraCategoria { get; set; }
        public DbSet<sp_searchEdad> sp_searchEdad { get; set; }
        public DbSet<sp_searchNotEdad> sp_searchNotEdad { get; set; }
        public DbSet<sp_FechaOpi> sp_FechaOpi { get; set; }
        public DbSet<sp_tipoOpi> sp_tipoOpi { get; set; }
        public DbSet<sp_nivelFlui> sp_nivelFlui { get; set; }
        public DbSet<sp_estadoIdioma> sp_estadoIdioma { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;database=LibreriaDB;integrated security=true; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
