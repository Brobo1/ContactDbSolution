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
            SqlRepository.UpdateContact(1, "22123243", "Arne", "Boardman");
            SqlRepository.UpdateContact(3, "22123243", "Arman", "Boardman");
            var all = SqlRepository.ReadAllContacts();

            foreach (var item in all) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
