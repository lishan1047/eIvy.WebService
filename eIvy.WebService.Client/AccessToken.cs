using System;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// Access token for the eIvy Web Service。
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AccessToken()
        {
            this.CreatedTime = DateTime.Now;
        }

        /// <summary>
        /// Get or set the access request base url.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string BaseUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Get the created time of the access token.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public DateTime CreatedTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Get the expired time of the access token.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public DateTime ExpiredTime
        {
            get
            {
                return this.CreatedTime.AddMinutes(this.ExpiredIn);
            }
        }

        /// <summary>
        /// Get or set the open id of the access token.
        /// </summary>
        public string OpenID
        { get; set; }

        /// <summary>
        /// Get or set the expired minutes from the created time of the access token.
        /// </summary>
        public int ExpiredIn
        { get; set; }
    }
}
