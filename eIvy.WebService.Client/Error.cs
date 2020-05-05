using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// Error object from web service.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Error()
        {
        }
        /// <summary>
        /// Get or set the error code.
        /// </summary>
        public string ErrorCode
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the error message.
        /// </summary>
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}
