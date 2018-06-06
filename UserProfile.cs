using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USALauncher
{
    class UserProfile
    {

        public string path;

        public UserProfile(string path)
        {
            this.path = path;
        }

        public override string ToString()
        {
            return path.Split('\\').Last().Replace("%20", " ");
        }

    }
}
