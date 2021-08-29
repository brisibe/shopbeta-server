using shopbeta.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta.Core.Interfaces
{
   public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserAuthenticationDto userrAuth);
        Task<string> CreateToken();
    }
}
