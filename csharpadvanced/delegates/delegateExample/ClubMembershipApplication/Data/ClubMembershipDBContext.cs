using Microsoft.EntityFrameworkCore;
using  ClubMemberShipApplication.Models;

namespace ClubMemberShipApplication;

public class ClubMemberShipDBContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder) {
       optionbuilder.UseSqlite($"Data source={AppDomain.CurrentDomain.BaseDirectory}clubMembership.db");
       base.OnConfiguring(optionbuilder);
    }

    public DbSet<User> Users {get; set;}
}
