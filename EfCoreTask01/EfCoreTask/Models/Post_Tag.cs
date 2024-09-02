using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class Post_Tag
	{
		public int Post_Id { get; set; }
		public int Tag_Id { get; set; }
		public DateTime Date { get; set; }

		public Post Post { get; set; }
		public Tag Tag { get; set; }

	}
}
