namespace Kabatra.Common.Person.UnitTests
{
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
    }
}
