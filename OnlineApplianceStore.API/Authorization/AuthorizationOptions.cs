using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApplianceStore.API.Authorization
{
    public class AuthorizationOptions
    {
        public const string ISSUER = "MyAuthorizationServer"; // издатель токена
        public const string AUDIENCE = "MyAuthorizationClient"; // потребитель токена
        const string KEY = "qwerty";   // ключ для шифрации
        public const int LIFETIME = 2; // время жизни токена - 2 минуты
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
