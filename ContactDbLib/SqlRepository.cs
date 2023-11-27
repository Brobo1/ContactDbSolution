﻿using System;
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

        static bool DeleteContact(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Contacts " +
                "WHERE id = @id";

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected >= 1)
            { return true; }

            else { return false; }
        }

        //bool UpdateContact(int id, string ssn, string firstName, string lastName)



    }
}
