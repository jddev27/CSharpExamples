using System;

namespace EventEx
{
    public class TextService
    {
        public void OnSignUp(object source, PersonEventArgs e)
        {
            Console.WriteLine("Sending a text to phone account" + e.Person.EmailAddress);
        }
    }
}