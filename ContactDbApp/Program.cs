using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDbLib;
using ContactDbLib.DbModels;
using Microsoft.Data.SqlClient;

namespace ContactDbApp {
	internal class Program {
		static void Main(string[] args) {
			//SqlRepository.UpdateContact(1,  "Arne", "Boardman");
			//SqlRepository.UpdateContact(3, "Arman", "Armando");
			//SqlRepository.DeleteContact(1);
			//   Console.WriteLine("input  after");
			//  Console.WriteLine(SqlRepository.CreateContact("54173233124", "Mr.test1", "testinge1"));

			//   var all = SqlRepository.ReadAllContacts();
			//  foreach (var item in all) {
			//     Console.WriteLine(item.ToString());
			//  }

			// Contact contact = new("10101010101", "Alice", "Cooper");
			//  SqlRepository.CreateContact(contact);
			// Console.WriteLine(SqlRepository.UpdateContact(contact));
			// SqlRepository.DeleteContact(1002);

			//var contact = SqlRepository.ReadContact(2);
			//Console.WriteLine(contact?.ToString());
			//Contact cont = new("54176413124", "Barne", "marne");
			//SqlRepository.UpdateContact(cont);

			//Contact JethroTull = new("10101010101", "Jethro", "Tull");
			//JethroTull = SqlRepository.CreateContact(JethroTull);
			//Console.WriteLine($"ID {JethroTull.Id}, {JethroTull}");

			//Contact NewData = new("10101010101", "Jethro", "Tull");
			//Console.WriteLine(SqlRepository.UpdateContact(NewData)); 

			//SqlRepository.DeleteAddress(1);
			//SqlRepository.CreateAddress("Kongsburger veien", "Kongsburger", "1653");
			//SqlRepository.UpdateAddress(1, "kognsebgig", "oijergqwe", "1253");

			//SqlRepository.DeleteContactInformation(1);


			//SqlRepository.CreateAddress("Maukenveien", "Skjold", "9066");

			//Address newAddress = new("Street", "City", "ZIP00");
			//newAddress = SqlRepository.CreateAddress(newAddress);
			//Console.WriteLine($"{newAddress.Id}: {newAddress}");

			Console.WriteLine(SqlRepository.CreateContactInformation("asfgre", true, 2));

			//int newInfo = SqlRepository.CreateContactInformation("dfdgpm", false, 3);
			//Console.WriteLine(SqlRepository.ReadContactInformation(1));
			
		}
    }
}