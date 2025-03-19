using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    internal class csvfileManagement
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>(); 
        static string csvfile = "file.csv";
        public csvfileManagement(Dictionary<string, string> PhoneBook, string CSVfile)
        {
            phoneBook = PhoneBook;
            csvfile = CSVfile;

        }
        public static void ReadFromCSVFile()
        {
            using (StreamReader sr = new StreamReader(csvfile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] contactinfo = line.Split(',');
                    if (!phoneBook.ContainsKey(contactinfo[0]))
                        phoneBook.Add(contactinfo[0], contactinfo[1]);
                }
            }
        }
        
     public static void SaveToCSVFile(string name, string number)
        {

            using (StreamWriter sw = new StreamWriter(csvfile, true))
            {
                sw.WriteLine($"{name},{number}");
            }

        }
    } 
}
