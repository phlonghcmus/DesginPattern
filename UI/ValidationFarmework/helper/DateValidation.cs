using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ValidationFarmework.helper
{
    public class DateValidation : Project.ValidationFarmework.helper.ValidationHelper
    {
        public override bool IsValid(string valueValidate)
        {
            DateTime tempDate;
            return DateTime.TryParse(valueValidate, out tempDate);
        }
    }
}
