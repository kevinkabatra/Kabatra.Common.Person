namespace Kabatra.Common.Person.UnitTests.TestData
{
    using System;

    public class TestPersonData
    {
        public static readonly string KevinFirstName = "Kevin";
        public static readonly string KevinLastName = "Kabatra";

        public static readonly string PersonOneFirstName = "John";
        public static readonly string PersonOneLastName = "Smith";
        public static readonly DateOnly PersonOneDateOfBirth = new DateOnly(1950, 1, 1);

        public static readonly string PersonTwoFirstName = "John";
        public static readonly string PersonTwoLastName = "Doe";
        public static readonly DateOnly PersonTwoDateOfBirth = new DateOnly(1980, 12, 31);
    }
}
