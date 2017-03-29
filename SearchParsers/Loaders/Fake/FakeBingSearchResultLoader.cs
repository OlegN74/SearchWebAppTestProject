using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.Contract;

namespace SearchEngine.Implementation.Loaders.Fake
{
    class FakeBingSearchResultLoader : BaseSearchResultLoader
    {
        private string _url;
        public override void Configure(string searchString, ISearchEngineConfiguration config)
        {
            Logger.Debug("We are in FakeBingSearchResultLoader.Configure");
        }

        public override string LoadData()
        {
            string result = _responseJson;
            Logger.Debug("We are in FakeBingSearchResultLoader.Configure");
            Logger.DebugFormat(CultureInfo.InvariantCulture, "Data: {0}", result);

            return result;
        }

        private string _responseJson = @"
            {
              '_type': 'SearchResponse',
              'queryContext': {
                'originalQuery': 'bing sqarch api',
                'alteredQuery': 'bing search api',
                'alterationOverrideQuery': '+bing sqarch api',
                'adultIntent': false
              },
              'webPages': {
                'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=tWM-XK4WvTojdbV_Y-pFeHy0M77OoNABX1NZ88tiQPs&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bsqarch%2bapi&p=DevEx,5408.1',
                'totalEstimatedMatches': 3660000,
                'value': [
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.0',
                    'name': '<b>Bing</b> for Partners helps businesses and developers succeed',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=s3n5ggaPHnbkXLVPxQpyR2apIImCj5Kys5CNJ_QjXNc&v=1&r=http%3a%2f%2fwww.bing.com%2fdev%2fen-us%2fdev-center&p=DevEx,5075.1',
                    'displayUrl': 'www.<b>bing</b>.com/dev/en-us/dev-center',
                    'snippet': '<b>Bing</b> Webmaster Tools; <b>Developer</b> Assistant for Visual ... The <b>Bing Search</b> APIs are just one call away—and ... The <b>Bing</b> Ads <b>API</b> also supports various customer ...',
                    'dateLastCrawled': '2017-03-24T22:25:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.1',
                    'name': '<b>Microsoft</b> Cognitive Services - <b>Bing Web Search API</b>',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=ZXq5Tx_EwefG11YVsw39_MbwNdq-iMUFoMRPOg82EMs&v=1&r=http%3a%2f%2fwww.microsoft.com%2fcognitive-services%2fen-us%2fbing-web-search-api&p=DevEx,5089.1',
                    'displayUrl': '<b>www.microsoft.com</b>/cognitive-services/en-us/<b>bing-web-search-api</b>',
                    'snippet': '<b>Bing Web Search API</b> . Bring intelligent <b>search</b> to your apps and harness the ability to comb billions of webpages, images, videos, and news with a single <b>API</b> call.',
                    'dateLastCrawled': '2017-03-26T01:32:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.2',
                    'name': '<b>Bing</b> <b>Search</b> <b>API</b> | <b>Microsoft</b> Azure Marketplace',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=8X-_nCxwNZt1fA7STxIpiFfbhOjDZGspRsyRTEmTOzI&v=1&r=http%3a%2f%2fdatamarket.azure.com%2fdataset%2fbing%2fsearch&p=DevEx,5103.1',
                    'about': [
                      {
                        'name': 'Bing'
                      }
                    ],
                    'displayUrl': 'datamarket.azure.com/dataset/<b>bing</b>/<b>search</b>',
                    'snippet': 'What is the <b>Bing Search API</b>? The <b>Bing Search API</b> enables developers to embed <b>search</b> results in applications or websites using XML or JSON.',
                    'dateLastCrawled': '2017-03-21T00:31:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.3',
                    'name': '<b>Microsoft</b> Cognitive Services &gt; <b>Bing</b> <b>Search</b> APIs',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=AOl69sXEkxh0NBumfq_y3TbGt_I59-9AecZFnPZr-Ag&v=1&r=https%3a%2f%2fazure.microsoft.com%2fen-us%2fservices%2fcognitive-services%2fsearch%2f&p=DevEx,5116.1',
                    'displayUrl': 'https://<b>azure.microsoft.com</b>/en-us/services/cognitive-services/<b>search</b>',
                    'snippet': '<b>Bing</b> Video <b>Search API Search</b> for videos and get comprehensive results. Find videos across the web. Results provide useful metadata including creator, ...',
                    'dateLastCrawled': '2017-03-26T12:53:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.4',
                    'name': '<b>API Basics</b> - <b>Bing</b>',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=4bnLWcl6CIfJNnQIfKdkgDLX1N0j0jp0J7hFH_q5IEY&v=1&r=http%3a%2f%2fwww.bing.com%2fdevelopers%2fs%2fapibasics.html&p=DevEx,5129.1',
                    'displayUrl': 'www.<b>bing</b>.com/<b>developer</b>s/s/<b>apibasics</b>.html',
                    'snippet': 'Introducing <b>Bing API Version 2</b>.0. This whitepaper introduces <b>Bing API Version 2</b>.0 and provides the information you need to begin. developing applications with the <b>API</b>.',
                    'dateLastCrawled': '2017-03-21T10:11:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.5',
                    'name': '<b>Bing API, Version 2</b> - <b>msdn.microsoft.com</b>',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=MAWoFJwlVkBcdSmzIxJ0_hKaxo090Vy1m3veX6tCYT8&v=1&r=https%3a%2f%2fmsdn.microsoft.com%2fen-us%2flibrary%2fdd251056.aspx&p=DevEx,5145.1',
                    'displayUrl': 'https://<b>msdn.microsoft.com</b>/en-us/library/dd251056.aspx',
                    'snippet': '<b>Bing API</b> documentation is organized with the intent to provide overview, survey, and detailed information for each important area of the <b>API</b>. Thus, the documentation:',
                    'dateLastCrawled': '2017-03-13T15:47:00',
                    'searchTags': [
                      {
                        'name': 'search.mshkeyworda',
                        'content': '&quot;d9259d00-86ab-46d1-9c32-ba8a080d48f3&quot;; d9259d00; 86ab; 46d1; 9c32; ba8a080d48f3'
                      },
                      {
                        'name': 'search.mshattr.locale',
                        'content': '&quot;kbEnglish&quot;; kbenglish'
                      },
                      {
                        'name': 'search.mshattr.assetid',
                        'content': '&quot;d9259d00-86ab-46d1-9c32-ba8a080d48f3&quot;; d9259d00; 86ab; 46d1; 9c32; ba8a080d48f3'
                      },
                      {
                        'name': 'search.mshattr.topictype',
                        'content': '&quot;kbArticle&quot;; kbarticle'
                      },
                      {
                        'name': 'search.description',
                        'content': '&quot;The Bing Application Programming Interface (API), Version 2, enables developers to programmatically submit queries to and retrieve results from the Bing Engine. This topic introduces the online documentation and additional resources that support use of th&quot;; the; bing; application; programming; interface; api; version; 2; enables; developers; to; programmatically; submit; queries; to; and; retrieve; results; from; the; bing; engine; this; topic; introduces; the; online; documentation; and; additional; resources; that; support; use; of; th'
                      },
                      {
                        'name': 'search.mshattr.abstract',
                        'content': '&quot;The Bing Application Programming Interface (API), Version 2, enables developers to programmatically submit queries to and retrieve results from the Bing Engine. This topic introduces the online documentation and additional resources that support use of th&quot;; the; bing; application; programming; interface; api; version; 2; enables; developers; to; programmatically; submit; queries; to; and; retrieve; results; from; the; bing; engine; this; topic; introduces; the; online; documentation; and; additional; resources; that; support; use; of; th'
                      },
                      {
                        'name': 'search.mshattr.docsettitle',
                        'content': '&quot;Bing API&quot;; bing; api'
                      },
                      {
                        'name': 'search.mshattr.docsetroot',
                        'content': '&quot;Dd251056&quot;; dd251056'
                      },
                      {
                        'name': 'search.save',
                        'content': '&quot;history&quot;; history'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;ms310241&quot;; ms310241'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;ms310241MSDN10&quot;; ms310241msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;ee702802&quot;; ee702802'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;ee702802MSDN10&quot;; ee702802msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;dd877967&quot;; dd877967'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;dd877967MSDN10&quot;; dd877967msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;dn262697&quot;; dn262697'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;dn262697MSDN10&quot;; dn262697msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;dd904329&quot;; dd904329'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;dd904329MSDN10&quot;; dd904329msdn10'
                      },
                      {
                        'name': 'search.tocnodeid',
                        'content': '&quot;dd904329&quot;; dd904329'
                      },
                      {
                        'name': 'search.rating',
                        'content': '&quot;58.849129&quot;; 58; 849129'
                      },
                      {
                        'name': 'search.rating.fivestarscale',
                        'content': '&quot;2.94245645&quot;; 2; 94245645'
                      },
                      {
                        'name': 'search.roottocid',
                        'content': '&quot;ms310241&quot;; ms310241'
                      },
                      {
                        'name': 'search.library.vs.alm.url',
                        'content': '&quot;https://msdn.microsoft.com/en-us/library/vs/alm/dd251056.aspx&quot;; https; msdn; microsoft; com; en; us; library; vs; alm; dd251056; aspx'
                      },
                      {
                        'name': 'search.library.url',
                        'content': '&quot;https://msdn.microsoft.com/en-us/library/dd251056.aspx&quot;; https; msdn; microsoft; com; en; us; library; dd251056; aspx'
                      },
                      {
                        'name': 'search.shortid',
                        'content': '&quot;dd251056&quot;; dd251056'
                      }
                    ]
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.6',
                    'name': '<b>Bing Search API – Web Results Only</b> | <b>Microsoft</b> Azure ...',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=NmbWY_km38xc3o2AH6ALeEzg2Q_QsivfOQuq-QzqoYk&v=1&r=http%3a%2f%2fdatamarket.azure.com%2fdataset%2fbing%2fsearchweb&p=DevEx,5159.1',
                    'displayUrl': 'datamarket.azure.com/dataset/<b>bing</b>/<b>search</b>web',
                    'snippet': 'TO CONTINUE USAGE AFTER DECEMBER 15, 2016 . The Azure Marketplace &quot;<b>Bing Search</b>&quot; and &quot;<b>Bing Search</b> Web Results Only&quot; <b>API</b> offerings will end of life on December 15, 2016.',
                    'dateLastCrawled': '2017-03-25T23:22:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.7',
                    'name': 'Basics of <b>Bing</b> <b>Search</b> <b>API</b> using .NET - CodeProject',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=Gf3nZdg0URrUtczfn5UDRXj_ihyna6oEb2U6KbQ5APc&v=1&r=https%3a%2f%2fwww.codeproject.com%2farticles%2f43419%2fbasics-of-bing-search-api-using-net&p=DevEx,5175.1',
                    'displayUrl': 'https://<b>www.codeproject.com</b>/.../basics-of-<b>bing</b>-<b>search</b>-<b>api</b>-using-net',
                    'snippet': 'This article will enable you to add custom <b>search</b> rules to your application using <b>Bing Search API</b> with much more',
                    'dateLastCrawled': '2017-03-21T18:30:00'
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.8',
                    'name': '<b>Bing API, Version 2</b> - <b>msdn.microsoft.com</b>',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=dbtg53KSHPmklAXGVwjBrRiPtf8a8U63-LM-OEqf2dA&v=1&r=https%3a%2f%2fmsdn.microsoft.com%2fen-us%2flibrary%2fdd900818.aspx&p=DevEx,5191.1',
                    'displayUrl': 'https://<b>msdn.microsoft.com</b>/en-us/library/dd900818.aspx',
                    'snippet': 'The <b>Bing Application Programming Interface</b> (<b>API</b>), Version 2, enables developers to programmatically submit queries to and retrieve results from the <b>Bing</b> Engine. This ...',
                    'dateLastCrawled': '2017-02-12T18:03:00',
                    'searchTags': [
                      {
                        'name': 'search.mshkeyworda',
                        'content': '&quot;2980429e-6034-4695-a990-30171d16974d&quot;; 2980429e; 6034; 4695; a990; 30171d16974d'
                      },
                      {
                        'name': 'search.mshattr.locale',
                        'content': '&quot;kbEnglish&quot;; kbenglish'
                      },
                      {
                        'name': 'search.mshattr.assetid',
                        'content': '&quot;2980429e-6034-4695-a990-30171d16974d&quot;; 2980429e; 6034; 4695; a990; 30171d16974d'
                      },
                      {
                        'name': 'search.mshattr.topictype',
                        'content': '&quot;kbArticle&quot;; kbarticle'
                      },
                      {
                        'name': 'search.description',
                        'content': '&quot;The Bing Application Programming Interface (API), Version 2, enables developers to programmatically submit queries to and retrieve results from the Bing Engine. This topic introduces the online documentation and additional resources that support use of th&quot;; the; bing; application; programming; interface; api; version; 2; enables; developers; to; programmatically; submit; queries; to; and; retrieve; results; from; the; bing; engine; this; topic; introduces; the; online; documentation; and; additional; resources; that; support; use; of; th'
                      },
                      {
                        'name': 'search.mshattr.abstract',
                        'content': '&quot;The Bing Application Programming Interface (API), Version 2, enables developers to programmatically submit queries to and retrieve results from the Bing Engine. This topic introduces the online documentation and additional resources that support use of th&quot;; the; bing; application; programming; interface; api; version; 2; enables; developers; to; programmatically; submit; queries; to; and; retrieve; results; from; the; bing; engine; this; topic; introduces; the; online; documentation; and; additional; resources; that; support; use; of; th'
                      },
                      {
                        'name': 'search.mshattr.docsettitle',
                        'content': '&quot;Bing API&quot;; bing; api'
                      },
                      {
                        'name': 'search.mshattr.docsetroot',
                        'content': '&quot;Dd900818&quot;; dd900818'
                      },
                      {
                        'name': 'search.save',
                        'content': '&quot;history&quot;; history'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;ms310241&quot;; ms310241'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;ms310241MSDN10&quot;; ms310241msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;ee702802&quot;; ee702802'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;ee702802MSDN10&quot;; ee702802msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;dd877967&quot;; dd877967'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;dd877967MSDN10&quot;; dd877967msdn10'
                      },
                      {
                        'name': 'search.mscategory',
                        'content': '&quot;dn262697&quot;; dn262697'
                      },
                      {
                        'name': 'search.mscategoryv',
                        'content': '&quot;dn262697MSDN10&quot;; dn262697msdn10'
                      },
                      {
                        'name': 'search.tocnodeid',
                        'content': '&quot;dn262697&quot;; dn262697'
                      },
                      {
                        'name': 'search.rating',
                        'content': '&quot;59.237089&quot;; 59; 237089'
                      },
                      {
                        'name': 'search.rating.fivestarscale',
                        'content': '&quot;2.96185445&quot;; 2; 96185445'
                      },
                      {
                        'name': 'search.roottocid',
                        'content': '&quot;ms310241&quot;; ms310241'
                      },
                      {
                        'name': 'search.library.vs.alm.url',
                        'content': '&quot;https://msdn.microsoft.com/en-us/library/vs/alm/dd900818.aspx&quot;; https; msdn; microsoft; com; en; us; library; vs; alm; dd900818; aspx'
                      },
                      {
                        'name': 'search.library.url',
                        'content': '&quot;https://msdn.microsoft.com/en-us/library/dd900818.aspx&quot;; https; msdn; microsoft; com; en; us; library; dd900818; aspx'
                      },
                      {
                        'name': 'search.shortid',
                        'content': '&quot;dd900818&quot;; dd900818'
                      }
                    ]
                  },
                  {
                    'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.9',
                    'name': 'New <b>Bing</b> <b>Search</b> <b>API</b> portfolio now available | <b>Bing</b> <b>Search</b> Blog',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=3DIuMz80UBDd9SjGAq_csflaArJTNSG_NXGWYUIzCTM&v=1&r=http%3a%2f%2fblogs.bing.com%2fsearch%2fjuly-2016%2fnew-bing-search-api-portfolio-now-available&p=DevEx,5203.1',
                    'displayUrl': 'blogs.<b>bing</b>.com/<b>search</b>/july-2016/new-<b>bing</b>-<b>search</b>-<b>api</b>-portfolio-now...',
                    'snippet': 'Starting July 1, the new <b>Bing Search API</b> portfolio is available for purchase as a <b>Microsoft</b> Azure Marketplace offering. The <b>Bing Search API</b> portfolio',
                    'dateLastCrawled': '2017-03-17T15:46:00'
                  }
                ]
              },
              'news': {
                'id': 'https://api.cognitive.microsoft.com/api/v5/#News',
                'readLink': 'https://api.cognitive.microsoft.com/api/v5/news/search?q=Bing+Search+API',
                'value': [
                  {
                    'name': '<b>Bing</b> Web <b>Search</b> <b>API</b>',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=U2ZcBE8Vf4y1bcdvEtW6o0SByN5K5fvpPx3Rc9vcRd0&v=1&r=https%3a%2f%2fwww.microsoft.com%2fcognitive-services%2fen-us%2fbing-web-search-api&p=DevEx,5264.1',
                    'description': 'Retrieve web documents indexed by <b>Bing</b> and narrow down the results by result type, freshness and more. Try out the demo. Submit a query via the <b>search</b> box or click on one of the provided examples. S1 Standard 1000 calls per month $3 per month, no overage ...',
                    'about': [
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/a093e9b9-90f5-a3d5-c4b8-5855e1b01f85',
                        'name': 'Microsoft'
                      },
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/cf920b15-490e-78cc-b7b8-6a2e7000133e',
                        'name': 'Bing'
                      }
                    ],
                    'provider': [
                      {
                        '_type': 'Organization',
                        'name': 'Microsoft'
                      }
                    ],
                    'datePublished': '2017-03-29T05:53:00'
                  },
                  {
                    'name': 'Microsoft bot developers can now use new cognitive services and <b>Bing</b> APIs',
                    'url': 'http://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=-vUKsqZS63KDTto89LdYzSnE8F3ULyTK18D8j73J2wk&v=1&r=http%3a%2f%2fwww.onlinelivingblog.com%2f2017%2f03%2fmicrosoft-bot-developers-can-now-use.html&p=DevEx,5267.1',
                    'description': 'To begin with, Microsoft has given them access to the Cognitive Services Computer Vision <b>API</b>, which basically allows developers to have their bots describe images. Also, they incorporate Speech APIs and <b>Bing</b> Image <b>Search</b> to the Bot Framework, which is the ...',
                    'about': [
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/a093e9b9-90f5-a3d5-c4b8-5855e1b01f85',
                        'name': 'Microsoft'
                      }
                    ],
                    'provider': [
                      {
                        '_type': 'Organization',
                        'name': 'onlinelivingblog.com'
                      }
                    ],
                    'datePublished': '2017-03-24T07:38:00',
                    'category': 'ScienceAndTechnology'
                  },
                  {
                    'name': 'Cloud4Good: Building an Inclusive Chat Bot for Athletes with Disabilities',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=l6A9LLklFDl7Ccx_rHeezoG_4AIoEXDZvywAWJ2UKaM&v=1&r=https%3a%2f%2fblogs.technet.microsoft.com%2fcanitpro%2f2017%2f03%2f22%2fcloud4good-building-an-inclusive-chat-bot-for-athletes-with-disabilities%2f&p=DevEx,5269.1',
                    'image': {
                      'contentUrl': 'https://msdnshared.blob.core.windows.net/media/2017/03/viaSport_bot.png',
                      'thumbnail': {
                        'contentUrl': 'https://www.bing.com/th?id=ON.DB210E55EE79C70A887108BEB42BFBC1&pid=News',
                        'width': 613,
                        'height': 700
                      }
                    },
                    'description': 'structuring a call out to the <b>API</b> in question, and parsing the JSON response to pull out the desired information. Here is how the <b>Bing</b> Web <b>Search</b> <b>API</b> is implemented in the viaSport bot: The <b>Bing</b> Web <b>Search</b> <b>API</b> is used in the bot to <b>search</b> the web for ...',
                    'about': [
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/1d69e67c-8de6-550e-3508-0a3a46ac2b2e',
                        'name': 'Athletes'
                      },
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/a1677bd5-9ddc-55e0-e9ff-aaffba403a69',
                        'name': 'Building'
                      }
                    ],
                    'provider': [
                      {
                        '_type': 'Organization',
                        'name': 'blogs.technet.microsoft.com'
                      }
                    ],
                    'datePublished': '2017-03-22T11:29:00',
                    'category': 'ScienceAndTechnology'
                  },
                  {
                    'name': 'Language analyzers (Azure <b>Search</b> Service REST <b>API</b>)',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=F601NX2xkj07h5qXoftIp8RUmcluQbW2UUo_xBIhjAM&v=1&r=https%3a%2f%2fdocs.microsoft.com%2fen-us%2frest%2fapi%2fsearchservice%2flanguage-support&p=DevEx,5271.1',
                    'description': '50 analyzers backed by proprietary Microsoft natural language processing technology used in Office and <b>Bing</b>. Some developers might prefer ... See Create Index (Azure <b>Search</b> Service REST <b>API</b>) for details on how to specify the language analyzer on a field ...',
                    'provider': [
                      {
                        '_type': 'Organization',
                        'name': 'docs.microsoft.com'
                      }
                    ],
                    'datePublished': '2017-03-17T07:29:00',
                    'category': 'ScienceAndTechnology'
                  },
                  {
                    'name': 'Is it Legal to Scrape Google <b>Search</b> Results? How can you do it legally',
                    'url': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=8CmfPlslSYqeo25TUzTM_GJw7vMvHA7TNFaPor8SaLM&v=1&r=https%3a%2f%2flatesthackingnews.com%2f2017%2f03%2f20%2flegal-scrape-google-search-results-can-legally%2f&p=DevEx,5273.1',
                    'image': {
                      'contentUrl': 'https://i1.wp.com/latesthackingnews.com/wp-content/uploads/2017/03/photo.jpg?resize=800%2C445&ssl=1',
                      'thumbnail': {
                        'contentUrl': 'https://www.bing.com/th?id=ON.17389093E5DE6898C4C274BE2231E3CA&pid=News',
                        'width': 700,
                        'height': 389
                      }
                    },
                    'description': 'Even Microsoft scraped Google Results, they powered their <b>search</b> engine <b>Bing</b> with it. They got caught in 2011 red ... If you want a higher amounts of <b>API</b> requests you need to pay. 60 requests per hours cost 2000 USD per year, more query require a custom ...',
                    'about': [
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/d6f89c6a-be11-d0ef-6a34-bc82cc412347',
                        'name': 'Scrape'
                      },
                      {
                        'readLink': 'https://api.cognitive.microsoft.com/api/v5/entities/0edabf9c-4239-7a77-3fd7-c2709549473e',
                        'name': 'Google Search'
                      }
                    ],
                    'provider': [
                      {
                        '_type': 'Organization',
                        'name': 'latesthackingnews.com'
                      }
                    ],
                    'datePublished': '2017-03-20T14:19:00',
                    'category': 'ScienceAndTechnology'
                  }
                ]
              },
              'relatedSearches': {
                'id': 'https://api.cognitive.microsoft.com/api/v5/#RelatedSearches',
                'value': [
                  {
                    'text': 'bing search api pricing',
                    'displayText': '<b>bing</b> <b>search</b> <b>api</b> pricing',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=FWE0_BpFCZiza-AVbnHg23wdGjy2mv1AhrnC4s5mW5Q&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bsearch%2bapi%2bpricing&p=DevEx,5409.1'
                  },
                  {
                    'text': 'bing web search api',
                    'displayText': '<b>bing</b> web <b>search</b> <b>api</b>',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=uZ0L8wunzl3hgD9xRbCHuKThOYuy5Tj18Bl3Obz8-z8&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bweb%2bsearch%2bapi&p=DevEx,5410.1'
                  },
                  {
                    'text': 'google search api',
                    'displayText': 'google <b>search</b> <b>api</b>',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=gbIcM2vLGCuEq0wrrwk8N1upwosUVzaJdOvUBWvOkmc&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dgoogle%2bsearch%2bapi&p=DevEx,5411.1'
                  },
                  {
                    'text': 'bing custom search engine',
                    'displayText': '<b>bing</b> custom <b>search</b> engine',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=WlqFss_JZf-A9CjlozBCwKP3H0ndDsWM8WOXcVOigyI&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bcustom%2bsearch%2bengine&p=DevEx,5412.1'
                  },
                  {
                    'text': 'how to use bing api',
                    'displayText': 'how to use <b>bing</b> <b>api</b>',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=UvM6ICPd7WnuGY3vctM-fnzW0mYl2mqmEZq7qamymvM&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dhow%2bto%2buse%2bbing%2bapi&p=DevEx,5413.1'
                  },
                  {
                    'text': 'azure bing search',
                    'displayText': 'azure <b>bing</b> <b>search</b>',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=k8F1P3IVopCyNkSTZwA3aXsOqaVDqmvXA8BfBB8KtAE&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dazure%2bbing%2bsearch&p=DevEx,5414.1'
                  },
                  {
                    'text': 'bing search api key',
                    'displayText': '<b>bing</b> <b>search</b> <b>api</b> key',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=ahLA0e1sfzIuYwHDy4orSK5Px1QovS6Q_CBbmYuEw-4&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bsearch%2bapi%2bkey&p=DevEx,5415.1'
                  },
                  {
                    'text': 'bing search api python',
                    'displayText': '<b>bing</b> <b>search</b> <b>api</b> python',
                    'webSearchUrl': 'https://www.bing.com/cr?IG=A244D02924B64251834A10943A795C6D&CID=3EC10B5A686D67590265010E695C6633&rd=1&h=jtcNIZONyR--He0zS6iO5X_a85hc-yYmI6cvqwIMxM4&v=1&r=https%3a%2f%2fwww.bing.com%2fsearch%3fq%3dbing%2bsearch%2bapi%2bpython&p=DevEx,5416.1'
                  }
                ]
              },
              'rankingResponse': {
                'mainline': {
                  'items': [
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 0,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.0'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 1,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.1'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 2,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.2'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 3,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.3'
                      }
                    },
                    {
                      'answerType': 'News',
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#News'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 4,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.4'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 5,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.5'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 6,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.6'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 7,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.7'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 8,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.8'
                      }
                    },
                    {
                      'answerType': 'WebPages',
                      'resultIndex': 9,
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#WebPages.9'
                      }
                    }
                  ]
                },
                'sidebar': {
                  'items': [
                    {
                      'answerType': 'RelatedSearches',
                      'value': {
                        'id': 'https://api.cognitive.microsoft.com/api/v5/#RelatedSearches'
                      }
                    }
                  ]
                }
              }
            }        
        ";
    }
}