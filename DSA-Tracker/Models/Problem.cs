using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DSA_Tracker.Models
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }

        [DisplayName("Url")]
        [Required(ErrorMessage ="Submit problem url")]
        public string ProblemUrl { get; set; }


        [DisplayName("Problem Number")]
        [Required(ErrorMessage = "Submit problem number")]
        public string ProblemNumber { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Problem name required")]
        public string ProblemName { get; set; }

        public string Note { get; set; }
        [DisplayName("Repeat")]
        public bool NeedToRepeat { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy HH:mm:ss}")]
        public DateTime Date { get; set; }
        [DisplayName("Difficulty")]
        public DifficultyLevels DifficultyLevel { get; set; }
        [DisplayName("Platform")]
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
        GeeksforGeeks,
        CrackingCodingInterview
    }
}
