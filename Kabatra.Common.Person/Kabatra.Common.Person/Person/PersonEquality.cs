namespace Kabatra.Common.Person.Person
{
    public partial class Person
    {
        public override bool Equals(object obj)
        {
            if (obj is not Person person)
            {
                return false;
            }

            return Name().Equals(person.Name())
                   && DateOfBirth().Equals(person.DateOfBirth())
                   && DateOfDeath().Equals(person.DateOfDeath())
                   && Email().Equals(person.Email())
                   && Phone().Equals(person.Phone())
                   && GetChildren().Equals(person.GetChildren())
                   && GetParents().Equals(person.GetParents());
        }

        public override int GetHashCode()
        {
            var identifier = Name() + DateOfBirth() + DateOfDeath();
            return identifier.GetHashCode();
        }
    }
}
