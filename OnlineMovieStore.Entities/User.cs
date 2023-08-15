namespace OnlineMovieStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class User
    {
        public int UserId { get; set; }

        public int UserAge { get; set; } 
        public string UserName { get; set; } = null!;

        public string UserEmail { get; set; }

       public string? UserCountry { get; set; }

        public string UserCity { get; set; }

        public string? UserAdress { get; set; }



        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna

    }
}
