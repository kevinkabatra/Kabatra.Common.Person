namespace Kabatra.Common.Person.Contact
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class ContactInformation
    {
        private readonly List<Phone> _phones = new();

        public void AddPhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _phones.Add(new Phone(phoneNumber, phoneType));
        }

        public List<Phone> GetAllPhones()
        {
            return _phones;
        }

        public List<Phone> GetAllPhonesByType(PhoneTypeBaseEnum phoneType)
        {
            var phonesByType = _phones.Where(phone => phone.GetPhoneType() == phoneType).ToList();
            return phonesByType;
        }

        public void RemovePhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _phones.Remove(new Phone(phoneNumber, phoneType));
        }
    }
}
