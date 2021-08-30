namespace Kabatra.Common.Person.UnitTests.Contact
{
    using System.Linq;
    using Common.Person.Contact;
    using TestData;
    using Xunit;

    public class ContactInformationTests
    {
        [Fact]
        public void CanCreateContactInformation()
        {
            var contactInformation = new ContactInformation();
            Assert.NotNull(contactInformation);
        }

        [Fact]
        public void CanAddNumberToContactInformation()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.PhoneNumber, TestPhoneData.CellPhoneOne.PhoneType);

            var actualPhone = contactInformation.GetAllPhones().First();

            Assert.Equal(TestPhoneData.CellPhoneOne.PhoneType, actualPhone.PhoneType);
            Assert.Equal(TestPhoneData.CellPhoneOne.PhoneNumber, actualPhone.PhoneNumber);
        }

        [Fact]
        public void CanAddAllSupportedPhoneTypes()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.PhoneNumber, TestPhoneData.CellPhoneOne.PhoneType);
            contactInformation.AddPhone(TestPhoneData.HomePhone.PhoneNumber, TestPhoneData.HomePhone.PhoneType);
            contactInformation.AddPhone(TestPhoneData.OfficePhone.PhoneNumber, TestPhoneData.OfficePhone.PhoneType);
            contactInformation.AddPhone(TestPhoneData.OtherPhone.PhoneNumber, TestPhoneData.OtherPhone.PhoneType);

            var actualPhones = contactInformation.GetAllPhones();

            Assert.Equal(4, actualPhones.Count);
        }

        [Fact]
        public void CanGetPhoneByType()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.PhoneNumber, TestPhoneData.CellPhoneOne.PhoneType);
            contactInformation.AddPhone(TestPhoneData.HomePhone.PhoneNumber, TestPhoneData.HomePhone.PhoneType);

            var actualPhone = contactInformation.GetAllPhonesByType(PhoneTypeBaseEnum.Cell).First();

            Assert.Equal(TestPhoneData.CellPhoneOne.PhoneType, actualPhone.PhoneType);
            Assert.Equal(TestPhoneData.CellPhoneOne.PhoneNumber, actualPhone.PhoneNumber);
        }

        [Fact]
        public void CanRemovePhone()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.PhoneNumber, TestPhoneData.CellPhoneOne.PhoneType);
            contactInformation.RemovePhone(TestPhoneData.CellPhoneOne.PhoneNumber, TestPhoneData.CellPhoneOne.PhoneType);

            var phoneOne = new Phone()
            {
                PhoneType = PhoneTypeBaseEnum.Cell,
                PhoneNumber = "(000) 000-0000"
            };

            var phoneTwo = new Phone()
            {
                PhoneType = PhoneTypeBaseEnum.Cell,
                PhoneNumber = "(000) 000-0000"
            };

            // PhoneOne and PhoneTwo do not return as equal, possibly because it is a custom object. See the following for more information
            // Stack: https://stackoverflow.com/questions/10454519/best-way-to-compare-two-complex-objects 
            // Microsoft Doc: https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-5.0
            var value = phoneOne.Equals(phoneTwo);

            Assert.Equal(phoneOne, phoneTwo);

            var actualPhones = contactInformation.GetAllPhones();

            //Assert.Empty(actualPhones);
        }
    }
}
