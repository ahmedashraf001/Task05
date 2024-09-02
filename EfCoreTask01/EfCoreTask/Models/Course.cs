using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	public class Course
	{
		[Key]
		public int CrsId { get; set; }

		[Column(TypeName = "nvarchar(200)")]
		public string Title { get; set; }
		public int Credits { get; set; }
	}
}
