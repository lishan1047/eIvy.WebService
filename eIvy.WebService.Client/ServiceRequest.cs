using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// The service request base class.
    /// </summary>
    public abstract class ServiceRequest
    {
        private static readonly HttpClient _httpClient;

        static ServiceRequest()
        {
            _httpClient = new HttpClient();
        }
        /// <summary>
        /// Get the http client for requesting.
        /// </summary>
        protected HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="accessToken">The required access token.</param>
        public ServiceRequest(AccessToken accessToken)
        {
            this.AccessToken = accessToken;
        }
        /// <summary>
        /// Get the access token.
        /// </summary>
        public AccessToken AccessToken
        {
            get;
            private set;
        }
        /// <summary>
        /// Get the function service access url section.
        /// </summary>
        public abstract string ServiceUrlSection { get; }
        /// <summary>
        /// Get the service request url.
        /// </summary>
        public string RequestUrl
        {
            get
            {
                return string.Format("{0}{1}", this.AccessToken.BaseUrl, this.ServiceUrlSection);
            }
        }

        
    }
}
