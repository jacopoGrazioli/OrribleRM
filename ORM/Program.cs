using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            SqlWriterEntity sqlWriterEntity = new SqlWriterEntity(user);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Scrittura avvenuta con successo");

            Console.ReadLine();
        }
    }
}
