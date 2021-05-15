using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Humanizer;
using Jolusoid.Data;
using Microsoft.EntityFrameworkCore;

namespace Jolusoid.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        
        
        
    }
}