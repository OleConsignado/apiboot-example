using Otc.AuthorizationContext.Abstractions;

namespace ApiBootExample.Models
{
    public class AuthorizationData : IAuthorizationData
    {
        public string UserId { get; set; }

        public string MyCustomAuthData { get; set; }
    }
}
