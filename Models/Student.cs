using System.ComponentModel.DataAnnotations;
namespace StudentManager.Models;

public class Student
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
}