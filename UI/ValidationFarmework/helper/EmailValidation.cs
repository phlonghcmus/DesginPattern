using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ValidationFarmework.helper
{
    public class EmailValidation : Project.ValidationFarmework.helper.ValidationHelper
    {
        public override bool IsValid(string valueValidate)
        {
            var trimmedEmail = valueValidate.Trim();
            if (valueValidate.Length == 0)
            {
                return false;
            }
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(valueValidate);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
