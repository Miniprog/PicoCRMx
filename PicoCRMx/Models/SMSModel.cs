using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoCRMx.Communication.SMS.Model
{
    internal class SMSModel
    {


      
        
        public class PatternResponse
        {

            public Status status { get; set; }
               
            public Data data { get; set; }

            public class Status
            {
                public int code { get; set; }
                public string errorMessage { get; set; }
                public int level { get; set; }
            }

            public class Data
            {
                public string patternCode { get; set; }
                public string patternMessage { get; set; }
                public string[] patternParams { get; set; }
            }

        }
    }
}
