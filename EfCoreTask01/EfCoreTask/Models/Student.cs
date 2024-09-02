using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	[Table("SStudents", Schema = "MySchema")]
	public class Student
	{
		[Key]
		public int StId { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[Column("AAge")]
		public int Age { get; set; }
		public string ID_Age { get; set; }

	}
}
