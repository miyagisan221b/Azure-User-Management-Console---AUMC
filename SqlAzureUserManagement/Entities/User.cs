using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matricis.SqlAzure.Entities
{
	public class User
	{
		public User(string name, string schema)
		{
			Name = name;
			DefaultSchema = schema;
		}

		public string Name { get; private set; }
		public string DefaultSchema { get; private set; }
	}
}
