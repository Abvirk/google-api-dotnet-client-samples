//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Diacritize.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class LanguageDiacritizeCorpusResource : Google.Apis.Requests.IDirectResponseSchema {
        
        private string diacritized_text;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("diacritized_text")]
        public virtual string Diacritized_text {
            get {
                return this.diacritized_text;
            }
            set {
                this.diacritized_text = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
}
namespace Google.Apis.Diacritize.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class DiacritizeService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"diacritize:v1\",\"name\":\"diacritize\",\"ver" +
            "sion\":\"v1\",\"title\":\"Diacritize API\",\"description\":\"Lets you add diacritical mark" +
            "s to undiacritized text\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/prod" +
            "uct/search-16.gif\",\"x32\":\"http://www.google.com/images/icons/product/search-32.g" +
            "if\"},\"documentationLink\":\"http://code.google.com/apis/language/diacritize/v1/usi" +
            "ng_rest.html\",\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\":\"/language/diacriti" +
            "ze/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the res" +
            "ponse.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Con" +
            "tent-Type of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"d" +
            "escription\":\"Selector specifying which fields to include in a partial response.\"" +
            ",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key" +
            " identifies your project and provides you with API access, quota, and reports. R" +
            "equired unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token" +
            "\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"locati" +
            "on\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response wit" +
            "h indentations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser" +
            "\":{\"type\":\"string\",\"description\":\"Available to use for quota purposes for server" +
            "-side applications. Can be any arbitrary string assigned to a user, but should n" +
            "ot exceed 40 characters. Overrides userIp if both are provided.\",\"location\":\"que" +
            "ry\"},\"userIp\":{\"type\":\"string\",\"description\":\"IP address of the site where the r" +
            "equest originates. Use this if you want to enforce per-user limits.\",\"location\":" +
            "\"query\"}},\"features\":[\"dataWrapper\"],\"schemas\":{\"LanguageDiacritizeCorpusResourc" +
            "e\":{\"id\":\"LanguageDiacritizeCorpusResource\",\"type\":\"object\",\"properties\":{\"diacr" +
            "itized_text\":{\"type\":\"any\"}}}},\"resources\":{\"diacritize\":{\"resources\":{\"corpus\":" +
            "{\"methods\":{\"get\":{\"id\":\"language.diacritize.corpus.get\",\"path\":\"v1\",\"httpMethod" +
            "\":\"GET\",\"description\":\"Adds diacritical marks to the given message.\",\"parameters" +
            "\":{\"lang\":{\"type\":\"string\",\"description\":\"Language of the message\",\"required\":tr" +
            "ue,\"location\":\"query\"},\"last_letter\":{\"type\":\"boolean\",\"description\":\"Flag to in" +
            "dicate whether the last letter in a word should be diacritized or not\",\"required" +
            "\":true,\"location\":\"query\"},\"message\":{\"type\":\"string\",\"description\":\"Message to " +
            "be diacritized\",\"required\":true,\"location\":\"query\"}},\"parameterOrder\":[\"message\"" +
            ",\"last_letter\",\"lang\"],\"response\":{\"$ref\":\"LanguageDiacritizeCorpusResource\"}}}}" +
            "}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "diacritize";
        
        private const string BaseUri = "https://www.googleapis.com/language/diacritize/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected DiacritizeService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.diacritize = new DiacritizeResource(this);
        }
        
        public DiacritizeService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public DiacritizeService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(DiacritizeService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(DiacritizeService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class DiacritizeResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "diacritize";
        
        private CorpusResource corpus;
        
        public DiacritizeResource(DiacritizeService service) {
            this.service = service;
            this.corpus = new CorpusResource(service);
        }
        
        public virtual CorpusResource Corpus {
            get {
                return this.corpus;
            }
        }
        
        public class CorpusResource {
            
            private Google.Apis.Discovery.IRequestProvider service;
            
            private const string Resource = "diacritize.corpus";
            
            public CorpusResource(DiacritizeService service) {
                this.service = service;
            }
            
            /// <summary>Adds diacritical marks to the given message.</summary>
            /// <param name="message">Required - Message to be diacritized</param>
            /// <param name="last_letter">Required - Flag to indicate whether the last letter in a word should be diacritized or not</param>
            /// <param name="lang">Required - Language of the message</param>
            public virtual GetRequest Get(string message, bool last_letter, string lang) {
                return new GetRequest(service, message, last_letter, lang);
            }
            
            public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Diacritize.v1.Data.LanguageDiacritizeCorpusResource> {
                
                private string oauth_token;
                
                private System.Boolean? prettyPrint;
                
                private string quotaUser;
                
                private string lang;
                
                private bool last_letter;
                
                private string message;
                
                public GetRequest(Google.Apis.Discovery.IRequestProvider service, string message, bool last_letter, string lang) : 
                        base(service) {
                    this.message = message;
                    this.last_letter = last_letter;
                    this.lang = lang;
                }
                
                /// <summary>OAuth 2.0 token for the current user.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
                public virtual string Oauth_token {
                    get {
                        return this.oauth_token;
                    }
                    set {
                        this.oauth_token = value;
                    }
                }
                
                /// <summary>Returns response with indentations and line breaks.</summary>
                [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
                public virtual System.Boolean? PrettyPrint {
                    get {
                        return this.prettyPrint;
                    }
                    set {
                        this.prettyPrint = value;
                    }
                }
                
                /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
                public virtual string QuotaUser {
                    get {
                        return this.quotaUser;
                    }
                    set {
                        this.quotaUser = value;
                    }
                }
                
                /// <summary>Language of the message</summary>
                [Google.Apis.Util.RequestParameterAttribute("lang")]
                public virtual string Lang {
                    get {
                        return this.lang;
                    }
                }
                
                /// <summary>Flag to indicate whether the last letter in a word should be diacritized or not</summary>
                [Google.Apis.Util.RequestParameterAttribute("last_letter")]
                public virtual bool Last_letter {
                    get {
                        return this.last_letter;
                    }
                }
                
                /// <summary>Message to be diacritized</summary>
                [Google.Apis.Util.RequestParameterAttribute("message")]
                public virtual string Message {
                    get {
                        return this.message;
                    }
                }
                
                protected override string ResourcePath {
                    get {
                        return "diacritize.corpus";
                    }
                }
                
                protected override string MethodName {
                    get {
                        return "get";
                    }
                }
            }
        }
    }
    
    public partial class DiacritizeService {
        
        private const string Resource = "";
        
        private DiacritizeResource diacritize;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual DiacritizeResource Diacritize {
            get {
                return this.diacritize;
            }
        }
    }
}
