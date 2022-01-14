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
    internal class IsFloatValidator:Validator
    {
        public IsFloatValidator() { }

        protected override string getMessage(PropertyInfo prop)
        {
            IsFloat attr = (IsFloat)Attribute.GetCustomAttribute(prop, typeof(IsFloat));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            bool isFloat = float.TryParse((string)value, out _) && !int.TryParse((string)value, out _);
            return !isFloat;
        }
    }
}
