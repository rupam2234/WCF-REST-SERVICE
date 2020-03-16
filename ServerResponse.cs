using System.Runtime.Serialization;

namespace REST_WCF_SERVICE
{
    [DataContract]
    public class ServerResponse
    {
        
        [DataMember]
        public int error_code { set; get; }

        [DataMember]
        public string error_message { set; get; }


        public ServerResponse(int error_code, string error_message)
        {
            this.error_code = error_code;

            this.error_message = error_message;
        }
    }
}