using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_SERVICE
{
    // comment kot
    [ServiceContract]
    public interface IServices
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/users/{userID}", RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        List<UserDataCollection> GetUser(string userID);


        [OperationContract]

        [WebInvoke(Method = "POST", UriTemplate = "/users", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]

        ServerResponse PostData(UserDataCollection userDetails);

       
        [OperationContract]

        [WebInvoke(Method = "PUT", UriTemplate = "/users", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]

        ServerResponse PutData(UserDataCollection userDetails);


        [OperationContract]

        [WebInvoke(Method = "GET", UriTemplate = "/users", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]

        List<GetAllUsers> GetAllUsers();

    }
}
