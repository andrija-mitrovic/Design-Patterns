using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class TweeterService
    {
        private string _appKey;
        private string _appSecret;

        public TweeterService(string appKey, string appSecret)
        {
            _appKey = appKey;
            _appSecret = appSecret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            return twitterClient.GetRecentTweets(GetAccessToken());
        }

        public string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken(_appKey, _appSecret);
            return oauth.GetAccessToken(requestToken);
        }
    }
}
