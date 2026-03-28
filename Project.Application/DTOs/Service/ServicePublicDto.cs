using System.ComponentModel.DataAnnotations;

namespace Project.Application.DTOs.Service;

public class ServicePublicDto
{
    public int Id { get; set; }
    public string Caption { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string FullInfo { get; set; }
    public DateTime PublicationDate { get; set; }
}
