using System;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace BlabberApp.Domain.Entities
{
    public class User : BaseEntity
    {
        public DateTime RegisterDTTM { get; set; }

        public DateTime LastLoginDTTM { get; set; }

        public string Email { get; private set; }
        public void ChangeEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 50)
                throw new FormatException("Email is invalid");
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                throw new FormatException("Email is invalid");
            }
            Email = email;

        }
    }
}