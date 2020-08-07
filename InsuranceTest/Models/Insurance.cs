using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceTest.Models
{
    public class Insurance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public DateTime coverageInit { get; set; }
        [Required]
        public int coverageTime { get; set; }
        public float price { get; set; }
        public string riskType { get; set; }
        public float coverage { get; set;}
        public string insuranceType { get; set; }
    }
}
