using Elasticsearch.Net;
using Elasticsearch.Net.Aws;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sabio.Web.Services.Index
{
    public abstract class BaseIndexService 
    {
        private ElasticClient _Client { get; set; }

        protected ElasticClient GetClient()
        {
            if (this._Client == null) 
            {
                var httpConnection = new AwsHttpConnection(new AwsSettings // using Elasticsearch.Net.Aws to connect because  its amazon service 
                {
                    AccessKey = ConfigService.ESAccessKey,
                    SecretKey = ConfigService.ESSecretKey,
                    Region = ConfigService.ESRegion,
                });
                var pool = new SingleNodeConnectionPool(new Uri(ConfigService.ESurl));
                var config = new ConnectionSettings(pool, httpConnection);
                this._Client  = new ElasticClient(config);
            }

            return this._Client; 
        }

    }
}
