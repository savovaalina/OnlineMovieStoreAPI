using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Shows
    {

        public int ShowId { get; set; }

        public string ShowName { get; set; } = null!;
        public string? ShowDescription { get; set; }

        public string ShowType { get; set; }

    }
}
