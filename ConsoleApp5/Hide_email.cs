using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Hide_email
    {
        public void Hide()
        {
            Console.Write("Enter email address: ");
            string email = Console.ReadLine();
            int atIndex = email.IndexOf('@');
            if (atIndex <= 1)
                Console.WriteLine(email);


            string local = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex + 1);


            StringBuilder maskedLocal = new StringBuilder();
            maskedLocal.Append(local[0]);
            for (int i = 1; i < local.Length; i++) maskedLocal.Append('*');


            int dotIndex = domain.IndexOf('.');
            StringBuilder maskedDomain = new StringBuilder();
            if (dotIndex > 1)
            {
                maskedDomain.Append(domain[0]);
                for (int i = 1; i < dotIndex; i++) maskedDomain.Append('*');
                maskedDomain.Append(domain.Substring(dotIndex));
            }
            else
            {
                maskedDomain.Append(domain);
            }

            Console.WriteLine(maskedLocal.ToString() + "@" + maskedDomain.ToString());
        }
    }
}

