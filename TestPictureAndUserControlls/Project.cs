using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPictureAndUserControlls
{
    public class Project
    {
        public string Name{ get; set; }

        public string Goal { get; set; }

        public Project(string _name, string _goal)
        {
            Name = _name;
            Goal = _goal;
        }
    }
}
