using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class Task : IID
    {
        public int Id { get; set; }
        public string TName { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public Task(string tName)
        {
            TName = tName;
        }
        public override string ToString()
        {
            return String.Format(Id + " " + TName + " " + ToStringDepartments());
        }
        private string ToStringDepartments()
        {
            string result = "";

            foreach (Department d in Departments)
            {
                result += d.ToString() + " ";
            }
            return result;
        }
    }
}