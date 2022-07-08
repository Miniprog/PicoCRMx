using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PicoCRMx.Auth
{
    
    public  class AuthService
    {
       
       
        public async Task<Objects.Contact.GetContactModel.Result> GetContactByID(string ContactID)
        {
            try
            {
                var  client = new RestClient($"https://api.hubspot.com/crm/v3/objects/contacts/{ContactID}");

                var request = new RestRequest()

                    .AddQueryParameter("hapikey", "3ad5de2d-b2b7-450f-9396-8039cf878077");



                var response = await client.GetAsync<Objects.Contact.GetContactModel.Result>(request);

                return response;
            }
            catch (Exception ex) 
            {
                await Shell.Current.DisplayAlert(ex.Message, "Error From  Auth Service", "Cansel");
               
                Objects.Contact.GetContactModel.Result error = new Objects.Contact.GetContactModel.Result();
                return error ;
            }
            
        }
    }

}
