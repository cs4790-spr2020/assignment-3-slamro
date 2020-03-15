using System;
using System.Net.Mail;
namespace BlabberApp.Domain.Entities
{
    public class User : BaseEntity
    {
        private System.DateTime _regDTTM;
        public System.DateTime RegDttm
        {
            get {return this._regDTTM;}
            set {this._regDTTM = value;}
        }

        private System.DateTime _lastLoginDTTM;
        public System.DateTime LastLogin
        {
            get{return this._lastLoginDTTM;}
            set{this._lastLoginDTTM = value;}
        }
       
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