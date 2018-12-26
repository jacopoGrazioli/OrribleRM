using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class SqlWriter
    {
        public void FromMemoryToFile(string file, string typeName)
        {
            string fileName = typeName + ".sql";
            string path = Path.Combine("C:\\Users\\jacopo\\source\\repos\\ReflectionText\\ReflectionText\\generatedSql\\", fileName);

            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(file);
            }
        }
    }
}
