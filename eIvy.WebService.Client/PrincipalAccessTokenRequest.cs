using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// Access token request based on principals.
    /// </summary>
    public class PrincipalAccessTokenRequest : AccessTokenRequest
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseUrl">The request base url.</param>
        /// <param name="appid">The application id applied from the eIvy platform.</param>
        /// <param name="secretKey">The secret key for requesting the application.</param>
        /// <param name="userName">The login user name.</param>
        /// <param name="loginRole">The login role name (on OnlyOneRole login manner).</param>
        public PrincipalAccessTokenRequest(string baseUrl, int appid, string secretKey, string userName, string loginRole)
            : base(baseUrl, appid, secretKey)
        {
            this.UserName = userName;
            this.LoginRole = loginRole;
        }

        /// <summary>
        /// Get or set the login user name.
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the login role name (on OnlyOneRole login manner).
        /// </summary>
        public string LoginRole
        {
            get;
            set;
        }
        /// <summary>
        /// Get the request url.
        /// </summary>
        protected override string RequestUrl
        {
            get
            {
                return string.Format("{0}&User={1}&LoginRole={2}",
                    base.RequestUrl, this.UserName, this.LoginRole);
            }
        }
    }
}
