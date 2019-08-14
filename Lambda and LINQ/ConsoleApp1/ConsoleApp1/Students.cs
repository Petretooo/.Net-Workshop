using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }



        public override string ToString()
        {
            return $"FirstName: {FirstName}" +
                $"\nLastName: {LastName}" +
                $"\nGrade: {Grade}";
        }
    }
}
