using System.ComponentModel.DataAnnotations;

namespace DSA_Tracker.Models
{
    public class Solution
    {
        [Key]
        public Guid SolutionId { get; set; }
        [Required]
        public string SolutionName { get; set; }
        [Required]
        public string SolutionDescription { get; set; }
        [Required]
        public string SolutionCode { get; set; }
        [Required]
        public SolutionTimeComplexity TimeComplexity { get; set; }
        [Required]
        public SolutionLanguage Language { get; set; }
        public Problem Problem { get; set; }


    }
    public enum SolutionTimeComplexity
    {
        n,
        nPower2,
        nPower3,
        nPower4,
        logn,
        nlogn,
        twoPowerN,
        other
    }
    public enum SolutionLanguage
    {
        Java,
        CSharp,
        Cpp,
        C,
        Python,
        Golang
    }
}
