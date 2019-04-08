using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Matricis.SqlAzure.Entities;
using Matricis.SqlAzure.Helpers;

namespace Matricis.SqlAzure.Queries
{
	public class LoginQueries
	{
		public static IList<Login> GetLogins(string server, string userid, string password)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = "master";

			var logins = new List<Login>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("SELECT * FROM sys.sql_logins order by name", conn))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						logins.Add(new Login(reader.GetString(0)));
					}
				}
			}

			return logins;
		}

		public static void CreateLogin(string server, string userid, string password, string loginname, string loginpassword)
		{
			//We cannot use parametrized query with CREATE LOGIN so we need to check manually for sql injection.
			string invalidstring;
			if (!SqlInjectionHelper.InvalidChars(loginname, out invalidstring))
			{
				throw new Exception("The loginname contains some invalid parts. " + invalidstring);
			}

			if (!SqlInjectionHelper.InvalidChars(loginpassword, out invalidstring))
			{
				throw new Exception("The password contains some invalid parts. " + invalidstring);
			}

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = "master";

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("CREATE LOGIN [" + loginname + "] WITH PASSWORD = '" + loginpassword + "'", conn))
				{
					command.ExecuteNonQuery();
				}
			}
		}

		public static void DeleteLogin(string server, string userid, string password, string loginname)
		{
			//We cannot use parametrized query with DROP LOGIN so we need to check manually for sql injection.
			string invalidstring;
			if (!SqlInjectionHelper.InvalidChars(loginname, out invalidstring))
			{
				throw new Exception("The loginname contains some invalid parts. " + invalidstring);
			}

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = "master";

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("DROP LOGIN [" + loginname + "]", conn))
				{
					command.ExecuteNonQuery();
				}
			}
		}
	}
}
