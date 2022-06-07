using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DSA_Tracker.Models
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }
        [DisplayName("Problem Url")]
        [Required(ErrorMessage ="Submit problem url")]
        public string ProblemUrl { get; set; }

        [DisplayName("Problem Name")]
        [Required(ErrorMessage = "Problem name required")]
        public string ProblemName { get; set; }

        public string Note { get; set; }
        public bool NeedToRepeat { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy HH:mm:ss}")]
        public DateTime Date { get; set; }

        public DifficultyLevels DifficultyLevel { get; set; }
        public Platforms Platform { get; set; }
    }
    public enum DifficultyLevels
    {
        Easy,
        Medium,
        Hard
    }
    public enum Platforms
    {
        Leetcode,
        Codeforces,
        Hackerrank,
        CrackingCodingInterview
    }
}
