using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matricis.SqlAzure.Helpers
{
	public static class SqlInjectionHelper
	{
		public static bool InvalidChars(string input, out string invalidPart)
		{
			invalidPart = null;

			//Create an array of invalid characters and words
			char[] invalidChars = new char[] { '\'', '(', ')', '/', '#', '%', '&', '\\', ':', ';', '<', '>', '=', '[', ']', '?', '`', '|'};

			if (input.IndexOfAny(invalidChars) > -1)
			{
				invalidPart = @"Verify that the following characters are not present: ' ( ) / # % & \ : ; < > = [ ] ? ` |";
				return false;
			}

			string[] invalidStrings = new string[] {"select", "drop", "--", "insert", "delete", "xp_"};
			foreach(string invstr in invalidStrings)
			{
				if(input.IndexOf(invstr) > -1)
				{
					invalidPart = "Verify that the following string is not present: " + invstr;
					return false;
				}
			}

			return true;
		}
	}
}
