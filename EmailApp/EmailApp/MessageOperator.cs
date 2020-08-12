using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmailApp
{
    public class MessageOperator
    {
        public int i{ get; set; }
        public int IdRaise()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Adrian\Documents\GitHub\SzkolaDotNet\Tydzien2\EmailApp\EmailApp\Message.txt");
            
            foreach (var line in lines)
            {
                string line1 = line[4].ToString();
                Int32.TryParse(line1, out int value);
                i=value + 1;
                return i;
            }
            return i;
        }
    }
}
