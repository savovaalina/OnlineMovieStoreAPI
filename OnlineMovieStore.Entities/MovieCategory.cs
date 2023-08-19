namespace OnlineMovieStore.Entities
{

	using System.ComponentModel.DataAnnotations;

    public class MovieCategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength (90)]
        public string Genre { get; set; } = null!; //zhanr

        public string? LastUpdate { get; set; } //najnov dodaden film


		//TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna
		public virtual ICollection<Movie>? Movie { get; set; }


	}
}
