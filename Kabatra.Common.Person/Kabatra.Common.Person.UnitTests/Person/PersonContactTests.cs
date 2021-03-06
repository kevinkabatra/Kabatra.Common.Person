namespace Kabatra.Common.Person.UnitTests.Person
{
    using System.Linq;
    using Common.Person.Person;
    using TestData;
    using Xunit;

    public class PersonContactTests
    {
        [Fact]
        public void CanAddEmail()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);
            person.AddEmail(TestEmailData.EmailOne.Address);

            var actualEmailAddress = person.Email().First();

            Assert.Equal(TestEmailData.EmailOne.Address, actualEmailAddress);
        }

        [Fact]
        public void CanAddPhone()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);
            person.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());

            var actualPhone = person.Phone().First();

            Assert.Equal(TestPhoneData.CellPhoneOne, actualPhone);
        }

        [Fact]
        public void CanRemoveEmail()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);
            person.AddEmail(TestEmailData.EmailOne.Address);
            person.RemoveEmail(TestEmailData.EmailOne.Address);

            var actualEmailAddresses = person.Email();

            Assert.Empty(actualEmailAddresses);
        }

        [Fact]
        public void CanRemovePhone()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);
            person.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            person.RemovePhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());

            var actualPhones = person.Phone();

            Assert.Empty(actualPhones);
        }
    }
}
