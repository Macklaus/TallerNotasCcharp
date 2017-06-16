using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegationWorkshopApp
{
    class ControllerUser
    {
        public static ClassUser userLogged = null;
        public static LinkedList<ClassUser> listaUsers = new LinkedList<ClassUser>();

        public ControllerUser()
        {
            
        }   
        
        public ClassUser searchByUsername(String username)
        {
            for (int i = 0; i < listaUsers.Count; i++)
            {
                if (listaUsers.ElementAt(i).Username.Equals(username)){
                    return listaUsers.ElementAt(i);
                }
            }
            return null;
        }

        public bool saveUser(ClassUser user)
        {
            ClassUser u = searchByUsername(user.Username);
            if(u != null)
            {
                return false;
            }
            listaUsers.AddLast(user);
            return true;
        }

        public ClassUser verifyCredentials(String username, String pass)
        {
            for (int i = 0; i < listaUsers.Count; i++)
            {
                if (listaUsers.ElementAt(i).Username.Equals(username) 
                    && listaUsers.ElementAt(i).Password.Equals(pass))
                {
                    return listaUsers.ElementAt(i);
                }
            }
            return null;
        }


    }
}
