using Microsoft.EntityFrameworkCore;

namespace Relacionamentos.Models
{
    public class RelacionamentosContext:DbContext
    {
        public RelacionamentosContext(DbContextOptions<RelacionamentosContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }



    }
}
