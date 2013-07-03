using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hammock.Authentication.OAuth;

namespace TwitterApi
{
    //https://github.com/abraham/twitteroauth/tree/master/twitteroauth
    //https://dev.twitter.com/docs/twitter-libraries
    //https://github.com/danielcrenna/hammock2
    //http://stackoverflow.com/questions/3642873/cant-twitter-status-using-oauth-and-net-hammock-library-on-windows-phone-7
    //http://www.diplo.co.uk/blog/2010/8/9/oauth-with-twitter.aspx
    //

    public class TwitterApi
    {
        private IOAuthConfiguration _config;
        public TwitterApi(IOAuthConfiguration config)
        {
///bad
        }

        public string GetTimeLine()
        {
            return "";
        }
    }

    public class TwitterConfiguration : OAuthConfiguration
    {
        public TwitterConfiguration()
        {
            AccessTokenUrl = "https://api.twitter.com/oauth/access_token";
            AuthenticationUrl = "https://api.twitter.com/oauth/authenticate";
            AuthorizeUrl = "https://api.twitter.com/oauth/authorize";
            RequestTokenUrl = "https://api.twitter.com/oauth/request_token";

            Credentials = new OAuthCredentials()
                {
                    Type = OAuthType.ProtectedResource,
                    SignatureMethod = OAuthSignatureMethod.HmacSha1,
                    ParameterHandling = OAuthParameterHandling.HttpAuthorizationHeader,
                };
        }
    }

    public interface IOAuthConfiguration
    {
        string AccessTokenUrl { get; set; }
        string AuthenticationUrl { get; set; }
        string AuthorizeUrl { get; set; }
        string RequestTokenUrl { get; set; }
        OAuthCredentials Credentials { get; set; }
    }

    public class OAuthConfiguration : IOAuthConfiguration
    {
        public string AccessTokenUrl { get; set; }
        public string AuthenticationUrl { get; set; }
        public string AuthorizeUrl { get; set; }
        public string RequestTokenUrl { get; set; }

        public OAuthCredentials Credentials { get; set; }
    }
}
