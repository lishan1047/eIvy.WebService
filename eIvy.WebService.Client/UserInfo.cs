using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// The user information class.
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public UserInfo()
        {
        }
        /// <summary>
        /// Get or set the user name.
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the account activated state.
        /// </summary>
        public bool Activated
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the account locked state.
        /// </summary>
        public bool Locked
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the flag of anonymous account.
        /// </summary>
        public bool IsAnonymous
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the user account comment info.
        /// </summary>
        public string Comment
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the user account roles.
        /// </summary>
        public RoleInfo[] Roles
        {
            get;
            set;
        }
    }
}
