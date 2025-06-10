using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace crudapp.Models
{
    public class Dept
    {   
        [Key]
        [Display(Name="Department No")]
        [Range(1, 999, ErrorMessage = "Department number should be between 1 and 999!")]
        
        public int dno { get; set; }

        [Display(Name="Department Name")]
        [Required(ErrorMessage = "Department name is required!")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-]+$", ErrorMessage = "Only letters, numbers, spaces and hyphens allowed.")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        
        public string dna { get; set; }

        [Display(Name="Department Loc")]
        [Required(ErrorMessage = "Department location is required!")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-]+$", ErrorMessage = "Only letters, numbers, spaces and hyphens allowed.")]
        
        public string dloc { get; set; }
    }
} 