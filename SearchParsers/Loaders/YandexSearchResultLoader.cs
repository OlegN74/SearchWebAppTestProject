using System;
using System.Globalization;
using HtmlAgilityPack;
using SearchEngine.Contract;
using xNet.Net;

namespace SearchEngine.Implementation.Loaders
{
    public class YandexSearchResultLoader: BaseSearchResultLoader
    {
        private string _url;
        private string _userAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en) AppleWebKit / 419(KHTML, like Gecko) Safari / 419.3";
        private string _accept = "image/gif, image/x-xbitmap, image/jpeg, image / pjpeg, application / x - shockwave - flash, application / vnd.ms - excel, application / vnd.ms - powerpoint, application / msword, */*";

        CookieDictionary cookie = new CookieDictionary();
        HttpRequest request = new HttpRequest();

        public override void Configure(string searchString, ISearchEngineConfiguration config)
        {
            Logger.Debug("We are in YandexSearchResultLoader.Configure");

            _url = String.Format(CultureInfo.InvariantCulture, @"http://yandex.ru/yandsearch?text={0}&numdoc={1}&p=0&rnd=28759", HttpHelper.UrlEncode(searchString), config.MaxResultCount);
            request.Cookies = cookie;
            request.UserAgent = HttpHelper.FirefoxUserAgent();
        }

        public override string LoadData()
        {
            string result = String.Empty;
            Logger.Debug("We are in YandexSearchResultLoader.Configure");

            request.Referer = HttpHelper.UrlEncode(_url);
            HttpResponse response = request.Get(_url);
            var content = response.ToString();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(content);

            var nodes = doc.DocumentNode.SelectNodes("//div[@class='b-captcha']");
            if (nodes != null)
            {
                // TODO: Captcha handling and get response with search result
            }

            result = content;

            return result;
        }
    }
}
