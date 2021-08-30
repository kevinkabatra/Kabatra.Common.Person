namespace Kabatra.Common.Person.UnitTests.TestData
{
    using Common.Person.Contact;

    public class TestPhoneData
    {
        public static readonly Phone CellPhoneOne = new()
        {
            PhoneType = PhoneTypeBaseEnum.Cell,
            PhoneNumber = "(123) 123-1234"
        };

        public static readonly Phone CellPhoneTwo = new()
        {
            PhoneType = PhoneTypeBaseEnum.Cell,
            PhoneNumber = "(321) 321-4321"
        };

        public static readonly Phone HomePhone = new()
        {
            PhoneType = PhoneTypeBaseEnum.Home,
            PhoneNumber = "(213) 213-2134"
        };

        public static readonly Phone OfficePhone = new()
        {
            PhoneType = PhoneTypeBaseEnum.Office,
            PhoneNumber = "(312) 312-3124"
        };

        public static readonly Phone OtherPhone = new()
        {
            PhoneType = PhoneTypeBaseEnum.Other,
            PhoneNumber = "(000) 000-0000"
        };
    }
}
