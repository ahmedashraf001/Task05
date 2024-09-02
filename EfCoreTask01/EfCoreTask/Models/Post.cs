using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int BlogId { get; set; }
		public Blog Blog { get; set; }
		public ICollection<Tag> Tags { get; set; }
		public ICollection<Post_Tag> Post_Tags { get; set; }

	}
}
