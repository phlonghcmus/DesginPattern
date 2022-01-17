using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validator
{
    public class ValidatorFactory
    {
        private static Dictionary<string, Validator> validatorMap = new Dictionary<string,Validator>();

        private void Init()
        {
            validatorMap.Clear();
            validatorMap.Add("Required", new RequiredValidator());
            validatorMap.Add("Min", new MinValidator());
            validatorMap.Add("Email", new EmailValidator());
            validatorMap.Add("Phone", new PhoneValidator());
            validatorMap.Add("Range", new RangeValidator());
            validatorMap.Add("Max", new MaxValidator());
            validatorMap.Add("Regex", new RegexValidator());
            validatorMap.Add("Date", new DateValidator());
            validatorMap.Add("IsInt", new IsIntValidator());
            validatorMap.Add("IsFloat", new IsFloatValidator());

        }
        public ValidatorFactory()
        {
            Init();
        }
        public bool addValidator(string nameValidator, Validator newValidator)
        {
            if (validatorMap.ContainsKey(nameValidator))
                return false;
            else
            {
                validatorMap.Add(nameValidator, newValidator);
                return true;
            }

        }


        private bool CheckValidatorType(string strTypeValidator)
        {

            return validatorMap.ContainsKey(strTypeValidator);
        }

        public Validator? create(string strTypeValidator)
        {
            if (CheckValidatorType(strTypeValidator))
                return validatorMap[strTypeValidator];
            return null;
        }
    }
}
