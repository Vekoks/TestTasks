using MovieStars.Models;
using System;

namespace MovieStars.Service
{
    public static class PresentService
    {
        public static void MovieStarPresentor(MovieStar star )
        {
            var age = DateTime.Now.Year - star.dateOfBirth.Year;

            Console.WriteLine(star.Name + " " + star.Surname);

            Console.WriteLine(star.Sex);

            Console.WriteLine(star.Nationality);

            Console.WriteLine(age + " year old");

            Console.WriteLine();
        }
    }
}
