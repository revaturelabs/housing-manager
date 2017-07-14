using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class ContactInfo
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as ContactInfo;

            return (o.Email == Email && o.PhoneNumber == PhoneNumber);
        }

        public override int GetHashCode()
        {
            return (Email.GetHashCode() + PhoneNumber.GetHashCode());
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
    }
}