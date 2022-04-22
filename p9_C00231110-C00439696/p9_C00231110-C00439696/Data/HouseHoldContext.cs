using Microsoft.EntityFrameworkCore;

namespace p9_C00231110_C00439696.Data;

public class HouseHoldContext : DbContext
{
    public HouseHoldContext(
        DbContextOptions<HouseHoldContext> options) : base(options) { }
    public DbSet<Models.HouseHold> HouseHolds { get; set; }
}