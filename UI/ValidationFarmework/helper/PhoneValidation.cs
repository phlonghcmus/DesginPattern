using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI.ValidationFarmework.helper
{
    internal class PhoneValidation : Project.ValidationFarmework.helper.ValidationHelper
    {
        public override bool IsValid(string valueValidate)
        {
            return Regex.IsMatch(valueValidate, @"(84|0[3|5|7|8|9])+([0-9]{8})\b");
        }
    }
}
