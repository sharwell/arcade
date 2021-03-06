// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class XUnitTestResult
    {
        /// <summary>
        /// Initializes a new instance of the XUnitTestResult class.
        /// </summary>
        public XUnitTestResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XUnitTestResult class.
        /// </summary>
        /// <param name="name">XUnit "name" of test, this is usually in the
        /// format of TypeName#MethodName(arguments...)</param>
        /// <param name="result">XUnit result string. Normal values are "Pass",
        /// "Fail", "Skip"</param>
        /// <param name="failureExceptionType">Fully qualified name of the
        /// exception type that caused the failure</param>
        /// <param name="failureMessage">XUnit failure message</param>
        /// <param name="failureStackTrace">Stack trace where failure/exception
        /// was observed</param>
        /// <param name="reason">The "reason" for the result, usually this is
        /// related to why a test was skipped</param>
        /// <param name="duration">Duration of test in 1/10,000 of a
        /// second.</param>
        /// <param name="output">Any test output related to this
        /// failure</param>
        public XUnitTestResult(string name = default(string), string result = default(string), string failureExceptionType = default(string), string failureMessage = default(string), string failureStackTrace = default(string), string reason = default(string), long? duration = default(long?), string output = default(string), FailureReason failureReason = default(FailureReason), string type = default(string), string method = default(string), string arguments = default(string))
        {
            Name = name;
            Result = result;
            FailureExceptionType = failureExceptionType;
            FailureMessage = failureMessage;
            FailureStackTrace = failureStackTrace;
            Reason = reason;
            Duration = duration;
            Output = output;
            FailureReason = failureReason;
            Type = type;
            Method = method;
            Arguments = arguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets xUnit "name" of test, this is usually in the format of
        /// TypeName#MethodName(arguments...)
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets xUnit result string. Normal values are "Pass", "Fail",
        /// "Skip"
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets fully qualified name of the exception type that caused
        /// the failure
        /// </summary>
        [JsonProperty(PropertyName = "FailureExceptionType")]
        public string FailureExceptionType { get; set; }

        /// <summary>
        /// Gets or sets xUnit failure message
        /// </summary>
        [JsonProperty(PropertyName = "FailureMessage")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Gets or sets stack trace where failure/exception was observed
        /// </summary>
        [JsonProperty(PropertyName = "FailureStackTrace")]
        public string FailureStackTrace { get; set; }

        /// <summary>
        /// Gets or sets the "reason" for the result, usually this is related
        /// to why a test was skipped
        /// </summary>
        [JsonProperty(PropertyName = "Reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets duration of test in 1/10,000 of a second.
        /// </summary>
        [JsonProperty(PropertyName = "Duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or sets any test output related to this failure
        /// </summary>
        [JsonProperty(PropertyName = "Output")]
        public string Output { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FailureReason")]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Method")]
        public string Method { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Arguments")]
        public string Arguments { get; set; }

    }
}
