using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matricis.SqlAzure.Entities
{
	public class Database
	{
		public Database(string name)
		{
			Name = name;
		}

		public string Name { get; private set; }
	}
}
