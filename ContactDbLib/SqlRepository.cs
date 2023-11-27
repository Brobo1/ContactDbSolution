using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ContactDbLib.DbModels;

namespace ContactDbLib
{
    static public class SqlRepository
    {
        private const string _connectionString =
            @"Server = (localdb)\MSSQLLocalDB; " +
            "Database = ContactDb; " +
            "Integrated Security = true";

        static public int CreateContact(string ssn, string firstName, string lastName) 
        {
            Contact newContact = new(ssn, firstName, lastName);

            using SqlConnection Connect = new(_connectionString);

            SqlCommand command = Connect.CreateCommand();
            command.CommandText =
                "SELECT Id, \n" +
                "FROM Contact \n" +
                "WHERE ssn = @ssn AND firstName = @firstName AND lastName = @lastName";

            command.Parameters.AddWithValue("@Ssn", ssn);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);


            Connect.Open();
            using SqlDataReader reader = command.ExecuteReader();

            return (int)reader[0];
        }

        //Contact? ReadContact(int id)

        //List<Contact> ReadAllContacts()

        //bool DeleteContact(int id)

        //bool UpdateContact(int id, string ssn, string firstName, string lastName)



    }
}
