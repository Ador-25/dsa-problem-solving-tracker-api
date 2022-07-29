using DSA_Tracker.Models;

namespace DSA_Tracker.Data
{
    public interface IProblemData
    {
        public List<Problem> GetAllProblems(string email);
        public Problem GetProblem(int id);
        public int TotalProblems();

        // get number of problems by platforms
        public PlatformCountHelper ProblemsPerPlatform(string email);

        // get number of problems by difficulty level
        public DifficultyCounterHelper DifficultyPerProblemHelper(string email);
        // get number of problems by tags
        public TagCounterHelper ProblemTags(string email);

        //get tags that have most repeats*
        //  return top 4/5 or maybe return all tags by number of repeats
        public string[] Tags(string email);


    }
    public class PlatformCountHelper
    {
        public int LeetCode { get; set; }
        public int Gfg { get; set; }
        public int CSES { get; set; }
        public int Hackerrank { get; set; }
    }
    public class DifficultyCounterHelper
    {
        public int Easy { get; set; }
        public int Medium { get; set; }
        public int Hard { get; set; }
    }
    public class TagCounterHelper
    {
        public int Dp { get; set; }
        public int Array { get; set; }
        public int Bst { get; set; }
        public int Hash { get; set; }
        public int BinarySearch { get; set; }
        public int LinkedList { get; set; }

        public int LinearSearch { get; set; }
        public int Sorting { get; set; }
        public int Tree { get; set; }
        public int Stack { get; set; }
        public int Queue { get; set; }
    }
}