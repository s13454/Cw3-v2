﻿using Cw3_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3_v2.DAL
{
	public interface IDbService
	{
		public IEnumerable<Student> GetStudents();
	}
}
