using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;

using RestSharp;
using PicoCRMx.Objects.Contact;

namespace PicoCRMx.Objects.Contact
{
  
    public  class ContactService
    {
        public RestClient client;
        public ContactService()
        {
            this.client = new("https://api.hubspot.com/crm/v3/objects/contacts");
        

        }


        public  async Task<CreateModel.Response> CreateContact( CreateModel.Request ContactInfo)
        {
            var SerBody = JsonConvert.SerializeObject(ContactInfo);
            var request = new RestRequest()
   
                .AddQueryParameter("hapikey", "3ad5de2d-b2b7-450f-9396-8039cf878077")
    
                .AddJsonBody(SerBody);
          
            var response = await client.PostAsync<CreateModel.Response>(request);

            return response;
        }


    }
}
