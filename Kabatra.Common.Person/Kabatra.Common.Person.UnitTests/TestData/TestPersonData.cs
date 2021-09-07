namespace Kabatra.Common.Person.UnitTests.TestData
{
    using System;
    using Common.Person.Person;

    public class TestPersonData
    {
        public static readonly string KevinFirstName = "Kevin";
        public static readonly string KevinLastName = "Kabatra";

        public static readonly string PersonOneFirstName = "John";
        public static readonly string PersonOneLastName = "Smith";
        public static readonly DateOnly PersonOneDateOfBirth = new(1950, 1, 1);

        public static readonly string PersonTwoFirstName = "John";
        public static readonly string PersonTwoLastName = "Doe";
        public static readonly DateOnly PersonTwoDateOfBirth = new(1980, 12, 31);

        public readonly Person PersonOne = new(PersonOneFirstName, PersonOneLastName);
        public readonly Person PersonTwo = new(PersonTwoFirstName, PersonTwoLastName);

        public TestPersonData()
        {
            PersonOne.DateOfBirth(PersonOneDateOfBirth.Month, PersonOneDateOfBirth.Day, PersonOneDateOfBirth.Year);
            PersonTwo.DateOfBirth(PersonTwoDateOfBirth.Month, PersonTwoDateOfBirth.Day, PersonTwoDateOfBirth.Year);
        }
    }
}
