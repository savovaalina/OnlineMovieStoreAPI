using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Login
    {

        public int LoginId { get; set; }

        public string LoginUsername { get; set; } = null!;


        public string LoginUsernameee { get; set; } //proba
        public byte[] PasswordHash { get; set; } = null!; //vaka e poso se enkriptira vo arrey od byte


        public byte[] PasswordSalt { get; set; } = null!;//random generiranje na brojce koi sto ke pomaga pri enkripcijata na PasswordHash

        //public string LoginPassword { get; set; } = null!;

        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna

    }
}
