using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// Describe the information of user account and mapping to an entity.
    /// </summary>
    public class AuthenticateResult : FunctionRequestResult
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AuthenticateResult()
        {
        }
        /// <summary>
        /// Get or set the user account info.
        /// </summary>
        public UserInfo UserInfo
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the user mapping info.
        /// </summary>
        public UserMappingInfo UserMap
        {
            get;
            set;
        }
    }
}
