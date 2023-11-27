using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        }
   
        //Contact? ReadContact(int id)


        //List<Contact> ReadAllContacts()

        //bool DeleteContact(int id)
        //bool UpdateContact(int id, string ssn, string firstName, string lastName)



    }
}
