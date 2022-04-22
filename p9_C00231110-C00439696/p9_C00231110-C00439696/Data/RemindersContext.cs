using Microsoft.EntityFrameworkCore;

namespace p9_C00231110_C00439696.Data;

public class houseHoldContext : DbContext
{
    public houseHoldContext(
        DbContextOptions<houseHoldContext> options) : base(options) { }
    public DbSet<Models.HouseHold> HouseHolds { get; set; }
}