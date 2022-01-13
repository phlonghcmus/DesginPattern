using Project.ValidationFarmework.anotation;
using Project.ValidationFarmework.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validator
{
    internal class DateValidator : Validator
    {
        public DateValidator()
        {

        }
        protected override string getMessage(PropertyInfo prop)
        {
            Date attr=(Date)Attribute.GetCustomAttribute(prop, typeof(Date));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            return !ValidationHelper.IsDateTime((string)value);
        }
    }
}
