using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    public class Players
    {
           public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }   
        public Players(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
