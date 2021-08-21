using System;
using System.Text;

namespace StringBuilderMethod
{
    public class Demo
    {
        static void Main()
        {
            // Program AppendFormat
            StringBuilder String = new StringBuilder();

            String.AppendFormat("{0:1} ", "Advik Pune").Replace(" ", "-");

            String S = String.ToString().ToUpper();

            String.Length = 0;

            String.Append(S).Insert(11, "ProgrammingDigest-");

            S = String.ToString();

            Console.WriteLine(S);

            Console.ReadLine();

            // Program for Replace
            const string value = "Advik Pune";

            StringBuilder String1 = new StringBuilder(value);

            Console.Write("old String is: " + value + "\n\n");

            String1.Replace("Advik Pune", "ProgrammingDigest");

            Console.WriteLine("New String is: " + String1);

            Console.ReadLine();

            // Program for remove 
            string val = "Advik Pune";
            string charRemove = val.Remove(val.Length - 1, 1);

            Console.WriteLine(charRemove);

            Console.ReadLine();


            // Program for Insert
            const string Value2 = "Programming";

            StringBuilder String3 = new StringBuilder(Value2);

            Console.WriteLine("Old String: " + String3);

            String3.Insert(11, "Digest");

            Console.WriteLine("New String: " + String3);
            Console.ReadLine();

            // Program for append

            const string value3 = "Programming";

            StringBuilder String4 = new StringBuilder(value3);

            String4.Append("Digest");

            Console.WriteLine(String4);

            Console.ReadLine();


        }
    }
}


 


