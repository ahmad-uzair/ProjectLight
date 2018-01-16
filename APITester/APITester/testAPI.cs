//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace APITester
//{
//    class testAPI
//    {
//        const string BaseUrl = "https://api.losant.com";

//        readonly string _accountSid;
//        readonly string _secretKey;

//        public testAPI(string accountSid, string secretKey)
//        {
//            _accountSid = accountSid;
//            _secretKey = secretKey;
//        }

//        public T Execute<T>(RestRequest request) where T : new()
//        {
//            var client = new RestClient();
//            client.BaseUrl = new System.Uri(BaseUrl);
//            client.Authenticator = new HttpBasicAuthenticator(_accountSid, _secretKey);
//            request.AddParameter("AccountSid", _accountSid, ParameterType.UrlSegment); // used on every request
//            var response = client.Execute<T>(request);

//            if (response.ErrorException != null)
//            {
//                const string message = "Error retrieving response.  Check inner details for more info.";
//                var twilioException = new ApplicationException(message, response.ErrorException);
//                throw twilioException;
//            }
//            return response.Data;
//        }
//    }
//}
