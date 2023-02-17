using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace myApp.Models;

public class Human
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(7)]
    public string Gender { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [Column(TypeName = "date")]
    public DateTime Birthday { get; set; }
    
    public int Age =>
         DateTime.Now.Year - Birthday.Year +(DateTime.Now.DayOfYear < Birthday.DayOfYear ? -1 : 0);

    public override string ToString()
    {
        return Name + " " + Birthday.Date + " " + Gender + " " + Age;
    }
}