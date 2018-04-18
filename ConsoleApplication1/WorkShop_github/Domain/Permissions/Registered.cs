using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_github.domain;

namespace WorkShop_github.Domain.Permissions
{
    abstract class Registered : Permission
    {
        private Password password;
        public abstract bool isAdministrator();
        public abstract bool isManager();
    }
}
