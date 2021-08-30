namespace Kabatra.Common.Person.Contact
{
    using System.Collections.Generic;
    using System.Net.Mail;

    public partial class ContactInformation
    {
        private readonly List<MailAddress> _emails = new();

        public bool AddEmail(string emailAddress, string displayName)
        {
            var email = new MailAddress(emailAddress, displayName);

            // Prevent from pushing duplicates
            if (_emails.Contains(email))
            {
                return false;
            }

            _emails.Add(email);
            return true;

        }

        public List<MailAddress> GetAllEmails()
        {
            return _emails;
        }

        public bool RemoveEmail(string emailAddress, string displayName)
        {
            var email = new MailAddress(emailAddress, displayName);

            if (!_emails.Contains(email))
            {
                return false;
            }

            _emails.Remove(email);
            return true;
        }

    }
}
