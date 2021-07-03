using MovieStars.Models;
using MovieStars.Service;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieStars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var allText = FileService.GetAllText(FileService.GetPath());

            var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(allText);

            foreach (var movieStar in movieStars)
            {
                PresentService.MovieStarPresentor(movieStar);
            }
        }
    }
}
