namespace OnlineMovieStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; } = null!;

        public int MovieHour { get; set; } 

        public int MovieRating { get; set; }

        public string MovieDirector { get; set; }

        public string MovieProducer { get; set; }

        public string MovieActors { get; set; }

        public string? MovieDescription { get; set; }

        public string? MovieLanguage { get; set; }

        public bool IsPopular { get; set; } // top 10 popularni movie (moze i da go staime a moze i ne)

        public int YearOfRelease { get; set }  // godina na izdavenje

        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna

       
    }
}
