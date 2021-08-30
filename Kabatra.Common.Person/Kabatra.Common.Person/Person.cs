namespace Kabatra.Common.Person
{
    using System.Collections.Generic;
    using System.Linq;
    using Contact;

    public class Person
    {
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        private readonly string _firstName;
        private readonly string _lastName;

        private readonly ContactInformation _contactInformation;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            _contactInformation = new ContactInformation();
        }

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

        public string Name()
        {
            return _firstName + " " + _lastName;
        }

        public List<Phone> Phone()
        {
            return _contactInformation.GetAllPhones();
        }
    }
}
