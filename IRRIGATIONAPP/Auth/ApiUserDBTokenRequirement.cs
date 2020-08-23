using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRRIGATIONAPP.Auth
{
 
    internal class ApiUserDBTokenRequirement : IAuthorizationRequirement
    {
 
        public ApiUserDBTokenRequirement() {  }
    }
 
}
