using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Students
{
    public class EmailVerifier
    {
        static public bool IsValidEmail(string email)
        {
            var attribute = new EmailAddressAttribute();
            return attribute.IsValid(email);
        }
    }
}
