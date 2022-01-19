using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Project.ValidationFarmework.helper
{
    public abstract class ValidationHelper
    {

        public abstract bool IsValid(string valueValidate);

    }
}
