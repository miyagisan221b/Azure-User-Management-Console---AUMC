using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Matricis.SqlAzure.Entities;
using System.Data;
using Matricis.SqlAzure.Helpers;

namespace Matricis.SqlAzure.Queries
{
	public class DatabaseQueries
	{
		public static IList<Database> GetDatabases(string server, string userid, string password)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = "master";

			var databases = new List<Database>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("SELECT * FROM sys.databases order by name", conn))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						databases.Add(new Database(reader.GetString(0)));
					}
				}
			}

			return databases;
		}

		public static IList<User> GetUsers(string server, string catalog, string userid, string password)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			var users = new List<User>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open(); 

				using (SqlCommand command = new SqlCommand("SELECT * FROM sys.database_principals WHERE type_desc = 'SQL_USER' order by name", conn))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						users.Add(new User(reader.GetString(0), reader.IsDBNull(4) ? "" : reader.GetString(4)));
					}
				}
			}

			return users;
		}

		public static void DropUser(string server, string catalog, string userid, string password, string username)
		{
			//We cannot use parametrized query with DROP USER so we need to check manually for sql injection.
			string invalidstring;
			if (!SqlInjectionHelper.InvalidChars(username, out invalidstring))
			{
				throw new Exception("The username contains some invalid parts. " + invalidstring);
			}

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			var databases = new List<Database>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("DROP USER " + username, conn))
				{
					command.ExecuteNonQuery();
				}
			}
		}

		public static void CreateUser(string server, string catalog, string userid, string password, string username, string login)
		{
			//We cannot use parametrized query with CREATE USER so we need to check manually for sql injection.
			string invalidstring;
			if (!SqlInjectionHelper.InvalidChars(username, out invalidstring))
			{
				throw new Exception("The username contains some invalid parts. " + invalidstring);
			}

			if (!SqlInjectionHelper.InvalidChars(login, out invalidstring))
			{
				throw new Exception("The login contains some invalid parts. " + invalidstring);
			}

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			var databases = new List<Database>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("CREATE USER " + username + " FOR LOGIN " + login, conn))
				{
					command.ExecuteNonQuery();
				}
			}
		}

		public static IList<Role> GetUseRoles(string server, string catalog, string userid, string password, string username)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			var roles = new List<Role>();

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				string sqlcmd = "SELECT  dp.name, s.name FROM sys.database_principals AS dp " +
					"INNER JOIN sys.database_role_members on sys.database_role_members.member_principal_id = dp.principal_id " +
					"INNER JOIN sys.schemas AS s ON s.principal_id =  sys.database_role_members.role_principal_id " +
                    "WHERE dp.Name = @username order by dp.name, s.name";

				using (SqlCommand command = new SqlCommand(sqlcmd, conn))
				{
					SqlParameter userParam = command.Parameters.Add("@username", SqlDbType.NVarChar);
					userParam.Value = username;

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							roles.Add(new Role(reader.GetString(1)));
						}
					}
				}
			}

			return roles;
		}

		public static void DropRole(string server, string catalog, string userid, string password, string username, string rolename)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("sp_droprolemember", conn))
				{
					command.CommandType = System.Data.CommandType.StoredProcedure;

					SqlParameter roleParam = command.Parameters.Add("@rolename", SqlDbType.NVarChar);
					roleParam.Value = rolename;

					SqlParameter userParam = command.Parameters.Add("@membername", SqlDbType.NVarChar);
					userParam.Value = username;

					command.ExecuteReader();
				}
			}
		}

		public static void GrantRole(string server, string catalog, string userid, string password, string username, string rolename)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.UserID = userid;
			builder.DataSource = server;
			builder.Password = password;
			builder.InitialCatalog = catalog;

			using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
			{
				conn.Open();

				using (SqlCommand command = new SqlCommand("sp_addrolemember", conn))
				{
					command.CommandType = System.Data.CommandType.StoredProcedure;

					SqlParameter roleParam = command.Parameters.Add("@rolename", SqlDbType.NVarChar);
					roleParam.Value = rolename;

					SqlParameter userParam = command.Parameters.Add("@membername", SqlDbType.NVarChar);
					userParam.Value = username;

					command.ExecuteReader();
				}
			}
		}
	}
}
