namespace Kabatra.Common.Person.Contact
{
    public class Phone
    {
        private readonly string _phoneNumber;
        private readonly PhoneTypeBaseEnum _phoneType;

        public Phone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _phoneNumber = phoneNumber;
            _phoneType = phoneType;
        }

        /// <summary>
        ///     Determines whether two phone instances are equal.
        /// </summary>
        /// <param name="obj">A Phone object.</param>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-5.0"/>
        /// <returns>True if equal, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is not Phone phone)
            {
                return false;
            }
            else
            {
                return _phoneNumber.Equals(phone.GetPhoneNumber()) 
                       && _phoneType.Equals(phone.GetPhoneType());
            }
        }

        /// <summary>
        ///     A hash code is a numeric value that is used to insert and identify an object in a hash-based collection such a Dictionary or Hashtable.
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-5.0#remarks"/>
        /// <remarks>
        ///     1. Different implementations of .NET (Core, Framework) will return different hash codes.
        ///     2. .NET (Core and .NET 5.0 +) will return a different value with each application instance, therefore do not store this value for later usage.
        /// </remarks>
        /// <returns>Hash code representing a Phone.</returns>
        public override int GetHashCode()
        {
            var identifier = _phoneNumber + _phoneType;
            return identifier.GetHashCode();
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public PhoneTypeBaseEnum GetPhoneType()
        {
            return _phoneType;
        }
    }
}
