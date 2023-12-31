﻿using System;
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

			//Console.WriteLine(SqlRepository.CreateContactInformation("blalba", true, 4));

			//int newInfo = SqlRepository.CreateContactInformation("", false, 0);
			//SqlRepository.ReadContactInformation(newInfo);

			//List<ContactInformation> x = SqlRepository.ReadContactInformationList();
			//foreach(ContactInformation y in x) { Console.WriteLine(y.ToString()); }

			//ContactInformation? yasdf = SqlRepository.ReadContactInformation(1);
            //Console.WriteLine(yasdf.ToString());

            var list = SqlRepository.ReadAllContacts();

            foreach (var item in list) {
	            Console.WriteLine(item.Id);
            }

            Console.WriteLine(SqlRepository.UpdateContact(list[0].Id, "Agus", "Scapusio"));
            SqlRepository.UpdateContact(list[1].Id, "Arner", "Brettman");
            SqlRepository.UpdateContact(list[2].Id, "Barne", "Arne");
            SqlRepository.UpdateContact(list[3].Id, "Arnes", "Barne");

		}
    }
}