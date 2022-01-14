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
    internal class IsIntValidator: Validator
    {
        public IsIntValidator() { }

        protected override string getMessage(PropertyInfo prop)
        {
            IsInt attr = (IsInt)Attribute.GetCustomAttribute(prop, typeof(IsInt));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
           
           return !int.TryParse((string)value, out _);
        }
    }
}
