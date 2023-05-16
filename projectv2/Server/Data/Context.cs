using Microsoft.EntityFrameworkCore;
using projectv2.Shared.Models;

namespace projectv2.Server.Controllers.Data
{
    public class Context: DbContext
    {

        public Context(DbContextOptions<Context> options) :base(options) { }
        public DbSet<Accounts> accounts { get; set; }
    }
}
