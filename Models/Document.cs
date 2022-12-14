using System.ComponentModel.DataAnnotations;
namespace DHF_Viewer_WebApp.Models;

public class Document
{
    public int Id { get; set; }
    [Required]
    [MaxLength(12)]
    public string? Infocard { get; set; }
    public string? Title { get; set; }
    public string? Revision { get; set; }
    public DHF_Sections? Section { get; set; }
    public ICollection<Products>? Products { get; set; } //one-to-many relationship
}