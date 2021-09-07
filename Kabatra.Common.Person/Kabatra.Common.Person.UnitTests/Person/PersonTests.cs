namespace Kabatra.Common.Person.UnitTests.Person
{
    using Common.Person.Person;
    using TestData;
    using Xunit;

    public class PersonTests
    {
        [Fact]
        public void CanCreatePerson()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);

            Assert.NotNull(person);
        }

        [Fact]
        public void CanGetName()
        {
            var person = new Person(TestPersonData.KevinFirstName, TestPersonData.KevinLastName);

            var expectedName = TestPersonData.KevinFirstName + " " + TestPersonData.KevinLastName;
            var actualName = person.Name();

            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void CanAddDateOfBirth()
        {
            var person = new Person(TestPersonData.PersonOneFirstName, TestPersonData.PersonOneLastName);
            person.DateOfBirth(TestPersonData.PersonOneDateOfBirth.Month, TestPersonData.PersonOneDateOfBirth.Day, TestPersonData.PersonOneDateOfBirth.Year);

            var actualDateOfBirth = person.DateOfBirth();

            Assert.Equal(TestPersonData.PersonOneDateOfBirth, actualDateOfBirth);
        }
    }
}
