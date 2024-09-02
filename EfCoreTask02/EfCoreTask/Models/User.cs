﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask.Models
{
	[Table("Users")]
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		[MaxLength(250)]
		public string Email { get; set; }
	}
}
