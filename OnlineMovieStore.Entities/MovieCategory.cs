namespace OnlineMovieStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MovieCategory
    {

        public int CategoryId { get; set; }
        public string CategoryType { get; set; } = null!;

        public string LastUpdate { get; set; }


        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna



    }
}
