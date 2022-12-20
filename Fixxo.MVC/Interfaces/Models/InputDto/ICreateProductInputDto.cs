namespace Fixxo.MVC.Interfaces.Models.InputDto;

public interface ICreateProductInputDto
{
    string Category { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    decimal Price { get; set; }
    string? ImgUrl { get; set; }
}