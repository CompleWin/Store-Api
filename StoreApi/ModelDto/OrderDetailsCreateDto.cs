using System.ComponentModel.DataAnnotations;

namespace StoreApi.ModelDto;

public sealed class OrderDetailsCreateDto
{
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string ItemName { get; set; }
    [Required]
    public double Price { get; set; }
}