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
       
        public void IndexDealer(DealerIndex model) 
        {
            // You could put all the connection code here but DIY, code removed to different classes for reusability
           
            ElasticClient getClientConnection = this.GetClient(); //call the method from BaseService

            // Begin of index to Elastic Search 
            var response = getClientConnection.Index(model, idx => idx.Index("autodealio"));
        
            // GET autodealio/dealerindex/_search     dealerindex is the model name 

        }
    }
    
    }




