using Microsoft.EntityFrameworkCore;

namespace TechEvent.Data.Infrastructure
{
    public class TechEventContext : DbContext
    {
        public TechEventContext(DbContextOptions<TechEventContext> options) : base(options)
        {
        }
    }
}
