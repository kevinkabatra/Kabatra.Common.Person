namespace Kabatra.Common.Person.Contact
{
    using System.Collections.Generic;
    using System.Linq;

    public class ContactInformation
    {
        private readonly List<Phone> _phones = new();
        
        public List<string> Emails { get; set; }

        public void AddPhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _phones.Add(PhoneMaker(phoneNumber, phoneType));
        }

        public List<Phone> GetAllPhones()
        {
            return _phones;
        }

        public List<Phone> GetAllPhonesByType(PhoneTypeBaseEnum phoneType)
        {
            var phonesByType = _phones.Where(phone => phone.PhoneType == phoneType).ToList();
            return phonesByType;
        }

        public void RemovePhone(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            _phones.Remove(PhoneMaker(phoneNumber, phoneType));
        }

        private static Phone PhoneMaker(string phoneNumber, PhoneTypeBaseEnum phoneType)
        {
            return new Phone
            {
                PhoneNumber = phoneNumber,
                PhoneType = phoneType
            };
        }
    }
}
