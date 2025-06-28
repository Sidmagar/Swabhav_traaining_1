using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_App_Constructor_Chaining
{
    internal class Person
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public int Weight { get; set; }
        // constructor for initializing all properties

        public Person(int id, string name, int age, float height, int weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
        // constructor with default values for  Height, and Weight
        public Person(int id, string name, int age) : this(id, name, age, 5, 50)
        {
            // This constructor calls the main constructor with default values for Height and Weight
        }
        public double CalculateBMI()
        {
            // BMI = weight (kg) / (height (m) * height (m))
            double heightInMeters = Height / 100.0; // Convert height from cm to m
            return Weight / (heightInMeters * heightInMeters);
        }
        public string GetCategory()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 24.9)
                return "Normal weight";
            else if (bmi < 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Height: {Height} m, Weight: {Weight} kg, BMI: {CalculateBMI():F2}";
        }
        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
            Console.WriteLine($"Category: {GetCategory()}");
        }
    }
}
