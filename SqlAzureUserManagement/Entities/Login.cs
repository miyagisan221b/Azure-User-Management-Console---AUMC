using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matricis.SqlAzure.Entities
{
	public class Login
	{
		public Login(string name)
		{
			Name = name;
		}

		public string Name { get; private set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
