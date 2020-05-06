using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eIvy.WebService.Client.Test
{
    [TestFixture()]
    public class AuthenticateTest
    {
        [Test()]
        public void TestCase()
        {
            Task.Run(async () => {
                PrincipalAccessTokenRequest fr = new PrincipalAccessTokenRequest("http://39.104.72.86:9091/",
                    2, "q4cENNVLO1GOTQkcpr8nULj0OcNK",
                "Administrator", "Administrators");

                AccessToken token = await fr.GetAccessTokenAsync();

                AuthenticateRequest authen = new AuthenticateRequest(token);

                Dictionary<string, object> dict = new Dictionary<string, object>
                {
                    ["Password"] = "xxxxxxx"
                };
                AuthenticateResult r = await authen.InvokeAsync(dict) as AuthenticateResult;

            }).GetAwaiter().GetResult();
        }
    }
}
