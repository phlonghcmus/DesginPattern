using Project.ValidationFarmework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UI.CustomValidator
{
    public class NewValidator : Validator
    {
        public NewValidator()
        {
            
        }
        protected override string getMessage(PropertyInfo prop)
        {
            NewVal attr = (NewVal)Attribute.GetCustomAttribute(prop, typeof(NewVal));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            return true;
        }


    }
}
