using System;
using System.Threading;

namespace EventEx
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; set; }
    }
    public class SignUp
    {
        public event EventHandler<PersonEventArgs> SignedUp;
        public void PersonSignUp(Person person)
        {
            Console.WriteLine(person.Name + " " + "is signing Up with: " + person.EmailAddress +"account" );
            Thread.Sleep(3000);

            OnSignUp(person);

        }

        protected virtual void OnSignUp(Person person)
        {
            if(SignedUp != null)
                SignedUp(this,new PersonEventArgs() {Person = person});
            
        }
    }
}