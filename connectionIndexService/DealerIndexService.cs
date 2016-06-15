using Elasticsearch.Net;
using Elasticsearch.Net.Aws;
using Nest;
using Sabio.Web.Domain.Index;
using Sabio.Web.Models.Requests;
using Sabio.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sabio.Web.Services.Index
{
    public class DealerIndexService : BaseIndexService, IDealerIndexService
    {
       
        public void IndexDealer(DealerIndex model) //its like a post we dont need the id back, dont need return anything back. so its VOID 
        {
            //var httpConnection = new AwsHttpConnection(new AwsSettings //its Amazon service so using Elasticsearch.Net.Aws to connect 
            //{
            //    AccessKey = "AKIAIFSU4DDCF4AX7DEA",
            //    SecretKey = "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",
            //    Region = "us-west-2",
            //});


            ////var httpConnection = new AwsHttpConnection("us-west-2");
            //var pool = new SingleNodeConnectionPool(new Uri("https://search-autodealio-juupfd2um67zo4ri7vfx54yrwu.us-west-2.es.amazonaws.com:443"));
            //var config = new ConnectionSettings(pool, httpConnection);
            //var client = new ElasticClient(config);
            //// move to baseIndex service need to use this.client instead of var client 

           
            ElasticClient getClientConnection = this.GetClient(); // caling the method in BaseIndexService 

            // Begin of index to Elastic Search 
            var response = getClientConnection.Index(model, idx => idx.Index("autodealio"));
            //int a = 1; // for break point texting. just extra code below, so it can do step over rather than excute the function
            //a++;

            // GET autodealio/dealerindex/_search     dealerindex is the model name 

        }


    }
    
        // (Original version)
        //    // Domain.Index.DealerIndex document = new Domain.Index.DealerIndex();
        //    Uri nodeLocation = new Uri("https://search-autodealio-juupfd2um67zo4ri7vfx54yrwu.us-west-2.es.amazonaws.com:9200");
        //    IConnectionPool connectionPool = new SniffingConnectionPool(new List<Uri> { nodeLocation });
        //    Nest.ConnectionSettings settings = new Nest.ConnectionSettings(connectionPool);
        //    ElasticClient esClient = new ElasticClient(settings);

        //    IIndexResponse result = esClient.Index(Dealerindex, i => i
        //        .Index("autodealio")
        //        .Type("dealer")
        //        .Id(Dealerindex.DealerID)
        //        );}


    }




