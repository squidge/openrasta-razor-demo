namespace OpenRasta_Demo.Handlers
{
    using System.Collections.Generic;

    using OpenRasta_Demo.Models;
    using OpenRasta_Demo.Resources;

    public class MovieHandler
    {
        public MovieResource Get()
        {
            var movies = new MovieResource
                {
                    Movies =
                        new List<Movie>
                            {
                                new Movie { Title = "Titanic", Year = 1997 },
                                new Movie { Title = "Gladiator", Year = 2000 }
                            }
                };

            return movies;
        }
    }
}