using System.ComponentModel.DataAnnotations;

namespace Project.Application.DTOs.Service;

public class ServicePublicDto
{
    public int Id { get; set; }
    public string Caption { get; set; } = null!;
    public string Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string FullInfo { get; set; } = null!;
    public DateTime PublicationDate { get; set; }
}
