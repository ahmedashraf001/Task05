using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class Tag
	{
		public int TagID { get; set; }
		public string Name { get; set; }

		public ICollection<Post> Posts { get; set; }
		public ICollection<Post_Tag> Post_Tags { get; set; }

	}
}
