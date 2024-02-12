using BlazorApp1.Enities;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1;

public class MyDbContetx : DbContext
{
	public MyDbContetx(DbContextOptions<MyDbContetx> options):base(options)
	{
		Database.EnsureCreated();
	}

	public DbSet<PriceListService> PriceListServices { get; set; }
}
