using Microsoft.EntityFrameworkCore;

namespace CrudCliente.Models
{
    public class BancoContext:DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options):base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
