namespace Kabatra.Common.Person.Person
{
    using System.Collections.Generic;
    using System.Linq;
    using Contact;

    public partial class Person
    {
        private ContactInformation _contactInformation;

        public void AddEmail(string emailAddress)
        {
            _contactInformation.AddEmail(emailAddress, Name());
        }

        public void AddPhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _contactInformation.AddPhone(phoneNumber, phoneType);
        }

        public void RemoveEmail(string emailAddress)
        {
            _contactInformation.RemoveEmail(emailAddress, Name());
        }

        public void RemovePhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _contactInformation.RemovePhone(phoneNumber, phoneType);
        }

        public List<string> Email()
        {
            return _contactInformation.GetAllEmails().Select(email => email.Address).ToList();
        }

        public List<Phone> Phone()
        {
            return _contactInformation.GetAllPhones();
        }

        private partial void InitializeContact()
        {
            _contactInformation = new ContactInformation();
        }
    }
}
