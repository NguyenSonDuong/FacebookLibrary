using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLibrary.model
{
    public class RequestData
    {
        private String av;
        private String __user;
        private String __a = "1";
        private String dpr = "1";
        private String fb_dtsg;
        private String fb_api_caller_class = "RelayModern";
        private String fb_api_req_friendly_name;
        private String variables;
        private String server_timestamps = "true";
        private String doc_id;

        public RequestData()
        {

        }
        public Chilkat.HttpRequest GetRequest()
        {
            Chilkat.HttpRequest http = new Chilkat.HttpRequest();
            http.AddParam("av", av);
            http.AddParam("__user", __user);
            http.AddParam("__a", __a);
            http.AddParam("dpr", dpr);
            http.AddParam("fb_dtsg", fb_dtsg);
            http.AddParam("fb_api_caller_class", fb_api_caller_class);
            http.AddParam("fb_api_req_friendly_name", fb_api_req_friendly_name);
            http.AddParam("variables", variables);
            http.AddParam("server_timestamps", server_timestamps);
            http.AddParam("doc_id", doc_id);
            return http;
        }
        public RequestData(String av,String user,String a,String dpr,String fb_dtsg,String fb_api_caller, String fb_api_req,String varivales,String server,String doc_id)
        {
            this.av = av;
            this.__user = user;
            this.__a = a;
            this.dpr = dpr;
            this.fb_dtsg = fb_dtsg;
            this.fb_api_caller_class = fb_api_caller;
            this.fb_api_req_friendly_name = fb_api_req;
            this.variables = varivales;
            this.server_timestamps = server;
            this.doc_id = doc_id;

        }

        public string Av { get => av; set => av = value; }
        public string User { get => __user; set => __user = value; }
        public string A { get => __a; set => __a = value; }
        public string Dpr { get => dpr; set => dpr = value; }
        public string Fb_dtsg { get => fb_dtsg; set => fb_dtsg = value; }
        public string Fb_api_caller_class { get => fb_api_caller_class; set => fb_api_caller_class = value; }
        public string Fb_api_req_friendly_name { get => fb_api_req_friendly_name; set => fb_api_req_friendly_name = value; }
        public string Variables { get => variables; set => variables = value; }
        public string Server_timestamps { get => server_timestamps; set => server_timestamps = value; }
        public string Doc_id { get => doc_id; set => doc_id = value; }

        public override string ToString()
        {
            return $"av={Av}&__user={User}&__a={A}&dpr={Dpr}&fb_dtsg={Fb_dtsg}&fb_api_caller_class={Fb_api_caller_class}&fb_api_req_friendly_name={Fb_api_req_friendly_name}&variables={Variables}&server_timestamps={Server_timestamps}&doc_id={Doc_id}";
        }
    }
}
