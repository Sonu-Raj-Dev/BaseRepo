using Lead_Management.Core.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lead_Management.Service.User
{
    public interface IUserService
    {
        UserEntity ValidateUser(string EmailID);
        UserEntity GetUserByLoginId(string LoginId);
    }
}
