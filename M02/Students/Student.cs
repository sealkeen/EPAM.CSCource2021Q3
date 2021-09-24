using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Student 
    {
        private string FullName { get; set; }
        private string Email { get; set; }
        public Student(string email)
        {
            Email = email.ToLowerInvariant(); ;
            var fullName = email.Split('@')[0].Split('.');

            if (fullName.Length == 2)
            {
                FullName = string.Join(" ", fullName);
            }
        }
        public Student(string name, string surname)
        {
            FullName = name + " " + surname;
            Email = name.ToLower() + "." + surname.ToLower() + "@epam.com";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() == this.GetHashCode())
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return Email.ToUpperInvariant().GetHashCode();
        }
    }
}
