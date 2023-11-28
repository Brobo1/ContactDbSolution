using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDbLib;
namespace ContactDbApp
{
    internal class Program
    {
        static void Main(string[] args) {
            SqlRepository.UpdateContact(1,  "Arne", "Boardman");
            SqlRepository.UpdateContact(3, "Arman", "Armando");
            var all = SqlRepository.ReadAllContacts();

            foreach (var item in all) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
