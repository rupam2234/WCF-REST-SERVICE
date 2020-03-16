using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace REST_WCF_SERVICE
{
    [DataContract]
    public class UserDataCollection  // Available data members for the server
    {
       
            [DataMember]
            public string id { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string age { get; set; }

            public UserDataCollection()
            {

            }

    }

 }