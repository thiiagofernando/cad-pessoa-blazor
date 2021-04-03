using Microsoft.EntityFrameworkCore;

namespace cad_pessoa_blazor.Entities
{
    public class CadPessoaContext : DbContext
    {
        public CadPessoaContext(DbContextOptions<CadPessoaContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}