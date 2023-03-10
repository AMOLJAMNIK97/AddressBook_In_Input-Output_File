using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutPut
{
    public class FileIO
    {
        public static void WriteRecordsInFile(string path, Contact person)
        {

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.FirstNmae );
                sw.WriteLine("Last Name : " + person.LastName );
                sw.WriteLine("Address : " + person.Address);
                sw.WriteLine("City : " + person.City);
                sw.WriteLine("State : " + person.State);
                sw.WriteLine("Email : " + person.Email);
                sw.WriteLine("Zip code : " + person.Zip);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nData added successfully in file");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
        public static void ReadRecordsFromFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }

        
    }
}
