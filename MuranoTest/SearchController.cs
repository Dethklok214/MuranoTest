using System;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MuranoTest
{
    public class SearchController : Controller 
    {
        public SearchContext context = new SearchContext();

        private bool checkRequest(string request)
        {
            return (from r in context.requests where r.text.Equals(request) select r.text).Contains(request);
        }


        private void addRequest(string request)
        {
            if (!(checkRequest(request)))
                context.requests.Add(new SearchRequest { text = request });
            context.SaveChanges();
        }



        public List<String> searchOffline(string request)
        {
            List<String> results = new List<string>();
            if (checkRequest(request))
            {
                foreach (string s in
                    (from r in context.results where r.SearchRequest.text.Equals(request) select r.Link))
                    results.Add(s);
            }
            return results;
        }

        public List<String> searchOnline(string request)
        {
            string cx = "012667647587121793764:wjrsci2piik";
            string apiKey = "AIzaSyC08jVIf9sA_oicnWK2A48VLz-zyz_l2Q4";
            var online = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + apiKey + "&cx=" + cx + "&q=" + request);
            addRequest(request);
            HttpWebResponse response = (HttpWebResponse)online.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            var searchQuery = (from r in context.requests where r.text.Equals(request) select r).Take(1);
            var idQuery = (from r in context.requests where r.text.Equals(request) select r.Id).Take(1);
            bool flag = false;
            var results = new List<String>();
            foreach (var item in jsonData.items)
            {
                if (!(searchOffline(request).Contains(item.link.ToString())))
                {
                    context.results.Add(new SearchResult
                    {
                        Link = item.link,
                        SearchRequest = searchQuery.First(),
                        SearchRequestId = Convert.ToInt32(idQuery.First()),
                    });
                    flag = true;
                    context.SaveChanges();
                }
               results.Add(item.link.ToString());
                
            }
            if(flag)
            {
                MessageBox.Show("New links avaiable");
            }
            return results;
        }

        
    }
}
