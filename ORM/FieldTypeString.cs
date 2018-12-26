using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class FieldTypeString
    {
        public string FieldTypeStringCreator(FieldInfo field)
        {
            string result = null;

            if (field.FieldType.FullName == "System.String")
            {
                result = "VARCHAR(250)";
            }

            if (field.FieldType.FullName == "System.Guid")
            {
                result = "uniqueidentifier";
            }

            if (field.FieldType.FullName == "System.Int32")
            {
                result = "int";
            }

            if (field.FieldType.FullName == "System.Int64")
            {
                result = "bigint";
            }

            if (field.FieldType.FullName == "System.Boolean")
            {
                //per convenzione converto bool in int per avere un FLAG
                result = "int";
            }

            return result;
        }
    }
}
