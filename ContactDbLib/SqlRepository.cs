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
            "Database = World; " +
            "Integrated Security = true";

        static public int CreateContact(string ssn, string firstName, string lastName) 
        {
            Contact newContact = new(ssn, firstName, lastName);

            return 123;
        }
        static public void ConnectionMethod()
        {
            using SqlConnection Connect = new(_connectionString);
            SqlCommand command = Connect.CreateCommand();
            command.CommandText =
                "SELECT Id,Ssn,FirstName,LastName \n" +
                "FROM Contact \n" +
                "WHERE ";




        }
        //Contact? ReadContact(int id)

        //List<Contact> ReadAllContacts()

        //bool DeleteContact(int id)

        //bool UpdateContact(int id, string ssn, string firstName, string lastName)



    }
}
