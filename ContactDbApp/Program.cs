﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDbLib;
using ContactDbLib.DbModels;
namespace ContactDbApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlRepository.UpdateContact(1,  "Arne", "Boardman");
            //SqlRepository.UpdateContact(3, "Arman", "Armando");
            //SqlRepository.DeleteContact(1);
            //   Console.WriteLine("input  after");
            //  Console.WriteLine(SqlRepository.CreateContact("54173233124", "Mr.test1", "testinge1"));

            //   var all = SqlRepository.ReadAllContacts();
            //  foreach (var item in all) {
            //     Console.WriteLine(item.ToString());
            //  }

            //var contact = SqlRepository.ReadContact(2);
            //Console.WriteLine(contact?.ToString());

            Contact contact = new("10101010101", "Jethro", "Tull");
            contact = SqlRepository.CreateContact(contact);
            Console.WriteLine($"ID {contact.Id}, {contact}");
        }
    }
}
