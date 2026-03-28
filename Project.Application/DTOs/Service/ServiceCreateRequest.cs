using System.ComponentModel.DataAnnotations;


namespace Project.Application.DTOs.Service;

public class ServiceCreateRequest 
{
    [Required]
    [MaxLength(250)]
    public string Caption { get; set; }

    [MaxLength(500)]
    public string Image { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [MaxLength(1000)]
    public string Description { get; set; }

    [MaxLength(2000)]
    public string FullInfo { get; set; }

    public DateTime PublicationDate { get; set; }

    public bool IsPublished { get; set; }
}
