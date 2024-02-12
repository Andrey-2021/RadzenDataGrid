using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Enities;

public class PriceListService
{
	[Key]
	public int Id { get; set; }

	[Required]
	public PriceListServiceBase ServiceBase { get; set; } = new();
}
