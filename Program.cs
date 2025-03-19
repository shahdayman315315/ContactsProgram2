using ConsoleApp9;

namespace ContactsProgram
{
    class Program
    {

        public static Dictionary<string, string> phoneBook = new Dictionary<string, string>(); // this dict will save the data of the contacts

        public static string csvfile = "file.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To PhoneBook");
            csvfileManagement csvfileManagement = new csvfileManagement(phoneBook, csvfile);
            ContactsManagement contactsManagement = new ContactsManagement(phoneBook);

            bool running = true;

            while (running)
            {
                ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        contactsManagement.AddNumber();
                        break;
                    case 2:
                        contactsManagement.ViewNumbers();
                        break;
                    case 3:
                        running = false;
                        break;
                }
            }

        }

        static void ShowMenu()
        {
            Console.WriteLine($"1.Add New Number {'\n'}2.View Numbers{'\n'}3.Exit");
        }
        

       

        
       
    }
   
}