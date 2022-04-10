
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public class MockPlatformData : IPlatformData
    {
        private static Guid one = new Guid();
        private static Guid two = new Guid();
        private readonly List<Platform> platforms = new List<Platform>()
        {
            new Platform()
            {
                PlatformId= one,
                PlatformName="Geekforgeeks",
                PlatformUrl="https://www.geeksforgeeks.org/",
     

            },
            new Platform()
            {
                PlatformId= two,
                PlatformName="Leetcode",
                PlatformUrl="https://leetcode.com/",

            }
        };
        public Platform AddPlatform(Platform platform)
        {
            platforms.Add(platform);
            return platform;
        }

        public Platform EditPlatform(Guid platformId, Platform platform)
        {
            var temp = platforms.SingleOrDefault(x => x.PlatformId == platformId);
            if(temp == null)
            {
                return null;
            }
            else
            {
                temp = platform;
            }

            return temp;
        }

        public List<Platform> GetAllPlatforms()
        {
            return platforms;
        }

        public Platform GetPlatform(string platformName)
        {
            return platforms.SingleOrDefault(x => x.PlatformName == platformName);
           /* for(int i = 0; i < platforms.Count; i++)
            {
                var temp = platforms.ElementAt(i);
                if (temp.PlatformName == platformName)
                    return temp;
            }
            return null;*/
           
        }
    }
}
