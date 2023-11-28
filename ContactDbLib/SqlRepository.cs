using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ContactDbLib.DbModels;
using System.Runtime.Intrinsics.X86;

namespace ContactDbLib
{
    static public class SqlRepository
    {
        private const string _connectionString =
            @"Server = (localdb)\MSSQLLocalDB; " +
            "Database = ContactDb; " +
            "Integrated Security = true";

        #region ContactMethods
        static public int CreateContact(string ssn, string firstName, string lastName)
        {
            using SqlConnection Connect = new(_connectionString);

            SqlCommand MakeContact = Connect.CreateCommand();
            MakeContact.CommandText =
                "INSERT INTO Contact(ssn,firstname,lastname)" +
                "VALUES (@ssn,@firstName,@lastName) \n" +
                "SELECT SCOPE_IDENTITY() AS LastIdentityValue";

            MakeContact.Parameters.AddWithValue("@Ssn", ssn);
            MakeContact.Parameters.AddWithValue("@firstName", firstName);
            MakeContact.Parameters.AddWithValue("@lastName", lastName);
            Connect.Open();
            using SqlDataReader reader = MakeContact.ExecuteReader();
            int id;
            if (reader.Read())
            {
                id = (int)(decimal)reader[0];
                return id;
            }
            else
            {
                return -1;
            }
        }

        static public Contact CreateContact(Contact contact)
        {
            contact.Id = CreateContact(contact.SSN, contact.FirstName, contact.LastName);

            return contact;
        }


        static public List<Contact> ReadAllContacts()
        {
            List<Contact> allContacts = new();

            using SqlConnection Connect = new(_connectionString);
            SqlCommand command = Connect.CreateCommand();
            command.CommandText =
                "SELECT SSN, FirstName, LastName \n" +
                "FROM Contact";

            Connect.Open();
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                allContacts.Add(new(reader[0].ToString() ?? "", reader[1].ToString() ?? "",
                                    reader[2].ToString() ?? ""));
            }

            return allContacts;
        }

        static public Contact? ReadContact(int id)
        {
            using SqlConnection connection = new(_connectionString);

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = " SELECT SSn,FirstName,LastName \n" +
                                  "FROM Contact \n" +
                                  "Where Id = @id;";

            command.Parameters.AddWithValue("@id", id);


            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new(reader[0].ToString() ?? "", reader[1].ToString() ?? "", reader[2].ToString() ?? "");
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteContact(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Contact \n" +
                                  "WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateContact(int id, string firstName, string lastName)
        {
            using SqlConnection connect = new(_connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = "update Contact \n" +
                                  "set FirstName = @firstName, LastName = @lastName \n" +
                                  "where Id = @id";

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public static bool UpdateContact(Contact contact)
        {
            SqlConnection connect = new(_connectionString);
            using SqlCommand command = connect.CreateCommand();
            command.CommandText = "update Contact \n" +
                                  "set FirstName = @firstName, LastName = @lastName \n" +
                                  "where Ssn = @ssn \n";

            command.Parameters.AddWithValue("@Ssn", contact.SSN);
            command.Parameters.AddWithValue("@firstName", contact.FirstName);
            command.Parameters.AddWithValue("@lastName", contact.LastName);
            connect.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
        #endregion


        #region AddressMethods
        public static bool DeleteAddress(int id)
        {
            SqlConnection connect = new(_connectionString);
            using SqlCommand command = connect.CreateCommand();
            command.CommandText = "DELETE FROM address \n" +
                "WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            connect.Open();
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0) { return true; }
            else { return false; }

        }

        public static int CreateAddress(string street, string city, string zip)
        {
            using SqlConnection Connect = new(_connectionString);
            SqlCommand MakeContact = Connect.CreateCommand();

            MakeContact.CommandText =
                "INSERT INTO Address(street,City,Zip)" +
                "VALUES (@Street,@City,@Zip) \n" +
                "SELECT SCOPE_IDENTITY() AS LastIdentityValue";

            MakeContact.Parameters.AddWithValue("@street", street);
            MakeContact.Parameters.AddWithValue("@city", city);
            MakeContact.Parameters.AddWithValue("@lastName", zip);
            Connect.Open();

            using SqlDataReader reader = MakeContact.ExecuteReader();
            int id;
            if (reader.Read())
            {
                id = (int)(decimal)reader[0];
                return id;
            }
            else
            {
                return -1;
            }
        }



        public static bool UpdateAddress(int id, string street, string city, string zip)
        {
            SqlConnection connect = new(_connectionString);
            using SqlCommand command = connect.CreateCommand();
            command.CommandText = "UPDATE Address \n" +
                                  "SET Street = @Street, City = @City, Zip = @Zip \n" +
                                  "where Id = @Id \n";

            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Street", street);
            command.Parameters.AddWithValue("@firstName", city);
            command.Parameters.AddWithValue("@lastName", zip);
            connect.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}