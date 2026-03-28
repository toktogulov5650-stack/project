using System.ComponentModel.DataAnnotations;


namespace Project.Application.DTOs.Service;

public class ServiceUpdateRequest
{
    [Required]
    [MaxLength(250)]
    public string Caption { get; set; } = null!;

    [MaxLength(500)]
    public string Image { get; set; } = null!;

    [Required]
    [MaxLength(250)]
    public string Title { get; set; } = null!;

    [MaxLength(1000)]
    public string Description { get; set; } = null!;

    [MaxLength(2000)]
    public string FullInfo { get; set; } = null!;

    public bool IsPublished { get; set; }
}

