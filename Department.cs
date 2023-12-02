using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class Department : IID
    {
        public int Id { get; set; }
        public string DName { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public Department(string dName)
        {
            DName = dName;
        }
        public override string ToString()
        {
            return String.Format(Id + " " + DName);
        }
    }
}