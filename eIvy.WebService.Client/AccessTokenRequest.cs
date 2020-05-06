using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// Request the access token from eIvy platform applications.
    /// </summary>
    public class AccessTokenRequest
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="baseUrl">The request base url.</param>
        /// <param name="appid">The application id applied from the eIvy platform.</param>
        /// <param name="secretKey">The secret key for requesting the application.</param>
        public AccessTokenRequest(string baseUrl, int appid, string secretKey)
        {
            this.BaseUrl = baseUrl;
            this.AppID = appid;
            this.SecretKey = secretKey;
        }
        /// <summary>
        /// Get the basic URL of requesting services.
        /// </summary>
        public string BaseUrl
        {
            get;
            private set;
        }
        /// <summary>
        /// Get the application id applied from the eIvy platform.
        /// </summary>
        public int AppID
        {
            get;
            private set;
        }
        /// <summary>
        /// Get the secret key for requesting the application.
        /// </summary>
        public string SecretKey
        {
            get;
            private set;
        }

        /// <summary>
        /// Get requesting url section of getting the access token.
        /// </summary>
        protected string AccessTokenUrlSection
        {
            get { return "External/Service/AccessToken.aspx"; }
        }

        /// <summary>
        /// Get the request url.
        /// </summary>
        protected virtual string RequestUrl
        {
            get
            {
                return string.Format(
                    "{0}{1}?AppID={2}&SecretKey={3}",
                    BaseUrl, AccessTokenUrlSection,
                    AppID, SecretKey);
            }
        }

        /// <summary>
        /// Get the access token async.
        /// </summary>
        /// <returns>The access token.</returns>
        public async virtual Task<AccessToken> GetAccessTokenAsync()
        {
            HttpClient client = WebUtility.GetHttpClient();

            HttpResponseMessage resp = await client.GetAsync(this.RequestUrl);

            if (resp.IsSuccessStatusCode)
            {
                string c = await resp.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(c))
                {
                    Error error = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(c);

                    if (error != null && !string.IsNullOrEmpty(error.ErrorCode))
                    {
                        throw new Exception(error.ErrorMessage);
                    }
                    AccessToken token = Newtonsoft.Json.JsonConvert.DeserializeObject<AccessToken>(c);

                    token.BaseUrl = this.BaseUrl;

                    return token;
                }
            }

            return null;
        }
    }
}
