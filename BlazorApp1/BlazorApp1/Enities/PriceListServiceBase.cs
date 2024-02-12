using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorApp1.Enities;

[ComplexType]
public class PriceListServiceBase
{
	public int Index { get; set; }
	public string? Code { get; set; }
	public string? ServiceName { get; set; }
}
