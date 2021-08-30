namespace Kabatra.Common.Person.UnitTests.Contact
{
    using System.Linq;
    using Common.Person.Contact;
    using TestData;
    using Xunit;

    public class ContactInformationEmailTests
    {
        [Fact]
        public void CanAddEmailToContactInformation()
        {
            var contactInformation = new ContactInformation();
            var result = contactInformation.AddEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            Assert.True(result);

            var actualEmail = contactInformation.GetAllEmails().First();
            
            Assert.Equal(TestEmailData.EmailOne, actualEmail);
        }

        [Fact]
        public void CanAddMultipleEmailsToContactInformation()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            var result = contactInformation.AddEmail(TestEmailData.EmailTwo.Address, TestEmailData.EmailTwo.DisplayName);

            var actualEmails = contactInformation.GetAllEmails();

            Assert.Equal(2, actualEmails.Count);
        }

        [Fact]
        public void CannotAddDuplicateEmails()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            var result = contactInformation.AddEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            
            Assert.False(result);
        }

        [Fact]
        public void CanRemoveSpecifiedEmail()
        {
            var contactInformation = new ContactInformation();
            contactInformation.AddEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            var result = contactInformation.RemoveEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            Assert.True(result);

            var actualEmails = contactInformation.GetAllEmails();

            Assert.Empty(actualEmails);
        }

        [Fact]
        public void CannotRemoveEmailIfNotPresent()
        {
            var contactInformation = new ContactInformation();
            var result = contactInformation.RemoveEmail(TestEmailData.EmailOne.Address, TestEmailData.EmailOne.DisplayName);
            
            Assert.False(result);
        }
    }
}
