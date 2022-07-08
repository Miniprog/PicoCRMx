

namespace PicoCRMx.Objects.Contact
{


    public class CreateModel
    {
        public class Request
        {

            public Properties properties { get; set; }
            public string status { get; set; }
            public string message { get; set; }
            public string correlationId { get; set; }
            public string category { get; set; }

            public class Properties
            {
                public string email { get; set; }
                public string firstname { get; set; }
                public string lastname { get; set; }
                public string phone { get; set; }
                public string online_bought { get; set; }

                public string pos_activity { get; set; }
                public string cash_activity { get; set; }

                public string hs_content_membership_status { get; set; }


            }

        }

        public class Response
        {

            public string id { get; set; }

            public Properties properties { get; set; }

            public DateTime createdAt { get; set; }

            public DateTime updatedAt { get; set; }

            public bool archived { get; set; }


            public class Properties
            {
                public string cash_activity { get; set; }

                public DateTime createdate { get; set; }
                public string email { get; set; }
                public string firstname { get; set; }
                public string hs_is_contact { get; set; }
                public string hs_object_id { get; set; }
                public string hs_pipeline { get; set; }
                public DateTime lastmodifieddate { get; set; }
                public string lastname { get; set; }
                public string online_bought { get; set; }
                public string phone { get; set; }
                public string pos_activity { get; set; }
            }

        }


    }


    public class GetContactModel
    {

       
           
        public List<Result> results { get; set; }
           
        public Paging paging { get; set; }
 
        public class Paging
        {
            public Next next { get; set; }
        }

        public class Next
        {
            public string after { get; set; }
            public string link { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public Properties properties { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public bool archived { get; set; }
        }

        public class Properties
        {
            public string cash_activity { get; set; }

            public DateTime createdate { get; set; }
            public string email { get; set; }
            public string firstname { get; set; }
            public string hs_is_contact { get; set; }
            public string hs_object_id { get; set; }
            public string hs_pipeline { get; set; }
            public DateTime lastmodifieddate { get; set; }
            public string lastname { get; set; }
            public string online_bought { get; set; }
            public string phone { get; set; }
            public string pos_activity { get; set; }
        }

    }
}
