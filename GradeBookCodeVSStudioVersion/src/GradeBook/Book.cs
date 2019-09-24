using System;
using System.Collections.Generic;

namespace GradeBookCodeVSStudioVersion
{
    public class Book
    {
        public Book(string name)
        {
            Grades = new List<double>();
            Name = name;
        }

        public List<double> Grades { get; set; }
        public string Name { get; set; }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var average = GetCalculatedAverage();
            var lowGrade = GetMinGrade();
            var highGrade = GetMaxGrade();
            Console.WriteLine($"Grades:");
            Console.WriteLine($"Lowest: {lowGrade}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Highest: {highGrade}");
        }

        private double GetCalculatedAverage()
        {
            double total = 0;
            foreach (var grade in Grades)
            {
                total += (double)grade;
            }

            return total / Grades.Count;
        }

        private double GetMaxGrade()
        {
            var maxGrade = double.MinValue;

            foreach (var grade in Grades)
            {
                maxGrade = Math.Max(maxGrade, grade);
            }
            return maxGrade;
        }

        private double GetMinGrade()
        {
            var maxGrade = double.MaxValue;

            foreach (var grade in Grades)
            {
                maxGrade = Math.Min(maxGrade, grade);
            }
            return maxGrade;
        }
    }
}