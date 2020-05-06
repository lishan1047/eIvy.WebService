using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// Authenticate requesting from eIvy platform application.
    /// </summary>
    public class AuthenticateRequest : FunctionRequest
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="accessToken">The required access token.</param>
        public AuthenticateRequest(AccessToken accessToken)
            : base(accessToken)
        {
        }
        /// <summary>
        /// Get the function service name.
        /// </summary>
        public override string FunctionServiceName
        {
            get
            {
                return "Authenticate";
            }
        }
        /// <summary>
        /// Parse the common function invoking result to the authenticating result.
        /// </summary>
        /// <param name="json">The invoking json result.</param>
        /// <returns>The function request result with the authenticating result.</returns>
        public override FunctionRequestResult ParseResult(string json)
        {
            AuthenticateResult r = Newtonsoft.Json.JsonConvert.DeserializeObject<AuthenticateResult>(json);

            if (r.Success)
            {
                string uiJson = ((Newtonsoft.Json.Linq.JObject)r.ResultObject)["UserInfo"].ToString();

                r.UserInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInfo>(uiJson);

                string umJson = ((Newtonsoft.Json.Linq.JObject)r.ResultObject)["UserMap"].ToString();

                if(!string.IsNullOrEmpty(umJson))
                {
                    r.UserMap = Newtonsoft.Json.JsonConvert.DeserializeObject<UserMappingInfo>(umJson);
                }
            }

            return r;
        }
    }
}
