using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace EventEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var juan = new Person(){Name = "Juan", EmailAddress = "jjjj@gmail.com"};
            var sign = new SignUp(); //publisher
            var emailService = new EmailService(); //subscriber
            var textService = new TextService();

            sign.SignedUp += emailService.OnSignUp;
            sign.SignedUp += textService.OnSignUp;

            sign.PersonSignUp(juan);


        }

       

    }
}