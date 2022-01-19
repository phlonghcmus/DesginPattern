using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.violation
{
    public class Violation
    {
        //private string propName;
        //private object value;
        //private string message;
        //private bool valid = true;
        //public Violation(string propName, object value)
        //{
        //    this.propName = propName;
        //    this.value = value;
        //    message = "";
        //}

        //public string getMessage()
        //{
        //    return message;
        //}

        //public string getProp()
        //{
        //    return propName;
        //}

        //public bool getValid()
        //{
        //    return valid;
        //}

        //public void setMessage(string message)
        //{
        //    this.message = message;
        //}

        //public void setValid(bool valid)
        //{
        //    this.valid = valid;
        //}
        public string PropName;
        public object Value;
        public string Message;
        public bool Valid;
       
        public Violation(string propName,object value)
        {
            PropName = propName;
            Value = value;
            Valid = true;
        }

        

    }
}
