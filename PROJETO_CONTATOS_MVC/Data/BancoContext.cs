using Microsoft.EntityFrameworkCore;
using PROJETO_CONTATOS_MVC.Models;

namespace PROJETO_CONTATOS_MVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }   

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
