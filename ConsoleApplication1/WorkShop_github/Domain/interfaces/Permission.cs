using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_github
{
    interface Permission
    {
        String getPassword();
        bool isAdministrator();
        bool isManager();


    }
}
