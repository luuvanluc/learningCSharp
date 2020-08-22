using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08_StringVaStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // String/string is immutable. StringBuilder is mutable
            String FirstName = "Luc";
            String LastName = "Luu Van ";
            String FullName = LastName + FirstName;

            Console.WriteLine("Ho va ten: " + FullName);
            Console.WriteLine("Do dai ho ten: " + FullName.Length);

            // StringBuilder is recommended to proceed large string
            StringBuilder strBuilder = new StringBuilder("Hello ");
            strBuilder.Append("World!");
            Console.WriteLine(strBuilder);

            Console.ReadLine();

        }
    }
}
