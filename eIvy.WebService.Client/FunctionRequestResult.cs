using System;
namespace eIvy.WebService.Client
{
    /// <summary>
    /// The result of function service requesting.
    /// </summary>
    public class FunctionRequestResult
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FunctionRequestResult()
        {
        }
        /// <summary>
        /// Get or set the flag of successing.
        /// </summary>
        public bool Success
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the message of requesting result.
        /// </summary>
        public string Message
        {
            get;
            set;
        }
        /// <summary>
        /// Get or set the requesting result object.
        /// </summary>
        public object ResultObject
        {
            get;
            set;
        }
    }
}
