using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ManagerMicroservices.Models
{
    [Table("Manager")]
    public partial class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
    }
}
