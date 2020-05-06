using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// User account mapping to an entity.
    /// </summary>
    public class UserMappingInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public UserMappingInfo()
        {
        }
        /// <summary>
        /// Get or set the user account name.
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the user account mapping to the entity name.
        /// </summary>
        public string EntityName
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the user account mapping to the entity id.
        /// </summary>
        public int EntityID
        {
            get;
            set;
        }
    }
}
