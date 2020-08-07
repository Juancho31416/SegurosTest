using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InsuranceTest.Models
{
    public class UserInsurance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int userid { get; set; }
        [Required]
        public int insuranceid { get; set; }

    }
}
