using CommunityToolkit.Mvvm.ComponentModel;
using RestSharp;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using static PicoCRMx.Objects.Contact.CreateModel;

namespace PicoCRMx.Communication.SMS
{

    public partial class FarazSMS :  ObservableObject
    {

        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string operation;

        [ObservableProperty]
        public string[] data;

        private RestClient client { get; set; }

        
      

        public FarazSMS(string username ,   string operation , string password , [Optional] string[] data)
        {
            this.operation = operation;
            this.username = username;
            this.password = password;
            this.data = data;


            if (operation == "sendpattern")
            {
                if (data is null )
                {

                    Shell.Current.DisplayAlert("Alert", "The Data is null ", "Ok");
                    
                }
                else
                {
                    _ = GetPatternParams("fu117dsdtmamadz");
                    Shell.Current.DisplayAlert("Alert", "The Data is not null", "Ok");

                }


            }

        }

         
        string  SendPattern(string PatternCode  , string[] inputdata  )
        {
         


            return "";
        }
         

        async Task<Model.SMSModel.PatternResponse>  GetPatternParams(string patternCode)
        {
            await Shell.Current.DisplayAlert("Alert", "Enter GetPattern Params", "Ok");

            try
            {
                await Shell.Current.DisplayAlert("Alert 2", "GetPattern Params", "Ok");

                dynamic JsonString = new JObject();
                JsonString.op = Operation;
                JsonString.uname = Username;
                JsonString.pass = Password;
                JsonString.patternCode = patternCode;
                await Shell.Current.DisplayAlert("Alert 3", "GetPattern Params", "Ok");

                string PatternParams = Newtonsoft.Json.JsonConvert.SerializeObject(JsonString);
                await Shell.Current.DisplayAlert("Alert 4", "GetPattern Params", "Ok");

                var options = new RestClientOptions("https://ippanel.com/api/select")
                {
                    ThrowOnAnyError = true,

                    MaxTimeout = 10000,

                    UserAgent = "PicoApp v0.0.1dev"
                };
                await Shell.Current.DisplayAlert("Alert 5", "GetPattern Params", "Ok");

                var request = new RestRequest();

                request.AddHeader("Content-Type", "application/json");

                request.AddHeader("Accept", "application/json");


                request.AddJsonBody(PatternParams);

                await Shell.Current.DisplayAlert("Alert 6", "GetPattern Params", "Ok");

                var client = new RestClient(options);

                await Shell.Current.DisplayAlert("Alert 7", "GetPattern Params", "Ok");


                var response = await client.PostAsync<Model.SMSModel.PatternResponse>(request);

                await Shell.Current.DisplayAlert("Alert 8", "GetPattern Params", "Ok");


                await Shell.Current.DisplayAlert("Response", response.data.patternParams.Count().ToString(), "");



                return response;
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error",ex.Message, "");

                Model.SMSModel.PatternResponse pattern = new Model.SMSModel.PatternResponse();
                return pattern;

            }

        }
        async Task<bool> VerifyPatternCode(string id)
        {
            return false;
        }
    }

}

