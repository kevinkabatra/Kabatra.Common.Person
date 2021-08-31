namespace Kabatra.Common.Person.UnitTests.TestData
{
    using System.Net.Mail;

    public class TestEmailData
    {
        public static readonly MailAddress EmailOne = new(
            "fakeEmailOne@null.com",
            (TestPersonData.KevinFirstName + " " + TestPersonData.KevinLastName)
        );

        public static readonly MailAddress EmailTwo = new(
            "fakeEmailTwo@null.com",
            (TestPersonData.PersonOneFirstName + " " + TestPersonData.PersonOneLastName)
        );
    }
}
