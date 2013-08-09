using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DumpCredentials
{
    class Program
    {
        static void DumpCredentials(Windows.Security.Credentials.PasswordCredential cred)
        {
            Console.WriteLine("Resource: {0}", cred.Resource);
            Console.WriteLine("UserName: {0}", cred.UserName);
            Console.WriteLine("Password: {0}", cred.Password);
        }
        static void Main(string[] args)
        {
            Windows.Security.Credentials.PasswordVault vault = new Windows.Security.Credentials.PasswordVault();
            Console.WriteLine("{0}", vault.GetType());
            foreach (var cred in vault.RetrieveAll())
            {
                cred.RetrievePassword();
                DumpCredentials(cred);
            }

        }
    }
}

