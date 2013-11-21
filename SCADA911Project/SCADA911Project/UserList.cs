using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA911Project
{

    enum ContactMethodTypes { phone, sms, email };

    struct ContactMethod
    {
        private string ContactMethodName;
        private ContactMethodTypes ContactMethodType; 
        private string ContactString;
    }

    struct UserListEntry
    {
        private string UserName;

        
    }

    class UserList
    {

    }
}
