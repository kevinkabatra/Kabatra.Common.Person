namespace Kabatra.Common.Person.Person
{
    using System;

    public partial class Person
    {
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;

        private DateOnly _dateOfBirth;
        private DateOnly _dateOfDeath;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            InitializeContact();
        }

        public Person(string firstName, string middleName, string lastName)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;

            InitializeContact();
        }

        public DateOnly DateOfBirth(int month = 0, int day = 0, int year = 0)
        {
            if (month != 0)
            {
                DateOfBirth(new DateOnly(year, month, day));
            }

            return _dateOfBirth;
        }

        public void DateOfBirth(DateOnly dateOfBirth)
        {
            _dateOfBirth = dateOfBirth;
        }

        public DateOnly DateOfDeath(int month = 0, int day = 0, int year = 0)
        {
            if (month != 0)
            {
                _dateOfDeath = new DateOnly(year, month, day);
            }

            return _dateOfDeath;
        }

        public void DateOfDeath(DateOnly dateOfDeath)
        {
            _dateOfDeath = dateOfDeath;
        }

        public string Name()
        {
            if (string.IsNullOrEmpty(_middleName))
            {
                return _firstName + " " + _lastName;
            }

            return _firstName + " " + _middleName + " " + _lastName;
        }

        private partial void InitializeContact();
    }
}
