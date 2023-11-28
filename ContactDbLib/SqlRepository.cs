using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ContactDbLib.DbModels;

namespace ContactDbLib {
	static public class SqlRepository {
		private const string _connectionString =
			@"Server = (localdb)\MSSQLLocalDB; " +
			"Database = ContactDb; "             +
			"Integrated Security = true";

		static public int CreateContact(string ssn, string firstName, string lastName) {

			using SqlConnection Connect = new(_connectionString);

			SqlCommand MakeContact = Connect.CreateCommand();
			MakeContact.CommandText =
				"INSERT INTO Contact(ssn,firstname,lastname)" +
				"VALUES (@ssn,@firstName,@lastName) \n"  +

				"SELECT SCOPE_IDENTITY() AS LastIdentityValue";

			MakeContact.Parameters.AddWithValue("@Ssn",       ssn);
			MakeContact.Parameters.AddWithValue("@firstName", firstName);
			MakeContact.Parameters.AddWithValue("@lastName",  lastName);
            Connect.Open();
			using SqlDataReader reader = MakeContact.ExecuteReader();
			int id;
			if (reader.Read()) 
			{
				id = (int)(decimal)reader[0];
				return id;
			}
			else { return -1; }
		}

		static public List<Contact> ReadAllContacts() {
			List<Contact> allContacts = new();

			using SqlConnection Connect = new(_connectionString);
			SqlCommand          command = Connect.CreateCommand();
			command.CommandText =
				"SELECT SSN, FirstName, LastName \n" +
				"FROM Contact";

			Connect.Open();
			using SqlDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				allContacts.Add(new(reader[0].ToString() ?? "", reader[1].ToString() ?? "",
				                    reader[2].ToString() ?? ""));
			}

			return allContacts;
		}
        static public Contact ReadContact(int id)
        {
           
            using SqlConnection connection = new(_connectionString);

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = " SELECT SSn,FirstName,LastName \n" +
                "FROM Contact \n" +
                "Where Id = @id;";

			command.Parameters.AddWithValue("@id", id);

			connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

			return new(reader[0].ToString() ?? "", reader[1].ToString() ?? "", reader[2].ToString() ?? "");

        }

        public static bool DeleteContact(int id) {
			using SqlConnection connection = new(_connectionString);
			connection.Open();
			using SqlCommand command = connection.CreateCommand();
			command.CommandText = "DELETE FROM Contact \n" +
			                      "WHERE id = @id";
			command.Parameters.AddWithValue("@id", id);
			int rowsAffected = command.ExecuteNonQuery();
			if (rowsAffected >= 1) {
				return true;
			} else {
				return false;
			}
		}

		public static bool UpdateContact(int id, string firstName, string lastName) {
			using SqlConnection connect = new(_connectionString);
			connect.Open();
			SqlCommand command = connect.CreateCommand();
			command.CommandText = "update Contact \n"                                        +
			                      "set FirstName = @firstName, LastName = @lastName \n" +
			                      "where Id = @id";

			command.Parameters.AddWithValue("@firstName", firstName);
			command.Parameters.AddWithValue("@lastName",  lastName);
			command.Parameters.AddWithValue("@id",        id);
			int rowsAffected = command.ExecuteNonQuery();
			if (rowsAffected > 0 ) {
				return true;
			}
			return false;
			
		}
	}
}