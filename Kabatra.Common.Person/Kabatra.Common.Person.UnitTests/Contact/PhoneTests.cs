namespace Kabatra.Common.Person.UnitTests.Contact
{
    using Common.Person.Contact;
    using TestData;
    using Xunit;

    public class PhoneTests
    {
        [Fact]
        public void CanCreatePhone()
        {
            var phone = new Phone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            Assert.NotNull(phone);
        }

        [Fact]
        public void CanVerifyEqualPhone()
        {
            var phone = new Phone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            var equal = phone.Equals(TestPhoneData.CellPhoneOne);
            
            Assert.True(equal);
        }

        [Fact]
        public void CanVerifyNonEqualPhone()
        {
            var phone = new Phone(TestPhoneData.CellPhoneOne.GetPhoneNumber(), TestPhoneData.CellPhoneOne.GetPhoneType());
            var equal = phone.Equals(TestPhoneData.CellPhoneTwo);

            Assert.False(equal);
        }

    }
}
