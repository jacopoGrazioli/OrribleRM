using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class SqlWriterEntity
    {
        public SqlWriterEntity(User user)
        {
            Type type = user.GetType();
            FieldInfo[] fieldInfo = type.GetFields();

            FieldTypeString fieldTypeString = new FieldTypeString();
            FieldNameString fieldNameString = new FieldNameString();
            
            //Tipi
            List<string> types = new List<string>();
            
            //Nomi
            List<string> names = new List<string>();

            foreach (FieldInfo f in fieldInfo)
            {
                //Tipi
                string result = fieldTypeString.FieldTypeStringCreator(f);
                types.Add(result);
            }

            foreach (FieldInfo f in fieldInfo)
            {
                string result = fieldNameString.FieldNameStringCreator(f);
                names.Add(result);
            }

            TableCreator tableCreator = new TableCreator();

            string tableName = type.Name + "s";
            int propertyCount = fieldInfo.Length;

            string fileResult = tableCreator.TableCreatorManager(names, types, tableName, propertyCount);

            SqlWriter sqlWriter = new SqlWriter();
            sqlWriter.FromMemoryToFile(fileResult, type.Name);
        }
    }
}
