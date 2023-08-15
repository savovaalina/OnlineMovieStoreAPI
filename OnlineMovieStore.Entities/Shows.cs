using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
	public class Shows
	{

		public int ShowId { get; set; }

		[StringLength(250)]
		public string ShowName { get; set; } = null!;

		[StringLength(450)]
		public string? ShowDescription { get; set; }

		[StringLength(150)]
		public string ShowType { get; set; }

	}
}
