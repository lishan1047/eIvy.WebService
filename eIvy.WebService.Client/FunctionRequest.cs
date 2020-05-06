using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// The function service request.
    /// </summary>
    public abstract class FunctionRequest : ServiceRequest
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="accessToken">The required access token.</param>
        public FunctionRequest(AccessToken accessToken)
            : base(accessToken)
        {
        }
        /// <summary>
        /// Get the function service access url section.
        /// </summary>
        public override string ServiceUrlSection
        {
            get
            {
                return "ServiceApi/";
            }
        }
        /// <summary>
        /// Get the function service name.
        /// </summary>
        public abstract string FunctionServiceName { get; }

        /// <summary>
        /// Parse the invoking json result to the specific type result.
        /// </summary>
        /// <param name="json">The invoking json result.</param>
        /// <returns>Parsed the specific type result.</returns>
        public abstract FunctionRequestResult ParseResult(string json);
        /// <summary>
        /// Invoke the function method.
        /// </summary>
        /// <param name="parameters">The method parameters.</param>
        /// <returns>The result of function invoking.</returns>
        public async Task<FunctionRequestResult> InvokeAsync(Dictionary<string, object> parameters)
        {
            parameters["OpenID"] = this.AccessToken.OpenID;

            HttpResponseMessage resp =
                await this.HttpClient.GetAsync(
                    WebUtility.CombineUrl(this.RequestUrl, this.FunctionServiceName) +
                    WebUtility.BuildQueryString(parameters));

            if (resp.IsSuccessStatusCode)
            {
                string c = await resp.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(c))
                {
                    FunctionRequestResult r = this.ParseResult(c);

                    return r;
                }
            }

            return null;
        }
    }
}
