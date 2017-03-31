using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Parsers
{
    public class YandexSearchResultParser: BaseSearchResultParser
    {
        public override bool TryParse(string content, out IEnumerable<SearchResult> resultsList)
        {
            bool result = !String.IsNullOrWhiteSpace(content);
            Logger.Debug("We are in YandexSearchResultParser.TryParse");

            resultsList = new List<SearchResult>();

            var resultsList1 = new List<SearchResult>();
            var doc = new HtmlDocument();
            doc.LoadHtml(content);
            try
            {
                var nodes = doc.DocumentNode.SelectNodes("//ul//li[contains(concat(@class, ' '), 'serp-item ')]");
                if (nodes != null)
                {
                    foreach (HtmlNode node in nodes)
                    {
                        string itemUrl = string.Empty;
                        string itemText = string.Empty;
                        string itemSubject = string.Empty;

                        var itemDoc = new HtmlDocument();
                        itemDoc.LoadHtml(node.InnerHtml);
                        var href = itemDoc.DocumentNode.SelectSingleNode("//h2//a");
                        if (href != null)
                        {
                            itemUrl = href.Attributes["href"].Value;
                            itemSubject = href.InnerText;
                        }

                        var itemTextNode = itemDoc.DocumentNode.SelectSingleNode("//div[@class='organic__content-wrapper']//div[@class='text-container typo typo_text_m typo_line_m organic__text']");
                        if (itemTextNode != null)
                        {
                            itemText = itemTextNode.InnerText;
                        }

                        var resultItem = new SearchResult();
                        resultItem.RawDara = node.OuterHtml;
                        resultItem.Subject = itemSubject;
                        resultItem.Text = itemText;
                        resultItem.Url = itemUrl;
                        resultsList1.Add(resultItem);
                    }
                }
            }
            catch (Exception e)
            {
                result = false;
                Logger.Error(e);
            }

            resultsList = resultsList1;
            return result;
        }
    }
}
