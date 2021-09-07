namespace Kabatra.Common.Person.UnitTests.Person
{
    using System.Linq;
    using TestData;
    using Xunit;

    public class PersonFamilyTests
    {
        [Fact]
        public void CanAddChildToPerson()
        {
            var testDataHandler = new TestPersonData();
            testDataHandler.PersonOne.AddChild(testDataHandler.PersonTwo);

            var actualChildren = testDataHandler.PersonOne.GetChildren().First();

            Assert.Equal(testDataHandler.PersonTwo, actualChildren);
        }

        [Fact]
        public void CanRemoveChildFromPerson()
        {
            var testDataHandler = new TestPersonData();
            testDataHandler.PersonOne.AddChild(testDataHandler.PersonTwo);
            var result = testDataHandler.PersonOne.RemoveChild(testDataHandler.PersonTwo);
            Assert.True(result);

            var actualChildren = testDataHandler.PersonOne.GetChildren();

            Assert.Empty(actualChildren);
        }

        [Fact]
        public void CanAddParentToPerson()
        {
            var testDataHandler = new TestPersonData();
            testDataHandler.PersonOne.AddParent(testDataHandler.PersonTwo);

            var actualParents = testDataHandler.PersonOne.GetParents().First();

            Assert.Equal(testDataHandler.PersonTwo, actualParents);
        }

        [Fact]
        public void CanRemoveParentFromPerson()
        {
            var testDataHandler = new TestPersonData();
            testDataHandler.PersonOne.AddParent(testDataHandler.PersonTwo);
            var result = testDataHandler.PersonOne.RemoveParent(testDataHandler.PersonTwo);
            Assert.True(result);

            var actualParents = testDataHandler.PersonOne.GetParents();

            Assert.Empty(actualParents);
        }
    }
}
