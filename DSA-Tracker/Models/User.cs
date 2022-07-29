using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DSA_Tracker.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string? FullName { get; set; }

        //Auth - https://www.youtube.com/watch?v=Kaseth2ppMk&ab_channel=TeddySmith
        //Complete Auth - https://www.youtube.com/watch?v=sogS0DtejVA&ab_channel=FrankLiu
    }
}
