using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutPut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\AMD\RFP244\AddressBook_In_Input-Output_File\FileInputOutPut\ReadWriteFile.txt";

            Contact input = new Contact();
            Console.WriteLine("\nEnter your First Name : ");
            input.FirstNmae  = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.LastName  = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.Address  = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.Email = Console.ReadLine();

            

            FileIO.WriteRecordsInFile(path, input);
            Console.WriteLine("\n\nRecords present in file are : ");
            FileIO.ReadRecordsFromFile(path);
            Console.ReadLine();
        }
    }
}