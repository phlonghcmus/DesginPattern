using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI.ValidationFarmework.helper
{
    internal class RegexValidation : Project.ValidationFarmework.helper.ValidationHelper
    {
        public override bool IsValid(string valueValidate)
        {

            if (string.IsNullOrWhiteSpace(valueValidate)) return false;

            try
            {
                Regex.Match("", valueValidate);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

    }
}
