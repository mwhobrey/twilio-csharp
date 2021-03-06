/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// ActivityResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class ActivityResource : Resource 
    {
        private static Request BuildFetchRequest(FetchActivityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Activities/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Fetch(FetchActivityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> FetchAsync(FetchActivityOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Fetch(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchActivityOptions(pathWorkspaceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> FetchAsync(string pathWorkspaceSid, 
                                                                                     string pathSid, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new FetchActivityOptions(pathWorkspaceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateActivityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Activities/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Update(UpdateActivityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> UpdateAsync(UpdateActivityOptions options, 
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human-readable name for the Activity, such as 'on-call', 'break', 'email', etc.
        ///                    </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Update(string pathWorkspaceSid, 
                                              string pathSid, 
                                              string friendlyName = null, 
                                              ITwilioRestClient client = null)
        {
            var options = new UpdateActivityOptions(pathWorkspaceSid, pathSid){FriendlyName = friendlyName};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human-readable name for the Activity, such as 'on-call', 'break', 'email', etc.
        ///                    </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> UpdateAsync(string pathWorkspaceSid, 
                                                                                      string pathSid, 
                                                                                      string friendlyName = null, 
                                                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateActivityOptions(pathWorkspaceSid, pathSid){FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteActivityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Activities/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static bool Delete(DeleteActivityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteActivityOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static bool Delete(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteActivityOptions(pathWorkspaceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteActivityOptions(pathWorkspaceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadActivityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Activities",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ResourceSet<ActivityResource> Read(ReadActivityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ActivityResource>.FromJson("activities", response.Content);
            return new ResourceSet<ActivityResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ActivityResource>> ReadAsync(ReadActivityOptions options, 
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ActivityResource>.FromJson("activities", response.Content);
            return new ResourceSet<ActivityResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> Filter by an Activity's friendly name </param>
        /// <param name="available"> Filter by activities that are available or unavailable. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ResourceSet<ActivityResource> Read(string pathWorkspaceSid, 
                                                         string friendlyName = null, 
                                                         string available = null, 
                                                         int? pageSize = null, 
                                                         long? limit = null, 
                                                         ITwilioRestClient client = null)
        {
            var options = new ReadActivityOptions(pathWorkspaceSid){FriendlyName = friendlyName, Available = available, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> Filter by an Activity's friendly name </param>
        /// <param name="available"> Filter by activities that are available or unavailable. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ActivityResource>> ReadAsync(string pathWorkspaceSid, 
                                                                                                 string friendlyName = null, 
                                                                                                 string available = null, 
                                                                                                 int? pageSize = null, 
                                                                                                 long? limit = null, 
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadActivityOptions(pathWorkspaceSid){FriendlyName = friendlyName, Available = available, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ActivityResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ActivityResource> NextPage(Page<ActivityResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ActivityResource> PreviousPage(Page<ActivityResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }

        private static Request BuildCreateRequest(CreateActivityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Activities",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Create(CreateActivityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Activity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> CreateAsync(CreateActivityOptions options, 
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> A human-readable name for the Activity, such as 'On Call', 'Break', 'Email', etc.
        ///                    </param>
        /// <param name="available"> Boolean value indicating whether the worker should be eligible to receive a Task when they
        ///                 occupy this Activity. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Activity </returns> 
        public static ActivityResource Create(string pathWorkspaceSid, 
                                              string friendlyName, 
                                              bool? available = null, 
                                              ITwilioRestClient client = null)
        {
            var options = new CreateActivityOptions(pathWorkspaceSid, friendlyName){Available = available};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> A human-readable name for the Activity, such as 'On Call', 'Break', 'Email', etc.
        ///                    </param>
        /// <param name="available"> Boolean value indicating whether the worker should be eligible to receive a Task when they
        ///                 occupy this Activity. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Activity </returns> 
        public static async System.Threading.Tasks.Task<ActivityResource> CreateAsync(string pathWorkspaceSid, 
                                                                                      string friendlyName, 
                                                                                      bool? available = null, 
                                                                                      ITwilioRestClient client = null)
        {
            var options = new CreateActivityOptions(pathWorkspaceSid, friendlyName){Available = available};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ActivityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ActivityResource object represented by the provided JSON </returns> 
        public static ActivityResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ActivityResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that owns this Activity.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Filter by activities that are available or unavailable.
        /// </summary>
        [JsonProperty("available")]
        public bool? Available { get; private set; }
        /// <summary>
        /// The date this Activity was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Activity was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Filter by an Activity's friendly name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique ID for this Activity.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique ID of the Workspace that this Activity belongs to.
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ActivityResource()
        {

        }
    }

}