using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegationWorkshopApp
{
    class ClassUser
    {

        private String name;
        private String username;
        private String password;
        private ClassPercentage percentage;

        public ClassUser(string name, string username, string password, 
            ClassPercentage percentage)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.percentage = percentage;
        }

        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public ClassPercentage Percentage { get => percentage; set => percentage = value; }
    }
}
