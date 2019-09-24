using System;

namespace GradeBookCodeVSStudioVersion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var book = new Book("Test Grades");

            //book.AddGrade(89.0);
            book.AddGrade(92.0);
            book.AddGrade(90.0);
            book.ShowStatistics();
        }
    }
}