namespace Kabatra.Common.Person.UnitTests.Contact
{
    using Common.Person.Contact;
    using Xunit;

    public class ContactInformationTests
    {
        [Fact]
        public void CanCreateContactInformation()
        {
            var contactInformation = new ContactInformation();
            Assert.NotNull(contactInformation);
        }
    }
}
