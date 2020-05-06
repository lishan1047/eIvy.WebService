using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// The role information.
    /// </summary>
    public class RoleInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public RoleInfo()
        {
        }
        /// <summary>
        /// Get or set the role name.
        /// </summary>
        public string RoleName
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the role description.
        /// </summary>
        public string RoleDescription
        {
            get;
            set;
        }
    }
}
