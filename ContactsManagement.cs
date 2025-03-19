using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
public class ContactsManagement
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>(); 
        public ContactsManagement(Dictionary<string,string> PhoneBook)
        {
            phoneBook = PhoneBook;
            
        }
        public  void AddNumber()
        {
            Console.Write("Enter the Name: ");
            string contactName = Console.ReadLine();
            Console.Write("Enter The Number: ");
            string contactNumber = Console.ReadLine();
            try {

                phoneBook.Add(contactName, contactNumber);
                csvfileManagement.SaveToCSVFile(contactName, contactNumber);
                Console.WriteLine("New contact has been Added");
                Console.WriteLine("======================");
                Console.WriteLine("");

            }
            catch
            {
                Console.WriteLine("This contact is already exist");
                
            }
            
        }
        public  void ViewNumbers()
        {
            Console.WriteLine("===================");
            csvfileManagement.ReadFromCSVFile();
            // read from csv file here and add the data to the dictionary then view it from dictionary
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"Contact Name: {contact.Key}, Phone Number: {contact.Value}");
                Console.WriteLine("===================");
            }
        }

    }
}
