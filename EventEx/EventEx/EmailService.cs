using System;

namespace EventEx
{
    public class EmailService
    {
        public void OnSignUp(object source, PersonEventArgs e)
        {
            Console.WriteLine("Sending an email to persons account" + e.Person.EmailAddress);
        }
    }
}