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

            var emailsAreEqual = GetEmailEquality(person);

            return Name().Equals(person.Name())
                   && DateOfBirth().Equals(person.DateOfBirth())
                   && DateOfDeath().Equals(person.DateOfDeath())
                   && emailsAreEqual
                   && Phone().Equals(person.Phone())
                   && GetChildren().Equals(person.GetChildren())
                   && GetParents().Equals(person.GetParents());
        }

        public override int GetHashCode()
        {
            var identifier = Name() + DateOfBirth() + DateOfDeath();
            return identifier.GetHashCode();
        }

        /// <summary>
        ///     MailAddress will return false for an equality check if both emails are empty, so this wraps that call to fix that issue.
        /// </summary>
        /// <param name="person">The Person to compare to.</param>
        /// <returns>Boolean. True if equal, else false.</returns>
        private bool GetEmailEquality(Person person)
        {
            if (Email().Count == 0 && person.Email().Count == 0)
            {
                return true;
            }

            return Email().Equals(person.Email());
        }
    }
}
