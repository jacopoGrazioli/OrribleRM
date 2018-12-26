using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class TableCreator
    {
        public string TableCreatorManager(List<string> fieldName, List<string> fieldType, string tableName, int fieldCount)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"CREATE TABLE {tableName}");
            stringBuilder.Append("(");
            stringBuilder.Append(Environment.NewLine);

            for (int i = 0; i < fieldCount; i++)
            {
                if (fieldName[i] == "Id")
                {
                    if (fieldType[i] == "bigint")
                    {
                        stringBuilder.Append(fieldName[i]);
                        stringBuilder.Append(" ");
                        stringBuilder.Append(fieldType[i]);
                        stringBuilder.Append(" IDENTITY(1,1) PRIMARY KEY");
                    }
                }
                else
                {
                    stringBuilder.Append(fieldName[i]);
                    stringBuilder.Append(" ");
                    stringBuilder.Append(fieldType[i]);
                }



                if (i < fieldCount - 1)
                {
                    stringBuilder.Append(",");
                }

                stringBuilder.Append(Environment.NewLine);
            }

            stringBuilder.Append(");");

            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
    }


}
