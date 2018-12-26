using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class FieldNameString
    {
        public string FieldNameStringCreator(FieldInfo field)
        {
            string result = null;

            result = field.Name;

            return result;
        }
    }
}
