namespace Kabatra.Common.Person.UnitTests.Contact
{
    using System.Linq;
    using Common.Person.Contact;
    using TestData;
    using Xunit;

    public class ContactInformationPhoneTests
    {
        [Fact]
        public void CanAddNumberToContactInformation()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());

            var actualPhone = contactInformation.GetAllPhones().First();

            Assert.Equal(TestPhoneData.CellPhoneOne.GetPhoneType(), actualPhone.GetPhoneType());
            Assert.Equal(TestPhoneData.CellPhoneOne.GetPhoneNumber(), actualPhone.GetPhoneNumber());
        }

        [Fact]
        public void CanAddAllSupportedPhoneTypes()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            contactInformation.AddPhone(TestPhoneData.HomePhone.GetPhoneNumber(), TestPhoneData.HomePhone.GetPhoneType());
            contactInformation.AddPhone(TestPhoneData.OfficePhone.GetPhoneNumber(), TestPhoneData.OfficePhone.GetPhoneType());
            contactInformation.AddPhone(TestPhoneData.OtherPhone.GetPhoneNumber(), TestPhoneData.OtherPhone.GetPhoneType());

            var actualPhones = contactInformation.GetAllPhones();

            Assert.Equal(4, actualPhones.Count);
        }

        [Fact]
        public void CanAddMultipleOfSameSupportedPhoneType()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            contactInformation.AddPhone(TestPhoneData.CellPhoneTwo.GetPhoneNumber(), TestPhoneData.CellPhoneTwo.GetPhoneType());

            var actualPhones = contactInformation.GetAllPhones();

            Assert.Equal(2, actualPhones.Count);
        }

        [Fact]
        public void CanGetPhoneByType()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            contactInformation.AddPhone(TestPhoneData.HomePhone.GetPhoneNumber(), TestPhoneData.HomePhone.GetPhoneType());

            var actualPhone = contactInformation.GetAllPhonesByType(PhoneTypeBaseEnum.Cell).First();

            Assert.Equal(TestPhoneData.CellPhoneOne.GetPhoneType(), actualPhone.GetPhoneType());
            Assert.Equal(TestPhoneData.CellPhoneOne.GetPhoneNumber(), actualPhone.GetPhoneNumber());
        }

        [Fact]
        public void CanRemovePhone()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddPhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            contactInformation.RemovePhone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());

            var actualPhones = contactInformation.GetAllPhones();
            Assert.Empty(actualPhones);
        }
    }
}
