namespace Kabatra.Common.Person
{
    using System.Collections.Generic;
    using Contact;

    public class Person
    {
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        private readonly string _firstName;
        private readonly string _lastName;

        private ContactInformation _contactInformation;

        public Person(string firstName, string lastName, ContactInformation contactInformation = null)
        {
            _firstName = firstName;
            _lastName = lastName;
            _contactInformation = contactInformation;
        }

        public string Name()
        {
            return _firstName + " " + _lastName;
        }
    }
}
