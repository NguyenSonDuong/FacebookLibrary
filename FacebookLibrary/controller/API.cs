using FacebookLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FacebookLibrary.controller
{
    public class API
    {
        private RequestData requestData;
        private Chilkat.Http httpRequest;
        private String cookie;
        private String useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
        public RequestData RequestData { get => requestData; set => requestData = value; }
        public string Cookie { get => cookie; set => cookie = value; }

        public API(bool isSaveCookie = true)
        {
            httpRequest = new Chilkat.Http();
            httpRequest.SaveCookies = isSaveCookie;
            httpRequest.SendCookies = isSaveCookie;
            httpRequest.CookieDir = "memory";
        }
        public API(Chilkat.Http http)
        {
            this.httpRequest = http;
        }
        public String POST()
        {
            try
            {
                if(String.IsNullOrEmpty(requestData.Av) || String.IsNullOrEmpty(requestData.User))
                {
                    requestData.Av = Regex.Match(cookie, "c_user=([0-9]+);",RegexOptions.Multiline).Groups[1].Value;
                    requestData.User = Regex.Match(cookie, "c_user=([0-9]+);",RegexOptions.Multiline).Groups[1].Value;
                }
                Chilkat.HttpRequest http = requestData.GetRequest();
                http.HttpVerb = "POST";
                http.AddHeader("Cookie", cookie);
                http.AddHeader("User-Agent", useragent);
                httpRequest.SetRequestHeader("Cookie", cookie);
                httpRequest.SetRequestHeader("User-Agent", useragent);
                Chilkat.HttpResponse httpResponse = httpRequest.PostUrlEncoded(Host.HOST_COOKIE, http);
                if(httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse.StatusText);
                }
                return httpResponse.BodyStr;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
