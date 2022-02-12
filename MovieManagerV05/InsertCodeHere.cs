using System;

namespace MovieManagerV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            string Title = "Avatar";
            string Genre = "Sci-fi/Action";
            int DayOfRelease = 20;
            int MonthOfRelease = 12;
            int YearOfRelease = 2009;
            string ReleaseDate = $"{DayOfRelease}/{MonthOfRelease}/{YearOfRelease}";
            int Length = 189;
            string Instructor = "James Cameron";

            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Release date: {ReleaseDate}");
            Console.WriteLine($"Length: {Length} min");
            Console.WriteLine($"Instructor: {Instructor}");
            // The LAST line of code should be ABOVE this line
        }
    }
}