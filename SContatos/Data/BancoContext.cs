using Microsoft.EntityFrameworkCore;
using SContatos.Models;

namespace SContatos.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
        }

       public DbSet<ContatoModel> Contatos { get; set; }
       public DbSet<UsuarioModel> Usuarios { get; set; }
        public object Usuario { get; internal set; }
    }

}