using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// Request the service from eIvy platform applications.
    /// </summary>
    public class ServiceRequest
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseUrl">The request base url.</param>
        public ServiceRequest(string baseUrl)
        {
            this.BaseUrl = baseUrl;
        }
        /// <summary>
        /// Get the basic URL of requesting services.
        /// </summary>
        public string BaseUrl
        {
            get;
            private set;
        }
    }
}
