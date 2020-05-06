using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace eIvy.WebService.Client
{
    /// <summary>
    /// The helper class for web requesting.
    /// </summary>
    public static class WebUtility
    {
        /// <summary>
        /// Build query string by parameters dictionary.
        /// </summary>
        /// <param name="dict">parameters dictionary.</param>
        /// <returns>Query string built.</returns>
        public static string BuildQueryString(Dictionary<string, object> dict)
        {
            if (dict.Count == 0) return string.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append("?");

            foreach(string key in dict.Keys)
            {
                sb.AppendFormat("{0}={1}&", key, dict[key]);
            }

            return sb.ToString().TrimEnd('&');
        }
        /// <summary>
        /// Combine the sections of url.
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="urlSections"></param>
        /// <returns>The combined url.</returns>
        public static string CombineUrl(string baseUrl, params string[] urlSections)
        {
            if(string.IsNullOrEmpty(baseUrl))
            {
                throw new ArgumentNullException("baseUrl");
            }

            if (urlSections.Length == 0) return baseUrl;

            StringBuilder sb = new StringBuilder();

            sb.Append(baseUrl.TrimEnd('/'));

            sb.Append('/');

            foreach(string sec in urlSections)
            {
                sb.AppendFormat("{0}/", sec.TrimEnd('/'));
            }

            return sb.ToString();
        }

        private static HttpClient _httpClient;
        /// <summary>
        /// Get the app global http client object.
        /// </summary>
        /// <returns>The global Http Client object.</returns>
        public static HttpClient GetHttpClient()
        {
            if(_httpClient == null)
            {
                _httpClient = new HttpClient();
            }
            return _httpClient;
        }
    }
}
