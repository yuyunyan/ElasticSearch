using Elasticsearch.Net;
using Elasticsearch.Net.Aws;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sabio.Web.Services.Index
{
    public abstract class BaseIndexService  //Connect to ElasticSearch 
    {
        private ElasticClient _Client { get; set; }

        protected ElasticClient GetClient()
        {
            if (this._Client == null) //if client is null then do the connect 
            {
                var httpConnection = new AwsHttpConnection(new AwsSettings // using Elasticsearch.Net.Aws to connect because  its amazon service 
                {
                //  TODO: put all these values plus url into config files and load from here
                    AccessKey = "AKIAIFSU4DDCF4AX7DEA",
                    SecretKey = "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",
                    Region = "us-west-2",
                });
                var pool = new SingleNodeConnectionPool(new Uri(ConfigService.ESurl));
                var config = new ConnectionSettings(pool, httpConnection);
                this._Client  = new ElasticClient(config);
            }

            return this._Client; // this make a new instace of client var client will only override the client 
        }

    }
}