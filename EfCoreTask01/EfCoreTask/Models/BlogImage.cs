using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class BlogImage
	{
		[Key]
		public int BlogImageID { get; set; }
		public string Url { get; set; }
		public int BlogId { get; set; }

		public Blog Blog { get; set; }

	}
}
