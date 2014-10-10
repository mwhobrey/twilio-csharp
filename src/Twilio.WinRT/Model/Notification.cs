using System;

namespace Twilio
{
	/// <summary>
	/// An Notification instance resource represents a single Twilio Notification.
	/// </summary>
	public sealed class Notification //: TwilioBase
	{
        /// <summary>
        /// Exception encountered during API request
        /// </summary>
        public RestException RestException { get; set; }
        /// <summary>
        /// The URI for this resource, relative to https://api.twilio.com
        /// </summary>
        public Uri Uri { get; set; }


		/// <summary>
		/// A 34 character string that uniquely identifies this resource.
		/// </summary>
		public string Sid { get; set; }
		/// <summary>
		/// The date that this resource was created.
		/// </summary>
		public DateTimeOffset DateCreated { get; set; }
		/// <summary>
		/// The date that this resource was last updated.
		/// </summary>
		public DateTimeOffset DateUpdated { get; set; }
		/// <summary>
		/// The unique id of the Account responsible for this notification.
		/// </summary>
		public string AccountSid { get; set; }
		/// <summary>
		/// CallSid is the unique id of the call during which the notification was generated. Empty if the notification was generated by the REST API without regard to a specific phone call.
		/// </summary>
		public string CallSid { get; set; }
		/// <summary>
		/// The version of the Twilio in use when this notification was generated.
		/// </summary>
		public string ApiVersion { get; set; }
		/// <summary>
		/// An integer log level corresponding to the type of notification: 0 is ERROR, 1 is WARNING.
		/// </summary>
		public int Log { get; set; }
		/// <summary>
		/// A unique error code for the error condition.
		/// </summary>
		public string ErrorCode { get; set; }
		/// <summary>
		/// A URL for more information about the error condition. 
		/// </summary>
		public string MoreInfo { get; set; }
		/// <summary>
		/// The text of the notification.
		/// </summary>
		public string MessageText { get; set; }
		/// <summary>
		/// The date the notification was actually generated. Due to buffering, this may be slightly different than the DateCreated date.
		/// </summary>
		public DateTimeOffset MessageDate { get; set; }
		/// <summary>
		/// The URL of the resource that generated the notification. 
		/// If the notification was generated during a phone call: 
		/// This is the URL of the resource on YOUR SERVER that caused the notification. 
		/// If the notification was generated by your use of the REST API:
		/// This is the URL of the REST resource you were attempting to request on Twilio's servers.
		/// </summary>
		public string RequestUrl { get; set; }
		/// <summary>
		/// The HTTP method in use for the request that generated the notification. 
		/// If the notification was generated during a phone call: 
		/// The HTTP Method use to request the resource on your server. 
		/// If the notification was generated by your use of the REST API: 
		/// This is the HTTP method used in your request to the REST resource on Twilio's servers.
		/// </summary>
		public string RequestMethod { get; set; }
		/// <summary>
		/// The Twilio-generated HTTP GET or POST variables sent to your server. Alternatively, if the notification was generated by the REST API, this field will include any HTTP POST or PUT variables you sent to the REST API.
		/// </summary>
		public string RequestVariables { get; set; }
		/// <summary>
		/// The HTTP headers returned by your server.
		/// </summary>
		public string ResponseHeaders { get; set; }
		/// <summary>
		/// The HTTP body returned by your server.
		/// </summary>
		public string ResponseBody { get; set; }
	}
}