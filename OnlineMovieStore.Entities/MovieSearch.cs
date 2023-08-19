using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class MovieSearch
    {
        public int SearchId { get; set; }
        
        [StringLength (450)]
        public string? MovieGenre { get; set; }

        [StringLength(450)]
        public string MovieName { get; set; } = null!;

        public bool MovieIsPopular { get; set;}

       

    }
}
