using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class MangaBotContext: DbContext
    {
        //TODO: Testar Migration para ver comportamento dos Objetos
        //TODO: Criar Connection String

        public MangaBotContext(DbContextOptions<MangaBotContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<Usuario_MangaModel> Usuario_Manga { get; set; }
        public DbSet<MangaModel> Mangas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
