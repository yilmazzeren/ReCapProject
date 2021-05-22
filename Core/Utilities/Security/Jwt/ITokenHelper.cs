using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        // token üretimi
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
