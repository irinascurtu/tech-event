using Microsoft.EntityFrameworkCore;

namespace TechEvent.Data.Infrastructure
{
    public partial class TechEventContext : DbContext
    {
        public TechEventContext(DbContextOptions<TechEventContext> options) : base(options)
        {

        }
    }

}

