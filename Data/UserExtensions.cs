using System.Security.Claims;

namespace msoscarcorp.Data
{
    public static class UserExtensions
    {
        public static string FirstName(this ClaimsPrincipal user)
            => user.FindFirst("given_name")?.Value;

        public static string LastName(this ClaimsPrincipal user)
            => user.FindFirst("family_name")?.Value;

        public static string Email(this ClaimsPrincipal user)
            => user.FindFirst("emails")?.Value;

        public static bool IsApproved(this ClaimsPrincipal user){
            bool flag;
            if(bool.TryParse(user.FindFirst("IsApproved")?.Value, out flag)) {
                return flag;
            }
            return false;
        }
    }
}
