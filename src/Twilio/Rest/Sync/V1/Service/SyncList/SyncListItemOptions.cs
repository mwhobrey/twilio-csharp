/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncList 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// FetchSyncListItemOptions
    /// </summary>
    public class FetchSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }

        /// <summary>
        /// Construct a new FetchSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        public FetchSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// DeleteSyncListItemOptions
    /// </summary>
    public class DeleteSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }

        /// <summary>
        /// Construct a new DeleteSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        public DeleteSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// CreateSyncListItemOptions
    /// </summary>
    public class CreateSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// Contains arbitrary user-defined, schema-less data that this List Item stores, represented by a JSON object, up to 16KB.
        /// </summary>
        public object Data { get; }
        /// <summary>
        /// Alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// Time-to-live of this item in seconds, defaults to no expiration.
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// Time-to-live of this item's parent List in seconds, defaults to no expiration.
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new CreateSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="data"> Contains arbitrary user-defined, schema-less data that this List Item stores, represented by a
        ///            JSON object, up to 16KB. </param>
        public CreateSyncListItemOptions(string pathServiceSid, string pathListSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// ReadSyncListItemOptions
    /// </summary>
    public class ReadSyncListItemOptions : ReadOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// A string; asc or desc
        /// </summary>
        public SyncListItemResource.QueryResultOrderEnum Order { get; set; }
        /// <summary>
        /// An integer representing Item index offset.
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// The bounds
        /// </summary>
        public SyncListItemResource.QueryFromBoundTypeEnum Bounds { get; set; }

        /// <summary>
        /// Construct a new ReadSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        public ReadSyncListItemOptions(string pathServiceSid, string pathListSid)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Bounds != null)
            {
                p.Add(new KeyValuePair<string, string>("Bounds", Bounds.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// UpdateSyncListItemOptions
    /// </summary>
    public class UpdateSyncListItemOptions : IOptions<SyncListItemResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list_sid
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index
        /// </summary>
        public int? PathIndex { get; }
        /// <summary>
        /// Contains arbitrary user-defined, schema-less data that this List Item stores, represented by a JSON object, up to 16KB.
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// Alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// Time-to-live of this item in seconds, defaults to no expiration.
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// Time-to-live of this item's parent List in seconds, defaults to no expiration.
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new UpdateSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathListSid"> The list_sid </param>
        /// <param name="pathIndex"> The index </param>
        public UpdateSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

}