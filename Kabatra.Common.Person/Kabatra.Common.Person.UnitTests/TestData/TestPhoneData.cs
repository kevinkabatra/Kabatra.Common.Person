namespace Kabatra.Common.Person.UnitTests.TestData
{
    using Common.Person.Contact;

    public class TestPhoneData
    {
        public static readonly Phone CellPhoneOne = new("(123) 123-1234", PhoneTypeBaseEnum.Cell);
        public static readonly Phone CellPhoneTwo = new("(321) 321-4321", PhoneTypeBaseEnum.Cell);
        public static readonly Phone HomePhone = new("(213) 213-2134", PhoneTypeBaseEnum.Home);
        public static readonly Phone OfficePhone = new("(312) 312-3124", PhoneTypeBaseEnum.Office);
        public static readonly Phone OtherPhone = new("(000) 000-0000", PhoneTypeBaseEnum.Other);
    }
}
