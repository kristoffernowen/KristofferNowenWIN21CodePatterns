using System.ComponentModel.DataAnnotations;

namespace Fixxo.Data.Entities;

public class JacketEntity : ProductEntity
{
    [Key]
    public string JacketId { get; set; } = Guid.NewGuid().ToString();
    public string Size { get; set; }
}