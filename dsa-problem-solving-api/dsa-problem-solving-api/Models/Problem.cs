using System.ComponentModel.DataAnnotations;

namespace dsa_problem_solving_api.Models
{
    public class Problem
    {
        [Key]

        public Guid ProblemId { get; set; }
        [Required]
        public string QuestionUrl { get; set; }
        [Required]
        public int QuestionNo { get; set; }
        [Required]
        public string Note { get; set; }
        public string Solution { get; set; }
        public bool NeedRepeat { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        [Required]
        public Platform Platform { get; set; }
       

    }
    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }


}
