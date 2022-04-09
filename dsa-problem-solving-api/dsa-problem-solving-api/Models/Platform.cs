using System.ComponentModel.DataAnnotations;

namespace dsa_problem_solving_api.Models
{
    public class Platform
    {
        [Key]
        public Guid PlatformId { get; set; }
        [Required]
        public string PlatformName { get; set; }
        [Required]
        public string PlatformUrl { get; set; }
        public PlatformType Source { get; set; }


    }
    public enum PlatformType
    {
        Leetcode,
        GeekForGeeks,
        CrackingCodeInterview
    }
}
