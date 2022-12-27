﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        public static string REGEX_CODE = "^[A-Z]{1}[a-z]{2}$";
        public bool Validate_FirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_CODE);
        }
        public static string REGEX_LASTNAMECODE = "^[A-Z]{1}[a-z]{2}$";
        public bool Validate_LastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAMECODE);
        }
        public static string REGEX_EMAILCODE = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2})?$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAILCODE);
        }
        public static string REGEX_PHONECODE = "^+[1-9]{2}[: :][0-9]{10}$";
        public bool Validate_PhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONECODE);
        }
    }
}
