using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class PhotoMovie
    {
        public int PhotoId { get; set; }

        public string Url { get; set; } = null!; // Ova ke ni kazuva kaj se naoga slikata

        public DateTime DateAdded { get; set; } //Koga e stavena slikata

        public bool IsMain { get; set;} //dali e cover slikata- udarna prva slika

         //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna

    }
}
