 using Project.ValidationFarmework.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Regex = Project.ValidationFarmework.anotation.Regex;
using Project.ValidationFarmework.anotation;

namespace Project.ValidationFarmework.validator
{
    internal class RegexValidator : Validator
    {
        public RegexValidator()
        {

        }
        protected override string getMessage(PropertyInfo prop)
        {
            Regex attr = (Regex)Attribute.GetCustomAttribute(prop, typeof(Regex));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            return !ValidationHelper.IsValidRegex((string)value);
        }
    }
}
