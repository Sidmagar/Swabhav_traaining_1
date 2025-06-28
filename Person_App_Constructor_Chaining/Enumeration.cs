using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_App_Constructor_Chaining
{
    enum PersonType
    {
        Student,
        Teacher,
        Administrator

    }
    internal class Enumeration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public Enumeration(int id, string name, PersonType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {Type}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }

    }
}
