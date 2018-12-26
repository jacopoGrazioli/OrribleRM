using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionText
{
    public class User
    {
        public User()
        {
            Guid.NewGuid();
        }

        public Guid Guid;
        public long Id;
        public string Name;
        public string UserName;
        public bool IsLoggedIn;
    }
}
